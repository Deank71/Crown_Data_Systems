using Microsoft.VisualStudio.TestTools.UnitTesting;
using CDS.MainApplicationTests.Library.ReverseArray;
using System;
using System.Collections.Generic;
using System.Text;

namespace CDS.MainApplicationTests.Library.ReverseArray.Tests
{
    [TestClass()]
    public class ReverseBtyeTests
    {
        [TestMethod()]
        public void ReverseTest()
        {
            //Arrange
            byte[] array = { 0, 100, 120, 210, 255 };
            ReverseBtye reverseBtye = new ReverseBtye();

            //Act
            byte[] reverseArray = reverseBtye.Reverse(array);

            //Assert
            Assert.IsTrue(reverseArray[0] == array[4]);
        }
    }
}