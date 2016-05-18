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
    public class ReflectionUtilsTests
    {
        private const string Category = "Monier.ReflectionUtils";

        [TestMethod]
        [TestCategory(Category)]
        public void GetPropertyName()
        {
            string name = null;
            name = ReflectionUtils.GetPropertyName<Class1>(t => t.Id);
            Assert.IsTrue(string.Compare(name, "Id") == 0);
            name = ReflectionUtils.GetPropertyName<Class1>(t => t.Class2Property.Label);
            Assert.IsTrue(string.Compare(name, "Label") == 0);
        }

        #region <Custom Classes>
        /// <summary>
        /// Dump class
        /// </summary>
        public class Class1
        {
            public int Id { get; set; }
            public int Name { get; set; }
            public Class2 Class2Property { get; set; }
        }
        /// <summary>
        /// Dump class
        /// </summary>
        public class Class2
        {
            public int Id { get; set; }
            public int Label { get; set; }
        }
        #endregion </Custom Classes>
    }
}
