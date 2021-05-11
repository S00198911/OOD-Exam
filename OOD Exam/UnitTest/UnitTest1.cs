using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using OOD_Exam;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodPriceDecrease()
        {
            //ARRANGE
            Game g1 = new Game(0, "", "", 0, 50m, "", "");
            decimal finalPrice = 40m;

            //ACT
            g1.DecreasePrice(10m);

            //ASSERT
            Assert.AreEqual(finalPrice, g1.Price);
        }
    }
}
