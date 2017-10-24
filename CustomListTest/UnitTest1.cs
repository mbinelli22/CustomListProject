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
            // .Add

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


        //REMOVE

        //[TestMethod]
        //public void Remove_RemoveSpecifiedIntFromArray()
        //{
        //    //Arrange
        //    CustomList<int> customList = new CustomList<int>();
        //    int removeZeroIndex = customList[0];

        //    //Act
        //    customList.Remove(removeZeroIndex);

        //    //Assert
        //    Assert.AreEqual(null, customList[0]);

        //}

        //[TestMethod]
        //public void Remove_RemoveSpecifiedStringFromArray()
        //{
        //    //Arrange
        //    CustomList<string> customList = new CustomList<string>();
        //    string zeroIndex = customList[0];

        //    //Act
        //    customList.Remove(zeroIndex);

        //    //Assert
        //    Assert.AreEqual(null, customList[0]);

        //}

        //public void Remove_RemoveSpecifiedBoolFromArray()
        //{
        //    //Arrange
        //    CustomList<bool> customList = new CustomList<bool>();
        //    bool zeroIndex = customList[0];

        //    //Act
        //    customList.Remove(zeroIndex);

        //    //Assert
        //    Assert.AreEqual(null, customList[0]);

        //}

        //public void Remove_RemoveTwoIntsFromArray()
        //{
        //    //Arrange
        //    CustomList<int> customList = new CustomList<int>();
        //    int firstInt = customList[0];
        //    int secondInt = customList[1];

        //    //Act
        //    customList.Remove(firstInt);
        //    customList.Remove(secondInt);

        //    //Assert
        //    Assert.AreEqual(null, customList[1]);
        //}

        //public void Remove_RemoveListFromArray()
        //{
        //    //Arrange
        //    CustomList<int> newCustomList = new CustomList<int>();
        //    CustomList<CustomList<int>> customList = new CustomList<CustomList<int>>();

        //    //Act
        //    customList.Remove(newCustomList);

        //    //Assert
        //    Assert.AreEqual(null, customList[0]);

        //}
    }
}
