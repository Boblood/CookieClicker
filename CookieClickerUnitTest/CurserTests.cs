using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CCModel.Controller;

namespace CookieClickerUnitTest
{
    [TestClass]
    public class CurserTests
    {
        [TestMethod]
        public void Curser_DefaultConstructor()
        {
            var testCurser = new CurserManager();

            Assert.IsNotNull(testCurser);
        }

        [TestMethod]
        public void Curser_BasePrice()
        {
            var testCurser = new CurserManager();


        }
    }
}
