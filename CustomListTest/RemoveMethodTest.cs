using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace CustomListTest
{
    [TestClass]
    public class RemoveMethodTest
    {
        [TestMethod]
        public void WasItemAtIndexZeroRemoved()
        {
            //Arrange
            CustomList<int> ourCustomList = new CustomList<int>();
            ourCustomList.Add(6);
            ourCustomList.Add(8);
            ourCustomList.Add(12);
            int value;
            int indexExpectedValue = 8;

            //Act
            ourCustomList.Remove(6);
            value = ourCustomList[0];
 
            //Assert
            Assert.AreEqual(indexExpectedValue, value);

        }
    }
}


