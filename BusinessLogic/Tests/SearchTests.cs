using BusinessLogic.Models;
using BusinessLogic.Models.Ads;
using BusinessLogic.Models.Users;
using BusinessLogic.SearchObjects;
using CarStoreDatabaseAccess.DatabaseModels;
using CrudAutomaticBusinessLogic.QuerySearch;
using CrudAutomaticBusinessLogic.CrudExecutors;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;
using CrudAutomaticBusinessLogic;

namespace BusinessLogic.Tests
{
    public class SearchTests : IClassFixture<DbContextFixture>
    {
        private readonly DbContextFixture DbContextFixture;
        private SearchExecutor<TEntity, TDto> SearchExecutor<TEntity, TDto>()
            where TEntity : BaseModel
            where TDto : IdentifyableDto
        {
            return new SearchExecutor<TEntity, TDto>(DbContextFixture.Context, DbContextFixture.Mapper);
        }

        public SearchTests(DbContextFixture dbContextFixture)
        {
            DbContextFixture = dbContextFixture;
        }

        [Fact]
        public void SearchWithoutAnyDataProvidedInSearchObject_ReturnsAll()
        {
            var executor = SearchExecutor<Role, RoleDto>();

            var searchObject = new RoleSearch();

            var result = (IEnumerable<RoleDto>)executor.Execute(searchObject);

            result.Count().Should().Be(3);
        }

        [Fact]
        public void SearchWithSearchObjectFilled_ReturnsOneRole()
        {
            var executor = SearchExecutor<Role, RoleDto>();

            var searchObject = new RoleSearch
            {
                Name = "Role 1"
            };

            var result = (IEnumerable<RoleDto>)executor.Execute(searchObject);

            result.Count().Should().Be(1);
        }

        [Fact]
        public void SearchLinearByRole()
        {
            var executor = SearchExecutor<User, ReadUserDto>();

            var searchObject = new FakeUserSearch
            {
                RoleId = 1
            };

            var result = (IEnumerable<ReadUserDto>)executor.Execute(searchObject);

            result.Count().Should().Be(1);

            searchObject = new FakeUserSearch
            {
                RoleId = 2
            };

            result = (IEnumerable<ReadUserDto>)executor.Execute(searchObject);

            result.Count().Should().Be(2);
        }
        [Fact]
        public void SearchByAdValue()
        {
            var executor = SearchExecutor<Ad, ReadAdDto>();

            var searchObject = new AdsSearch
            {
                MinHorsePower = 80,
                MaxHorsePower = 120
            };

            var result = (IEnumerable<ReadAdDto>)executor.Execute(searchObject);

            result.Count().Should().Be(1);

            searchObject = new AdsSearch
            {
                MinHorsePower = 60,
                MaxHorsePower = 80
            };

            result = (IEnumerable<ReadAdDto>)executor.Execute(searchObject);

            result.Count().Should().Be(1);
        }

        public class FakeUserSearch : UserSearch
        {
            [SearchField(ComparationType.Equal, "Role.Id")]
            public int RoleId { get; set; }
        }
    }
}
