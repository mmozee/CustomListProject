using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomList;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CustomListTest
{
    [TestClass]
    public class OverloadMinusTest
    {
        [TestMethod]

        public void DoesTheResultForListOneRemoveDuplicateNumbersThatAreInListTwo()
            
        {
            //Arrange
            CustomList<int> listOne = new CustomList<int>();
            listOne.Add(6);
            listOne.Add(8);
            listOne.Add(12);
            listOne.Add(32);

            CustomList<int> listTwo = new CustomList<int>();
            listTwo.Add(12);
            listTwo.Add(12);
            listTwo.Add(57);

            CustomList<int> result;
            string expected;
            string value;

            //Act
            result = listOne - listTwo;
            expected = "6832";
            value = result.ToString();


            //Assert
            Assert.AreEqual(expected, value);

        }
        [TestMethod]

        public void DoesTheResultForListTwoRemoveDuplicateNumbersThatAreInListOne()

        {
            //Arrange
            CustomList<int> listOne = new CustomList<int>();
            listOne.Add(6);
            listOne.Add(8);
            listOne.Add(12);
            listOne.Add(32);

            CustomList<int> listTwo = new CustomList<int>();
            listTwo.Add(12);
            listTwo.Add(4);
            listTwo.Add(57);

            CustomList<int> result;
            string expected;
            string value; 

            //Act
            result = listTwo - listOne;
            expected = "457";
            value = result.ToString();


            //Assert
            Assert.AreEqual(expected, value);
        }

        [TestMethod]

        public void WhatIfNothingMatchesInTheList()
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
            string expected;
            string value;

            //Act
            result = listTwo - listOne;
            expected = "3457";
            value = result.ToString();

            //Assert
            Assert.AreEqual(expected, value);

        }
        [TestMethod]

        public void WhatIfListsAreIdentical()
        {
            //Arrange
            CustomList<int> listOne = new CustomList<int>();
            listOne.Add(6);
            listOne.Add(8);
            listOne.Add(12);
           
            CustomList<int> listTwo = new CustomList<int>();
            listTwo.Add(6);
            listTwo.Add(8);
            listTwo.Add(12);

            CustomList<int> result;
            int expected;
            int value;

            //Act
            result = listOne - listTwo;
            expected = 0;
            value = result.Count;

            //Assert
            Assert.AreEqual(expected, value);

        }
        [TestMethod]

        public void IfListsHaveDifferentQuantitiesWillTheResultShowTheRemainderIfAllOtherItemsMatch()
        {
            //Arrange
            CustomList<int> listOne = new CustomList<int>();
            listOne.Add(3);
            listOne.Add(4);
            listOne.Add(57);
            listOne.Add(32);

            CustomList<int> listTwo = new CustomList<int>();
            listTwo.Add(3);
            listTwo.Add(4);
            listTwo.Add(57);

            CustomList<int> result;
            string expected;
            string value;

            //Act
            result = listOne - listTwo;
            expected = "32";
            value = result.ToString();

            //Assert
            Assert.AreEqual(expected, value);
        }


     
    }
    
}
   


