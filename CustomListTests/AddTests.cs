using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace CustomListTests
{
    [TestClass]
    public class AddTests
    {
        [TestMethod]
        public void CustomList_TestWithValueDataType_Add()
        {
            int test = 25;
            CustomList<int> list = new CustomList<int>() { test };
            Assert.AreEqual(test, list[0]);
        }

        [TestMethod]
        public void CustomList_TestWithReferenceDataType_Add()
        {
            Person p = new Person("Nathen", 21, "Attack Helicopter");
            CustomList<Person> list = new CustomList<Person>() { p };
            Person expected = p;
            Assert.AreEqual(expected, list[0]);
        }

        //[TestMethod]
        //public void CustomList_TestForMultipleInput_Add()
        //{
        //    CustomList<string> list = new CustomList<string>();
        //    string input = "";
        //    int count = 0;
        //    while (input != "no")
        //    {
        //        Console.WriteLine("Input some more!!!");
        //        input = Console.ReadLine();
        //        list.Add(input);
        //        count++;
        //    }
        //    Assert.AreEqual(count, list.Count);
        //}
    }
}