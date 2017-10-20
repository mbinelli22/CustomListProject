using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication2;


namespace CustomListTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //CustomList myList = new ConsoleApplication2.CustomList();
        }

        [TestMethod]
        public void addInt()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();

            int firstNumber = 5;
           
            //Assert
            customList.add(firstNumber);

            //Act
            Assert.AreEqual(5, customList[0]);

        }
 
        [TestMethod]
        public void addstring()
        {
            //Arrange
            CustomList<string> customList = new CustomList<string>();
            string firstString = "Yoda";


            //Assert
            customList.add(firstString);

            //Act
            Assert.AreEqual(firstString, customList[0]);

        }

        [TestMethod]
        public void addBool()
        {
            //Arrange
            CustomList<bool> customList = new CustomList<bool>();
            bool firstBool = true;

            //Assert
            customList.add(firstBool);

            //Act
            Assert.AreEqual(firstBool, customList[0]);

        }

        [TestMethod]
        public void addTwoNumbers()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            int firstInt = 5;
            int secondInt = 6;

            //Assert
            customList.add(firstInt);
            customList.add(secondInt);

            //Act
            Assert.AreEqual(secondInt, customList[1]);

        }

        [TestMethod]
        public void addList()
        {
            //Arrange
            public List<newList> secondList;
            CustomList<> customList = new CustomList<newCustomList>();
            


            //Assert
            customList.add(newCustomList);

            //Act
            Assert.AreEqual(newCustomList, customList[0]);

        }
    }
}
