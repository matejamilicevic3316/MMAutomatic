using System;
using System.Collections.Generic;
using System.Text;

namespace CrudAutomaticBusinessLogic.Exceptions
{
    public class UnexistingColumnException : Exception
    {
        public string Error;
        public UnexistingColumnException(string columnName) 
        {
            Error = "Unexisting column : " + columnName;
        }
    }
}
