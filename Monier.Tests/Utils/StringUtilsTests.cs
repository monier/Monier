using Microsoft.VisualStudio.TestTools.UnitTesting;
using Monier.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monier.Tests.Utils
{
    [TestClass]
    public class StringUtilsTests
    {
        private const string Category = "Monier.StringUtils";

        [TestMethod]
        [TestCategory(Category)]
        public void AppendString()
        {
            string text = "my text";

            var text1 = StringUtils.AppendString(text, " ", "is appended");
            Assert.IsTrue(string.Compare(text1, "my text is appended") == 0);
            var text2 = StringUtils.AppendString(text, "-", null);
            Assert.IsTrue(string.Compare(text2, "my text") == 0);
            var text3 = StringUtils.AppendString(text, "", " ");
            Assert.IsTrue(string.Compare(text3, "my text ") == 0);
        }
        [TestMethod]
        [TestCategory(Category)]
        public void AppendStrings()
        {
            string text = "my text";

            var text1 = StringUtils.AppendStrings(text, ",", "al", "ol", "il");
            Assert.IsTrue(string.Compare(text1, "my text,al,ol,il") == 0);
            var text2 = StringUtils.AppendStrings(text, "-", null, null, "mitch");
            Assert.IsTrue(string.Compare(text2, "my text-mitch") == 0);
        }
        [TestMethod]
        [TestCategory(Category)]
        public void SplitToArray()
        {
            string text = "1,2,3,4";

            var items1 = StringUtils.SplitToArray<int>(text, ",", s => int.Parse(s));
            Assert.IsTrue(items1 != null && items1.Count() == 4);
            Assert.IsTrue(items1[0] == 1 && items1[1] == 2 && items1[2] == 3 && items1[3] == 4);
        }
        [TestMethod]
        [TestCategory(Category)]
        [ExpectedException(typeof(Exception), AllowDerivedTypes = true)]
        public void SplitToArray_exception_raised_if_conversion_failed()
        {
            string text = "1,2,3,4";

            var items1 = StringUtils.SplitToArray<int>(text, "-", s => int.Parse(s));
        }
    }
}
