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

            Assert.AreEqual(testCurser.BasePrice, 15);
        }

        [TestMethod]
        public void Curser_CurrentPriceAt0()
        {
            var testCurser = new CurserManager();

            Assert.AreEqual(testCurser.CurrentPrice, 15);
        }

        [TestMethod]
        public void Curser_CurrentPriceAt100()
        {
            var testCurser = new CurserManager();
            testCurser.NumberOfBuildings = 100;

            Assert.AreEqual(testCurser.CurrentPrice, 17614702);
        }

        [TestMethod]
        public void Curser_CurrentPriceAt400()
        {
            var testCurser = new CurserManager();
            testCurser.NumberOfBuildings = 400;

            Assert.AreEqual(testCurser.CurrentPrice, 28525114772292825768936023d);
        }
    }
}
