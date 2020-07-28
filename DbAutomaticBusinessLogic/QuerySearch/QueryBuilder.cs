using CarStoreDatabaseAccess.DatabaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using Common.Extensions;
using System.Linq.Dynamic.Core;
using CrudAutomaticBusinessLogic.Exceptions;

namespace CrudAutomaticBusinessLogic.QuerySearch
{
    public class QueryBuilder<TEntity>
        where TEntity : BaseModel
    {
        public IQueryable<TEntity> _query;
        private readonly ParsingConfig _parsingConfig;

        public QueryBuilder(IQueryable<TEntity> query)
        {
            _query = query;
            _parsingConfig = new ParsingConfig();
        }

        private void AdaptWhere(PropertyInfo property, CrudSearch search)
        {
            var searchFieldAttribute = property.GetSpecificAttribute<SearchFieldAttribute>();

            var propertyValue = property.GetValue(search);

            if(propertyValue == null)
            {
                return;
            }

            var anyFieldsToCompareWith = searchFieldAttribute?._fieldsToCompareWith.Any() == null ? false : searchFieldAttribute._fieldsToCompareWith.Any();

            if (!anyFieldsToCompareWith)
            {
                if (searchFieldAttribute != null)
                {
                    SetUpWhereForSingleProperty(propertyValue, property.Name, searchFieldAttribute._comparation);
                }
                else
                {
                    SetUpWhereForSingleProperty(propertyValue, property.Name);
                }
            }
            else
            {
                SetUpWhereForProvidedProperties(propertyValue, searchFieldAttribute);
            }
        }

        private bool PropertyExists(string propertyName)
        {
            var propertyToAdd = GetProperty(propertyName);

            return propertyToAdd != null;
        }

        private void SetUpWhereForSingleProperty(object propertyValue, string propertyName, ComparationType? comparation = ComparationType.Equal)
        {
            var propertyToCompareWith = GetProperty(propertyName)?.Name;

            if (propertyToCompareWith == null && propertyValue != null)
            {
                throw new UnexistingColumnException(propertyName);
            }

            if (propertyValue != null)
            {
                _query = _query.Where(_parsingConfig, propertyToCompareWith + MakeOperator((ComparationType)comparation), propertyValue);
            }
        }

        private void SetUpWhereForProvidedProperties(object propertyValue , SearchFieldAttribute searchFieldAttribute)
        {
            var queryWhereClause = string.Empty;

            var properties = searchFieldAttribute._fieldsToCompareWith.ToList();

            var firstProperty = properties.First();

            queryWhereClause += AddPartOfWhereClause(searchFieldAttribute, queryWhereClause, firstProperty);

            properties.Remove(firstProperty);

            foreach (var propertyToCompareWith in properties)
            {
                queryWhereClause += " || ";
                queryWhereClause = AddPartOfWhereClause(searchFieldAttribute, queryWhereClause, propertyToCompareWith);
            }

            if (propertyValue != null)
            {
                _query = _query.Where(_parsingConfig, queryWhereClause, propertyValue);
            }
        }

        private string AddPartOfWhereClause(SearchFieldAttribute searchFieldAttribute, string queryWhereClause, string propertyToCompareWith)
        {
            if(IsNavigationProperty(propertyToCompareWith))
            {
                queryWhereClause += SetupDefaultPartOfQueryForNavigationPropertyName(propertyToCompareWith, searchFieldAttribute);
            }
            if (PropertyExists(propertyToCompareWith))
            {
                queryWhereClause += propertyToCompareWith + MakeOperator(searchFieldAttribute._comparation);
            }
            if (!PropertyExists(propertyToCompareWith) && !IsNavigationProperty(propertyToCompareWith))
            {
                throw new UnexistingColumnException(propertyToCompareWith);
            }
            return queryWhereClause;
        }

        private bool IsNavigationProperty(string propertyToCompareWith)
        {
            return propertyToCompareWith.Split(".").Count() > 1;
        }

        private string SetupDefaultPartOfQueryForNavigationPropertyName(string navigationProperty, SearchFieldAttribute attribute)
        {
            var propertyParts = navigationProperty.Split(".").ToList();

            var property = GetProperty(propertyParts.First());

            if (property == null)
            {
                throw new UnexistingColumnException(propertyParts.First());
            }

            propertyParts.Remove(propertyParts.First());

            var queryString = property.Name;

            if (!property.PropertyType.GenericTypeArguments.Any())
            {
                queryString = BuildLinearNavigationQuery(propertyParts, property, queryString);

                return queryString + MakeOperator(attribute._comparation);
            }
            
            queryString = BuildCustomFilterQuery(propertyParts, property, queryString, attribute);

            return queryString;
        }

        private string BuildCustomFilterQuery(List<string> propertyParts, PropertyInfo property, string queryString, SearchFieldAttribute attribute)
        {
            queryString += ".Where(o => o";

            foreach (var part in propertyParts.Where(x => x != propertyParts.Last()))
            {
                queryString += ".";

                if (!property.PropertyType.GenericTypeArguments.Any())
                {
                    property = property.PropertyType.GetProperty(part);
                }
                else
                {
                    property = property.PropertyType.GenericTypeArguments.FirstOrDefault()?.GetProperty(part);
                }
                if (property == null)
                {
                    throw new UnexistingColumnException(part);
                }

                queryString += property.Name;
            }

            queryString += $" == \"{propertyParts.Last()}\").FirstOrDefault().Value{MakeOperator(attribute._comparation)}";

            return queryString;
        }

        private string BuildLinearNavigationQuery(List<string> propertyParts, PropertyInfo property, string queryString)
        {
            foreach (var part in propertyParts)
            {
                property = property.PropertyType.GetProperty(part);

                if (property == null)
                {
                    throw new UnexistingColumnException(part);
                }

                queryString += "." + property.Name;
            }

            return queryString;
        }

        private string MakeOperator(ComparationType comparation)
        {
            switch (comparation)
            {
                case ComparationType.Contains:
                    return $".ToLower().Contains(@0.ToLower())";
                case ComparationType.Equal:
                    return $" == @0 ";
                case ComparationType.LessThan:
                    return $" < @0 ";
                case ComparationType.LessThanOrEqual:
                    return $" <= @0 ";
                case ComparationType.GreaterThan:
                    return $" > @0 ";
                case ComparationType.GreaterThanOrEqual:
                    return $" >= @0 ";
                case ComparationType.StartsWith:
                    return $".StartsWith(@0.ToLower())";
                default:
                    break;
            }

            return "== @0";
        }

        public void FilterQuery(CrudSearch search)
        {
            foreach (var property in GetRelevantProperties(search))
            {
                AdaptWhere(property, search);
            }
        }

        public void Paginate(CrudSearch search)
        {
            var propertyToOrderBy = search.SortProperty;

            if (search.QuerySort == QuerySort.ASC)
            {
                _query = _query.OrderBy(propertyToOrderBy + " ASC");
            }
            if (search.QuerySort == QuerySort.DESC)
            {
                _query = _query.OrderBy(propertyToOrderBy + " DESC");
            }

            _query = _query.Skip(search.Page * search.PerPage - search.PerPage);

            _query = _query.Take(search.PerPage);
        }

        private IEnumerable<PropertyInfo> GetRelevantProperties(CrudSearch crudSearch)
        {
            return crudSearch.GetType().GetProperties().Where(x => !typeof(CrudSearch).GetProperties().Any(y => y.Name == x.Name));
        }

        private PropertyInfo GetProperty(string propertyName)
        {
            return typeof(TEntity).GetProperty(propertyName);
        }
    }
}
