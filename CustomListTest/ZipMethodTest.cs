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
    public class ZipMethodTest
    {
        [TestMethod]
        public void DoesZipMethodTakeFirstItemOfTheListOneAndBecomeTheZeroIndexForNewList()
        {
            //Arrange
            CustomList<int> listOne = new CustomList<int>();
            CustomList<int> listTwo = new CustomList<int>();
            listOne.Add(6);
            listOne.Add(8);
            listOne.Add(12);
           

            listTwo.Add(3);
            listTwo.Add(4);
            listTwo.Add(57);

            int expectedValue;
            CustomList<int> value;
            

            //Act
            expectedValue = listOne[0];
            value = listOne.Zip(listTwo);

            //Assert
            Assert.AreEqual(expectedValue, value[0]);
        }

        [TestMethod]
        public void DoesZipMethodTakeFirstItemOfTheListTwoAndPutItAfterListOneFirstItem()
        {   //Arrange
            CustomList<int> listOne = new CustomList<int>();
            CustomList<int> listTwo = new CustomList<int>();
            listOne.Add(6);
            listOne.Add(8);
            listOne.Add(12);
            

            listTwo.Add(3);
            listTwo.Add(4);
            listTwo.Add(57);

            int expectedValue;
            CustomList<int> value;


            //Act
            expectedValue = listTwo[0];
            value = listOne.Zip(listTwo);

            //Assert
            Assert.AreEqual(expectedValue, value[1]);
        }

        [TestMethod]
        public void DoesZipMethodMergeListsIntoANewList()
        {   
            //Arrange
            CustomList<int> listOne = new CustomList<int>();
            CustomList<int> listTwo = new CustomList<int>();
            listOne.Add(6);
            listOne.Add(8);
            listOne.Add(12);
           

            listTwo.Add(3);
            listTwo.Add(4);
            listTwo.Add(57);

            string expectedValue;
            CustomList<int> value;


            //Act
            expectedValue = "63841257";
            value = listOne.Zip(listTwo);


            //Assert
            Assert.AreEqual(expectedValue, value.ToString());
        }

        [TestMethod]
        public void DoesMethodWorkIfTheItemsCountsDontMatch()
        {
            //Arrange
            CustomList<int> listOne = new CustomList<int>();
            CustomList<int> listTwo = new CustomList<int>();
            listOne.Add(6);
            listOne.Add(8);
            listOne.Add(12);
            listOne.Add(32);
            listOne.Add(7);

            listTwo.Add(3);
            listTwo.Add(4);
            listTwo.Add(57);

            string expectedValue;
            CustomList<int> value;


            //Act
            expectedValue = "63841257327";
            value = listOne.Zip(listTwo);


            //Assert
            Assert.AreEqual(expectedValue, value.ToString());
        }

        [TestMethod]
        public void DidItemIndexesChangeToReflectNewLocationInTheList()
        {
            //Arrange
            CustomList<int> listOne = new CustomList<int>();
            CustomList<int> listTwo = new CustomList<int>();
            listOne.Add(6);
            listOne.Add(8);
            listOne.Add(12);
            listOne.Add(32);
            listOne.Add(7);

            listTwo.Add(3);
            listTwo.Add(4);
            listTwo.Add(57);

            string expectedValue;
            CustomList<int> value;


            //Act
            expectedValue = "57";
            value = listTwo.Zip(listOne);

            //Assert
            Assert.AreEqual(expectedValue, value[4].ToString());
        }


    }
}