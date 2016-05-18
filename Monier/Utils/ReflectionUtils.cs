using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Monier.Utils
{
    /// <summary>
    /// Provides methods to manipulate types and expressions via reflection or introspection
    /// </summary>
    public static class ReflectionUtils
    {
        /// <summary>
        /// Gets the property name of a class
        /// </summary>
        /// <typeparam name="T">type of the class</typeparam>
        /// <param name="propertyExpression">expression that contains the class and the property</param>
        /// <returns>property name of a class</returns>
        public static string GetPropertyName<T>(Expression<Func<T, dynamic>> propertyExpression)
        {
            MemberExpression body = propertyExpression.Body as MemberExpression;

            if (body == null)
            {
                UnaryExpression ubody = (UnaryExpression)propertyExpression.Body;
                body = ubody.Operand as MemberExpression;
            }
            return body.Member.Name;
        }
    }
}
