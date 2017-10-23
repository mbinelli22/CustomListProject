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

        }

        [TestMethod]
        public void addInt()
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
        public void addstring()
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
        public void addBool()
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
        public void addTwoNumbers()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            int firstInt = 5;
            int secondInt = 6;

            //Assert
            customList.add(firstInt);
            customList.Add(secondInt);

            //Act
            Assert.AreEqual(secondInt, customList[1]);

        }

        [TestMethod]
        public void addList()
        {
            //Arrange
            CustomList<int> newCustomList = new CustomList<int>();
            CustomList<CustomList<int>> customList = new CustomList<CustomList<int>>();
                        
            //Act
            customList.Add(newCustomList);

            //Assert
            Assert.AreEqual(newCustomList, customList[0]);

        }


        //remove

        [TestMethod]
        public void removeInt()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            int zeroIndex = customList[0];

            //Act
            customList.Add(zeroIndex);

            //Assert
            Assert.AreEqual(null, customList[0]);

        }

        [TestMethod]
        public void removeString()
        {
            //Arrange
            CustomList<string> customList = new CustomList<string>();
            string zeroIndex = customList[0];

            //Act
            customList.Add(zeroIndex);

            //Assert
            Assert.AreEqual(null, customList[0]);

        }
    }
}
