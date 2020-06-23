using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomList;

namespace CustomListTest
{
    [TestClass]
    public class ToStringMethodTest
    {
        [TestMethod]

        public void DidTheBoolValueConvertToAString()
        {
            //Arrange - member variable
            CustomList<bool> ourList = new CustomList<bool>();
            ourList.Add(true);
            ourList.Add(false);
            ourList.Add(true);
           

            string converted;
            string expectation = "truefalsetrue";

            //Act - Constructor
            converted = ourList.ToString().ToLower();


            //Assert - Are Equal
            Assert.AreEqual(expectation, converted);

        }

        [TestMethod]
        public void DoesMethodTakeEachValueOfTheList() 
        {
            //Arrange
            CustomList<int> ourList = new CustomList<int>();
            ourList.Add(6);
            ourList.Add(8);
            ourList.Add(12);
            ourList.Add(32);
            ourList.Add(7);

            //Act
            string expectation = "6812327";
            string converted = ourList.ToString();
            
            //Assert
            Assert.AreEqual(expectation, converted);
        }
        //public void IsTheReturnValueCorrect()
        //{
        //    //Arrange



        //    //Act

        //    Console.WriteLine();
        //    //Assert
        //    Assert.AreEqual(expected, converted);

        
    }
}
