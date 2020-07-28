using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Common.Extensions
{
    public static class ReflectionExtensions
    {
        public static TAttribute GetSpecificAttribute<TAttribute>(this PropertyInfo property)
            where TAttribute : Attribute
            => (TAttribute)property.GetCustomAttribute(typeof(TAttribute), true);
    }
}
