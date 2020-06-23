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

        public void DoesIntValueConvertToString()
        {
            //Arrange - member variable
            CustomList<int> ourList = new CustomList<int>();
            ourList.Add(6);
            ourList.Add(8);
            ourList.Add(12);
            ourList.Add(32);
            ourList.Add(7);
            //Act - Constructor
            string expectation = "12";
            string converted = ourList.ToString(ourList[2]);

            //Assert - Are Equal
            Assert.AreEqual(expectation, converted);

        }
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
            string converted = "";
            for (int i = 0; i < ourList.count; i++)
            {
                converted += ourList[i];
            }

            //Assert
            Assert.AreEqual(expectation, converted);
        }
        public void IsTheReturnValueCorrect()
        {
            //Arrange
            CustomList<int> ourList = new CustomList<int>();
            ourList.Add(6);
            ourList.Add(8);
            ourList.Add(12);
            ourList.Add(32);
            ourList.Add(7);

            //Act
            string expected = "32";
            int converted = ourList[3];

            //Assert
            Assert.AreEqual(expected, converted);

        }
    }
}
