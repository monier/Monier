using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Monier.Utils;

namespace Monier.Tests.Utils
{
    [TestClass]
    public class DateTimeUtilsTests
    {
        private const string Category = "Monier.DateTimeUtils";

        [TestMethod]
        [TestCategory(Category)]
        public void GetFirstDateOfDay()
        {
            DateTime date = new DateTime(2016, 1, 3, 5, 0, 0);

            var date1 = date.GetFirstDateOfDay();
            Assert.IsTrue(date1 == new DateTime(2016, 1, 3, 0, 0, 0));
        }
        [TestMethod]
        [TestCategory(Category)]
        public void GetLastDateOfDay()
        {
            DateTime date = new DateTime(2016, 1, 3, 5, 0, 0);

            var date1 = date.GetLastDateOfDay();
            Assert.IsTrue(date1 == new DateTime(2016, 1, 3, 23, 59, 59));
        }
        [TestMethod]
        [TestCategory(Category)]
        public void GetFirstDateOfMonth()
        {
            DateTime date = new DateTime(2016, 1, 3, 5, 0, 0);

            var date1 = date.GetFirstDateOfMonth();
            Assert.IsTrue(date1 == new DateTime(2016, 1, 1));
        }
        [TestMethod]
        [TestCategory(Category)]
        public void GetLastDateOfMonth()
        {
            DateTime date = new DateTime(2016, 1, 3, 5, 0, 0);

            var date1 = date.GetLastDateOfMonth();
            Assert.IsTrue(date1 == new DateTime(2016, 1, 31, 23, 59, 59));
        }
        [TestMethod]
        [TestCategory(Category)]
        public void GetFirstDateOfYear()
        {
            int year = 2016;

            var date1 = DateTimeUtils.GetFirstDateOfYear(year);
            Assert.IsTrue(date1 == new DateTime(2016, 1, 1, 0, 0, 0));
        }
        [TestMethod]
        [TestCategory(Category)]
        public void GetLastDateOfYear()
        {
            int year = 2016;

            var date1 = DateTimeUtils.GetLastDateOfYear(year);
            Assert.IsTrue(date1 == new DateTime(2016, 12, 31, 23, 59, 59));
        }
    }
}
