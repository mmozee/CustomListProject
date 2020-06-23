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
        public void DoesTheItemsShiftAfterRemovingItemFromTheMiddle()
        {
            //Arrange
            CustomList<int> ourCustomList = new CustomList<int>();
            ourCustomList.Add(6);
            ourCustomList.Add(8);
            ourCustomList.Add(12);
            ourCustomList.Add(32);
            ourCustomList.Add(7);
            int expectedValue =32;
            int value;

            //Act
            ourCustomList.Remove(12);
            value = ourCustomList[2];
            
            //Assert
            Assert.AreEqual(expectedValue,value);

        }
        [TestMethod]
        public void IfTheItemIsNotInTheListReturnFalse()
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
        [TestMethod]
        public void IfTheItemIsInTheListReturnTrue()
        {
            //Arrange
            CustomList<int> ourCustomList = new CustomList<int>();
            ourCustomList.Add(6);
            ourCustomList.Add(8);
            ourCustomList.Add(12);
            ourCustomList.Add(32);
            ourCustomList.Add(7);
            bool isItemInList;
            bool expectedValue = true;

            //Act
            ourCustomList.Remove(32);
            isItemInList = true;



            //Assert
            Assert.AreEqual(expectedValue, isItemInList);
        }
        [TestMethod]
        public void SeeIfListIsAdjustedByOneIfAllValuesAreTheSame()
        {
            //Arrange
            CustomList<int> ourCustomList = new CustomList<int>();
            ourCustomList.Add(5);
            ourCustomList.Add(5);
            ourCustomList.Add(5);
            ourCustomList.Add(5);
            int isItemInList;
            int expectedValue = 3;

            //Act
            ourCustomList.Remove(5);

            isItemInList = ourCustomList.count;


            //Assert
            Assert.AreEqual(expectedValue, isItemInList);
        }
    }

}



