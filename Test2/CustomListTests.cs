using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace Test2
{
    [TestClass]
    public class CustomListTests
    {
        [TestMethod]
        public void Add_AddFourIntegers_IntegerInIndex()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            int test = 4;

            //Act
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            
            //Assert
            Assert.AreEqual(test, list[2]);

        }

        [TestMethod]
        public void Add_AddStrings_IntegerInIndex()
        {
            // Arrange
            CustomList<string> list = new CustomList<string>();
            string expected = "Green";

            // Act
            list.Add("Green");
            list.Add("Bay");
            list.Add("Packers");
            string actual = list[0];

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_3_Items_Count_Increment()
        {
            //Arrange
            CustomList<int> test = new CustomList<int>();

            //Act
            test.Add(4);
            test.Add(5);
            test.Add(7);

            //Asserts
            Assert.IsTrue(test.Count == 3);
        }

        [TestMethod]
        public void ArrayToString_PositiveIntegers_StringsFromInteger()
        {
            //Arrange
            CustomList<int> testlist = new CustomList<int>() { 1, 2, 3, 4 };
            string listString;
            string stringResult = "1234";

            //Act
            listString = testlist.ToString();

            //Assert
            Assert.AreEqual(stringResult, listString);
        }
    }
}
