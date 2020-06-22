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
        

    }
}
