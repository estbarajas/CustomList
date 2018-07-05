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

        public void Add_IndexZeroWithStrings_ReturnString()
        {
            //Arrange
            CustomList<string> theList = new CustomList<string>() {};
            string expected = "cat";
            string value = "cat";

            //Act
            theList.Add(value);

            //Assert
            Assert.AreEqual(expected, theList[0]);
        }

        public void Add_IndexZeroWithObjects_ReturnString()
        {
            //Arrange
            TheObject theObject = new TheObject();
            CustomList<TheObject> theList = new CustomList<TheObject>() {};
            TheObject expected = theObject;
            TheObject objectValue = theObject;

            //Act
            theList.Add(objectValue);

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
            theList[0].Remove();
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
            theList.Remove();
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
            theList[0].Remove();
            theList[5].Remove();
            theList[6].Remove();
            theList[2].Remove();
            actual = theList[0];

            //Assert
            Assert.AreEqual(expected, actual);
        }

        public void Remove_IndexZeroWithStrings_ReturnNumber()
        {
            //Arrange
            CustomList<string> theList = new CustomList<string>() {"cat","dog","tree"};
            int expected = "dog";
            int actual;

            //Act
            theList[0].Remove();
            actual = theList[0];

            //Assert
            Assert.AreEqual(expected, actual);
        }

        public void Remove_IndexZeroWithObjects_ReturnString()
        {
            //Arrange
            TheObject theObject = new TheObject();
            TheObject theObject2 = new TheObject();
            CustomList<TheObject> theList = new CustomList<TheObject>() {theObject, theObject2};
            TheObject expected = theObject2;
            TheObject objectValue;

            //Act
            theList.Remove();

            //Assert
            Assert.AreEqual(expected, theList[0]);
        }

    }
}
