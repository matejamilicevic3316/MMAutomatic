using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace CrudAutomaticBusinessLogic.Exceptions
{
    public class CrudValidationException : Exception
    {
        public IEnumerable<ParsedError> Errors;
        public CrudValidationException(IList<ValidationFailure> errors)
        {
            Errors = SetUpErrorsText(errors);
        }

        private IEnumerable<ParsedError> SetUpErrorsText(IList<ValidationFailure> errors)
        {
            var parsedErrors = new List<ParsedError>();
            foreach(var error in errors)
            {
                parsedErrors.Add(new ParsedError { PropertyName = error.PropertyName, ErrorMessage = error.ErrorMessage });
            }
            return parsedErrors;
        }
    }
    public class ParsedError
    {
        public string PropertyName { get; set; }
        public string ErrorMessage { get; set; }
    }
}
