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
        [TestMethod]
        public void IsCounterDecresasesByOne()
        {
            //Arrange
            CustomList<int> ourCustomList = new CustomList<int>();
            ourCustomList.Add(6);
            ourCustomList.Add(8);
            ourCustomList.Add(12);
            int countExpectedValue = 2;

            //Act
            ourCustomList.Remove(6);


            //Assert
            Assert.AreEqual(countExpectedValue, ourCustomList.count);
        }
        [TestMethod]
        public void DoesCapacityDecreaseAfterRemovingFifthItem()
        {
            //Arrange
            CustomList<int> ourCustomList = new CustomList<int>();
            ourCustomList.Add(6);
            ourCustomList.Add(8);
            ourCustomList.Add(12);
            ourCustomList.Add(32);
            ourCustomList.Add(7);
            int expectedCapacityValue = ourCustomList.capacity / 2;

            //Act
            ourCustomList.Remove(7);


            //Assert
            Assert.AreEqual(expectedCapacityValue, ourCustomList.capacity);

        }
        [TestMethod]
        public void DoesIndexFourStayAtTheCorrectValueWhenFifthItemIsRemoved()
        {
            //Arrange
            CustomList<int> ourCustomList = new CustomList<int>();
            ourCustomList.Add(6);
            ourCustomList.Add(8);
            ourCustomList.Add(12);
            ourCustomList.Add(32);
            ourCustomList.Add(7);
            int indexExpectedValue = 32;
            int value;

            //Act
            ourCustomList.Remove(7);
            value = ourCustomList[4];



            //Assert
            Assert.AreEqual(indexExpectedValue, value);

        }
        [TestMethod]
        public void IsTheItemInTheListReturnFalse()
        {
            //Arrange
            CustomList<int> ourCustomList = new CustomList<int>();
            ourCustomList.Add(6);
            ourCustomList.Add(8);
            ourCustomList.Add(12);
            ourCustomList.Add(32);
            ourCustomList.Add(7);
            bool isItemInList;
            bool expectedValue = false;

            //Act
            ourCustomList.Remove(4);
            isItemInList = false;



            //Assert
            Assert.AreEqual(expectedValue, isItemInList);
        }
    }

}



