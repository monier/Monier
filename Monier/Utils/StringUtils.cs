using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Monier.Utils
{
    /// <summary>
    /// Provides methods to manipulate strings
    /// </summary>
    public static class StringUtils
    {
        /// <summary>
        /// Appends text to another text with separator
        /// </summary>
        /// <param name="text">original text</param>
        /// <param name="separator">separator</param>
        /// <param name="toappend">text to append</param>
        /// <returns>joined texts with the separator</returns>
        public static string AppendString(string text, string separator, string toappend)
        {
            string value = text;

            if (!string.IsNullOrEmpty(text) && !string.IsNullOrEmpty(toappend))
                value += separator;
            value += toappend;
            return value;
        }
        /// <summary>
        /// Appends an array of text to another text with separator
        /// </summary>
        /// <param name="text">original text</param>
        /// <param name="separator">separator</param>
        /// <param name="toappends">array of text to append</param>
        /// <returns>joined texts with the separator</returns>
        public static string AppendStrings(string text, string separator, params string[] toappends)
        {
            string value = text;

            if (toappends != null && toappends.Length > 0)
            {
                foreach (string toappend in toappends)
                    value = AppendString(value, separator, toappend);
            }
            return value;
        }
        /// <summary>
        /// Splits text to array of typed items
        /// </summary>
        /// <typeparam name="T">type of items in new array</typeparam>
        /// <param name="text">text to split</param>
        /// <param name="separator">separator</param>
        /// <param name="converter">function that converts the text into an array element</param>
        /// <returns>array of typed items that resulted from the split and conversion of initial text</returns>
        public static T[] SplitToArray<T>(string text, string separator, Func<string, T> converter)
        {
            List<T> list = new List<T>();

            if (!string.IsNullOrWhiteSpace(text))
            {
                string[] vals = text.Split(new string[] { separator }, StringSplitOptions.RemoveEmptyEntries);
                if (vals != null)
                {
                    foreach (string s in vals)
                        list.Add(converter(s));
                }
            }
            return list.ToArray();
        }
    }
}
