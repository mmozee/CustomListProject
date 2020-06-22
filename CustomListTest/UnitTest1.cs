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
      

    }
}
