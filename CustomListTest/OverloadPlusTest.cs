using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.CodeDom;
using CustomList;

namespace CustomListTest
{
    [TestClass]
     public  class OverloadPlusTest
     {
        [TestMethod]

        public void DidMethodCaptureFirstValueOfTheFirstList()
        {
            //Arrange
            CustomList<int> listOne = new CustomList<int>();
            listOne.Add(6);
            listOne.Add(8);
            listOne.Add(12);
            listOne.Add(32);

            CustomList<int> listTwo = new CustomList<int>();
            listTwo.Add(3);
            listTwo.Add(4);
            listTwo.Add(57);

            CustomList<int> result;
            int expected;
            int value;

            //Act
            result = listOne + listTwo;
            expected = listOne[0];
            value = result[0];


            //Assert
            Assert.AreEqual(expected,value);
        }

        [TestMethod]
        public void DidMethodCaptureFirstValueOfTheSecondList()
        {
            //Arrange
            CustomList<int> listOne = new CustomList<int>();
            listOne.Add(6);
            listOne.Add(8);
            listOne.Add(12);
            listOne.Add(32);

            CustomList<int> listTwo = new CustomList<int>();
            listTwo.Add(3);
            listTwo.Add(4);
            listTwo.Add(57);

            CustomList<int> result;
            int expected;
            int value;

            //Act
            result = listOne + listTwo;
            expected = listTwo[0];
            value = result[4];


            //Assert
            Assert.AreEqual(expected, value);
        }

        [TestMethod]
        public void DidResultOfListMergeTheTwoLists()
        {
            //Arrange
            CustomList<int> listOne = new CustomList<int>();
            listOne.Add(6);
            listOne.Add(8);
            listOne.Add(12);
            listOne.Add(32);

            CustomList<int> listTwo = new CustomList<int>();
            listTwo.Add(3);
            listTwo.Add(4);
            listTwo.Add(57);

            CustomList<int> expected = new CustomList<int>();
            expected.Add(6);
            expected.Add(8);
            expected.Add(12);
            expected.Add(32);
            expected.Add(3);
            expected.Add(4);
            expected.Add(57);

            CustomList<int> result;


            //Act
            result = listOne + listTwo;
                                 

            //Assert
            Assert.AreEqual(expected.ToString(), result.ToString());
        }

        [TestMethod]
        public void WereAllTheVariablesOfTheFirstListCaptured()
        {
            //Arrange
            

            CustomList<int> listOne = new CustomList<int>();
            listOne.Add(6);
            listOne.Add(8);
            listOne.Add(12);
            listOne.Add(32);
            CustomList<int> listTwo = new CustomList<int>();
            listTwo.Add(3);
            listTwo.Add(4);
            listTwo.Add(57);

            CustomList<int> result = listOne + listTwo;
            result.Add(6);
            result.Add(8);
            result.Add(12);
            result.Add(32);
            result.Add(3);
            result.Add(4);
            result.Add(57);


            //Act
            int expected = result[3];
            int value = listOne[3];
           
            //{
            //    if (expected[3] == 32)
            //    {
            //        areAllListOneItemsThere = true;
            //    }
            //}
            //return true;


            //Assert
            Assert.AreEqual(expected, value);
        }

        [TestMethod]
        public void IsTheFirstItemForTheSecondListPlacedAfterTheLastItemOfTheFirstList()
        {
            //Arrange


            CustomList<int> listOne = new CustomList<int>();
            listOne.Add(6);
            listOne.Add(8);
            listOne.Add(12);
            listOne.Add(32);
            CustomList<int> listTwo = new CustomList<int>();
            listTwo.Add(3);
            listTwo.Add(4);
            listTwo.Add(57);

            CustomList<int> result = listOne + listTwo;
            result.Add(6);
            result.Add(8);
            result.Add(12);
            result.Add(32);
            result.Add(3);
            result.Add(4);
            result.Add(57);


            //Act
            int expected = result[4];
            int value = listTwo[0];

            //Assert
            Assert.AreEqual(expected, value);
        }
    }
}
