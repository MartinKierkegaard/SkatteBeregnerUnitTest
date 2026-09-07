using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestConsoleAppDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestConsoleAppDemo.Tests
{
    [TestClass()]
    public class SkatteBeregnerTests
    {
        [TestMethod()]
        public void BeregnSkatHvisIndkomstEr0ellerMindreTest()
        {
            //Arrange
            SkatteBeregner sb = new SkatteBeregner();

            //Act
            int actualValue = sb.BeregnSkat(0, 4);

            //Assert
            Assert.AreEqual(0, actualValue);

        }


        [TestMethod()]
        public void BeregnSkatIndkomstEr20000LavSKatTest()
        {
            //Arrange
            SkatteBeregner sb = new SkatteBeregner();

            //Act
            int actualValue = sb.BeregnSkat(20000, 4);

            //Assert

            Assert.AreEqual(2000, actualValue);

        }

        [DataTestMethod]
        [DataRow(1, 0, 0)]
        [DataRow(2, 0, 0)]
        [DataRow(1, -1, 0)]
        [DataRow(2, -1, 0)]
        [DataRow(1, 10000, 500)]
        [DataRow(2, 10000, 500)]
        [DataRow(1, 20000, 1000)]
        [DataRow(2, 20000, 1000)]
        [DataRow(1, 20001, 1000)]
        [DataRow(2, 20001, 1000)]
        [DataRow(3, 20000, 2000)]
        [DataRow(3, 20001, 4000)]

        public void BeregnSkatPersonKategori1_2_3(int kategori, int indkomst, int expectedValue)
        {
            //arrange
            SkatteBeregner sb = new SkatteBeregner();

            //Act
            int actualValue = sb.BeregnSkat(indkomst, kategori);

            //Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

    }
}