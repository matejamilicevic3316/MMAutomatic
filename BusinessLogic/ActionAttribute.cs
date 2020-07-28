using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic
{
    public class ActionAttribute : Attribute
    {
        public ActionType _action;
        public ActionAttribute(ActionType action)
        {
            _action = action;
        }
    }
    public enum ActionType
    {
        Add = 1,
        Update = 2
    }
}
