using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication2;


namespace CustomListTest
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void Add_AddSpecifiedIntToArray()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();

            int firstNumber = 5;

            //Assert
            customList.Add(firstNumber);

            //Act
            Assert.AreEqual(5, customList[0]);

        }

        [TestMethod]
        public void Add_AddSpecifiedStringToArray()
        {
            //Arrange
            CustomList<string> customList = new CustomList<string>();
            string firstString = "Yoda";


            //Assert
            customList.Add(firstString);

            //Act
            Assert.AreEqual(firstString, customList[0]);

        }

        [TestMethod]
        public void Add_AddSpecifiedBoolToArray()
        {
            //Arrange
            CustomList<bool> customList = new CustomList<bool>();
            bool firstBool = true;

            //Assert
            customList.Add(firstBool);

            //Act
            Assert.AreEqual(firstBool, customList[0]);

        }

        [TestMethod]
        public void Add_AddTwoNumbersToArray()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            int firstInt = 5;
            int secondInt = 6;

            //Assert
            customList.Add(firstInt);
            customList.Add(secondInt);

            //Act
            Assert.AreEqual(secondInt, customList[1]);

        }

        [TestMethod]
        public void Add_AddANewListToArray()
        {
            //Arrange
            CustomList<int> newCustomList = new CustomList<int>();
            CustomList<CustomList<int>> customList = new CustomList<CustomList<int>>();

            //Act
            customList.Add(newCustomList);

            //Assert
            Assert.AreEqual(newCustomList, customList[0]);

        }


        //REMOVE<><><><><><><><><><><><><><><><><><><><><><><><><><>

        [TestMethod]
        public void Remove_RemoveSpecifiedIntFromArray()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            int expectedValue = 0;


            //Act
            customList.Add(5);
            customList.Remove(5);
            int actualValue = customList.Count;

            //Assert
            Assert.AreEqual(actualValue, expectedValue);
        }

        [TestMethod]
        public void Remove_RemoveSpecifiedStringFromArray()
        {
            //Arrange
            CustomList<string> customList = new CustomList<string>();
            int expectedValue = 0;

            //Act
            customList.Add("Yoda");
            customList.Remove("Yoda");
            int actualValue = customList.Count;

            //Assert
            Assert.AreEqual(actualValue, expectedValue);

        }

        [TestMethod]
        public void Remove_RemoveSpecifiedBoolFromArray()
        {
            //Arrange
            CustomList<bool> customList = new CustomList<bool>();
            int expectedValue = 0;

            //Act
            customList.Add(true);
            customList.Remove(true);
            int actualValue = customList.Count;

            //Assert
            Assert.AreEqual(actualValue, expectedValue);

        }

        [TestMethod]
        public void Remove_RemoveTwoIntsFromArray()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            int expectedValue = 1;


            //Act
            customList.Add(8);
            customList.Add(2);
            customList.Remove(2);
            int actualValue = customList.Count;

            //Assert
            Assert.AreEqual(actualValue, expectedValue);
        }

        [TestMethod]
        public void Remove_RemoveListFromArray()
        {
            //Arrange
            CustomList<int> newCustomList = new CustomList<int>();
            CustomList<CustomList<int>> customList = new CustomList<CustomList<int>>();
            int expectedValue = 0;

            //Act
            customList.Add(newCustomList);
            customList.Remove(newCustomList);
            int actualValue = customList.Count;

            //Assert
            Assert.AreEqual(actualValue, expectedValue);

        }

        [TestMethod]
        public void Remove_CheckForIndex1ShiftingToIndex0()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            int expectedValue = 2;

            //Act
            customList.Add(8);
            customList.Add(2);
            customList.Remove(8);
            int actualValue = customList[0];

            //Assert
            Assert.AreEqual(expectedValue, actualValue);

        }

        //ToString<><><><><><><><><><><><><><><><><><><><><><><><><><><>

        [TestMethod]
        public void ToString_ConvertIntToString()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            int firstValue = 5;


            //Act
            customList.Add(firstValue);
            customList.ToString();
            string expectedValue = "5";

            //Assert
            Assert.AreEqual(expectedValue, customList[0]);

        }

        [TestMethod]
        public void ToString_ConvertBoolToString()
        {
            //Arrange
            CustomList<bool> customList = new CustomList<bool>();
            bool firstBool = true;

            //Act
            customList.Add(firstBool);
            customList.ToString();
            string expectedValue = "true";

            //Assert
            Assert.AreEqual(expectedValue, customList[0]);

        }

        public void ToString_ConvertTwoIntsToStrings()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            int firstValue = 5;
            int secondValue = 7;

            //Act
            customList.Add(secondValue);
            customList.ToString();
            string expectedValue = "57";

            //Assert
            Assert.AreEqual(expectedValue, customList[1]);
            
        }
         
        
        //ZIPPER<><><><><><><><><><><><><><><><><><><><><><><><><>

        [TestMethod]
        public void Zipper_ZipTwoListsTogether_Int()
        {
            //Arrange
            CustomList<int> odd = new CustomList<int>() { 1, 3, 5 };
            CustomList<int> even = new CustomList<int>() { 2, 4, 6 };

            //Act

            //Assert

        }

    }
}
