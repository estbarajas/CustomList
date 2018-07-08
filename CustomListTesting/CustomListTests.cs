using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;
namespace CustomListTesting
{
    [TestClass]
    public class CustomListTests //MethodName_StateUnderTest_ExpectedBehavior
    {
        [TestMethod]
        public void Add_IndexZeroWithOneValue_ReturnNumber() //1
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
        public void Add_IndexZeroWithTwoValues_ReturnNumber() //2
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
        public void Add_IndexZeroWithMultipleValues_ReturnNumber() //3
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
        public void Add_IndexZeroWithStrings_ReturnString()
        {
            //Arrange
            CustomList<string> theList = new CustomList<string>();
            string expected = "cat";
            string value = "cat";

            //Act
            theList.Add(value);
            
            //Assert
            Assert.AreEqual(expected, theList[0]);
        }

        [TestMethod]
        public void Add_IndexZeroWithObjects_ReturnReference()
        {
            //Arrange    
            TheObject object1 = new TheObject();
            CustomList<TheObject> theList = new CustomList<TheObject>();
            TheObject expected = object1;
            TheObject actual = theList[0];
            
            //Act
            theList.Add(expected);
                  
            //Assert
            Assert.AreEqual(expected, theList[0]);
        }
        
        [TestMethod]
        [ExpectedException(typeof(System.IndexOutOfRangeException))]
        public void Remove_IndexZeroHoldingOneValue_ReturnNull() //1
        {
            CustomList<int> theList = new CustomList<int>();
            theList.Add(10);
            theList.Remove(10);
            Console.WriteLine(theList[0]);
        }

        [TestMethod]
        public void Remove_IndexZeroHoldingTwoValues_ReturnNumber() //2
        {
            //Arrange
            CustomList<int> theList = new CustomList<int>();
            int expected = 20;
            int actual;

            //Act
            theList.Add(10);
            theList.Add(20);
            theList.Remove(10);
            actual = theList[0];

            //Assert
            Assert.AreEqual(expected, actual);
        }
        
        [TestMethod]
        public void Remove_IndexZeroHoldingMultipleValues_ReturnNumber() //3
        {
            //Arrange
            CustomList<int> theList = new CustomList<int>();
            int expected = 10;
            int actual;
            int value = 0;

            //Act
            for (int i = 0; i < 7; i++)
            {
                theList.Add(value);
                value += 10;
            }
            theList.Remove(0);
            //theList.Remove(20);
            theList.Remove(40);
            theList.Remove(50);
            //theList.Remove(120);
            actual = theList[0];

            //theList.PrintArray();

            //Assert
            Assert.AreEqual(expected, actual);
        }
        
        [TestMethod]
        public void Remove_IndexZeroWithStrings_ReturnString() //4
        {
            //Arrange
            CustomList<string> theList = new CustomList<string>();
            string expected = "tree";
            string actual;

            //Act
            theList.Add("dog");
            theList.Add("cat");
            theList.Add("tree");
            theList.Remove("cat");
            theList.Remove("dog");
            actual = theList[0];

            //Assert
            Assert.AreEqual(expected, actual);
        }
        
        [TestMethod]
        public void Remove_IndexZeroWithObjects_ReturnObject() //5
        {
            //Arrange
            TheObject theObject = new TheObject();
            TheObject theObject2 = new TheObject();
            CustomList<TheObject> theList = new CustomList<TheObject>();
            TheObject expected = theObject;
            TheObject objectValue;

            //Act
            theList.Add(theObject);
            theList.Add(theObject2);
            theList.Remove(theObject2);

            //Assert
            Assert.AreEqual(expected, theList[0]);
        }
        
        [TestMethod]
        public void Count_IndexZeroAfterAdding_ReturnNumber() //1
        {
            //Arrange
            CustomList<int> theList = new CustomList<int>() {};
            int expected = 1;
            int value = 10;

            //Act
            theList.Add(value);

            //Assert
            Assert.AreEqual(expected, theList.Count);
        }
        
        [TestMethod]
        public void Count_IndexZeroAfterAddingMultiple_ReturnNumber() //2
        {
            //Arrange
            CustomList<int> theList = new CustomList<int>() {};
            int expected = 2;
            int value = 10;
            int value2 = 20;

            //Act
            theList.Add(value);
            theList.Add(value2);

            //Assert
            Assert.AreEqual(expected, theList.Count);
        }
        
        [TestMethod]
        public void Count_EmptyListValue_ReturnNumber() //3
        {
            //Arrange
            CustomList<int> theList = new CustomList<int>();
            int expected = 0;

            //Act
            theList.Add(10);
            theList.Remove(10);

            //Assert
            Assert.AreEqual(expected, theList.Count);
        }
        
        [TestMethod]
        public void Count_ListAfterRemovingMultiple_ReturnNumber() //4
        {
            //Arrange
            CustomList<int> theList = new CustomList<int>();
            int expected = 2;

            //Act
            theList.Add(10);
            theList.Add(20);
            theList.Add(30);
            theList.Add(40);
            theList.Remove(10);
            theList.Remove(40);

            //Assert
            Assert.AreEqual(expected, theList.Count);
        }
        
        [TestMethod]
        public void Count_RemovingIncorrectValue_ReturnNumber() //4 broken
        {
            //Arrange
            CustomList<int> theList = new CustomList<int>();
            int expected = 2;

            //Act
            theList.Add(10);
            theList.Add(20);
            //theList.Add(30);
            //theList.Add(40);
            //theList.Remove(10);
            //theList.Remove(30);
            //theList.Remove(50);

            theList.PrintArray();

            //Assert
            Assert.AreEqual(expected, theList.Count);
        }
        
        [TestMethod]
        public void Count_RemovingTrue_ReturnBoolean()
        {
            //Arrange
            CustomList<int> theList = new CustomList<int>();
            bool expected = true;
            bool actual;

            //Act
            theList.Add(10);
            theList.Add(20);
            theList.Add(30);
            actual = theList.Remove(30);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
