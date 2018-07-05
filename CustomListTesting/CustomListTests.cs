using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CustomListTesting
{
    [TestClass]
    public class CustomListTests //MethodName_StateUnderTest_ExpectedBehavior
    {
        [TestMethod]
        public void Add_IndexZeroWithOneValue_ReturnNumber()
        {
            //Arrange
            CustomList<int> theList = new CustomList<int>();
            int expected = 100;

            //Act
            theList.Add(expected);

            //Assert
            Assert.AreEqual(expected, theList[0]);
        }

        [TestMethod]
        public void Add_IndexZeroWithTwoValues_ReturnNumber()
        {
            //Arrange
            CustomList<int> theList = new CustomList<int>();
            int expected = 100;
            int value = 200;

            //Act
            theList.Add(expected);
            theList.Add(value);

            //Assert
            Assert.AreEqual(expected, theList[0]);
        }

        [TestMethod]
        public void Add_IndexZeroWithMultipleValues_ReturnNumber()
        {
            //Arrange
            CustomList<int> theList = new CustomList<int>();
            int expected = 100;
            int value = 200;

            //Act
            theList.Add(expected);

            for (int i = 0; i < 15; i++)
            {
                theList.Add(value);
                value += 100;
            }

            //Assert
            Assert.AreEqual(expected, theList[0]);
        }

        [TestMethod]
        public void Add_PreExistingIndexZero_ReturnNumber()
        {
            //Arrange
            CustomList<int> theList = new CustomList<int>(){10};
            int expected = 20;
            int value = 20;

            //Act
            theList[0].Add(value);

            //Assert
            Assert.AreEqual(expected, theList[0]);
        }

        public void Remove_IndexZeroHoldingOneValue_ReturnNull()
        {
            //Arrange
            CustomList<int> theList = new CustomList<int>(){10};
            string expected = null;
            string actual;

            //Act
            theList.Remove.ElementAt(0);
            actual = theList[0];

            //Assert
            Assert.AreEqual(expected, actual);
        }

        public void Remove_IndexZeroHoldingTwoValues_ReturnNull()
        {
            //Arrange
            CustomList<int> theList = new CustomList<int>() {10,20};
            int expected = 20;
            int actual;

            //Act
            theList.Remove.ElementAt(0);
            actual = theList[0];

            //Assert
            Assert.AreEqual(expected, actual);
        }

        public void Remove_IndexZeroHoldingMultipleValues_ReturnNumber()
        {
            //Arrange
            CustomList<int> theList = new CustomList<int>() {10,20,30,40,50,60,70,80,90,100,110,120};
            int expected = 20;
            int actual;

            //Act
            theList.Remove.ElementAt(0);
            theList.Remove.ElementAt(5);
            theList.Remove.ElementAt(6);
            theList.Remove.ElementAt(2);
            actual = theList[0];

            //Assert
            Assert.AreEqual(expected, actual);
        }

    }
}
