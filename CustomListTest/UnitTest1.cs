using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;



namespace CustomListTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void DidCountChangeToReflectNewItemAdded()
        {
            //Arrange
            CustomList<int> ourCustomList = new CustomList<int>();
            int expectedValue = 1;

            //Act
            ourCustomList.Add(6);

            //Assert
            Assert.AreEqual(expectedValue, ourCustomList.count);
        }
        public void WasIndexIncreasedAfterFifthItemWasAdded()
        {
            //Arrange
            CustomList<int> ourCustomList = new CustomList<int>();
            int indexexpectedValue = 8;

            //Act
            ourCustomList.Add(6);
            ourCustomList.Add(8);
            ourCustomList.Add(12);
            ourCustomList.Add(32);
            ourCustomList.Add(7);


            //Assert
            Assert.AreEqual(indexexpectedValue, ourCustomList.capacity);

        }
        public void DidFirstItemGoToIndexZero()
        {
            //Arrange
            CustomList<int> ourCustomList = new CustomList<int>();
            int expectedValue = 6;
            int value;

            //Act
            ourCustomList.Add(6);
            value = ourCustomList[0];

            //Assert
            Assert.AreEqual(expectedValue, value);
        }
        public void AfterFifthAddDidCountIncreaseCorrectly()
        {
            //Arrange
            CustomList<int> ourCustomList = new CustomList<int>();
            int countExpectedValue = 5;

            //Act
            ourCustomList.Add(6);
            ourCustomList.Add(8);
            ourCustomList.Add(12);
            ourCustomList.Add(32);
            ourCustomList.Add(7);


            //Assert
            Assert.AreEqual(countExpectedValue, ourCustomList.count);
        }
        public void IsTheThirdIndexValueCorrectAfterIncreasingCapacity()
        {
            //Arrange
            CustomList<int> ourCustomList = new CustomList<int>();
            int indexexpectedValue = 32;
            int value;

            //Act
            ourCustomList.Add(6);
            ourCustomList.Add(8);
            ourCustomList.Add(12);
            ourCustomList.Add(32);
            ourCustomList.Add(7);
            value = ourCustomList[3];

            //Assert
            Assert.AreEqual(indexexpectedValue, value);
        }

    }
}
