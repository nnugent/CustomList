using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;
using System.Collections.Generic;


namespace CustomListTests
{
    [TestClass]
    public class ZipperTests
    {
        [TestMethod]
        public void CustomList_ZipperTestWithInt_zipper()
        {
            CustomList<int> listOne = new CustomList<int>();
            CustomList<int> listTwo = new CustomList<int>();
            CustomList<int> expected = new CustomList<int>();
            CustomList<int> result;
            for (int index = 0; index < 20; index += 2)
            {
                listOne.Add(index);
            }
            for (int index = 1; index < 20; index += 2)
            {
                listTwo.Add(index);
            }
            result = listOne.Zipper(listTwo);
            for(int index = 0; index < 20; index++)
            {
                expected.Add(index);
            }
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CustomList_ZipperTestWithString_zipper()
        {
            CustomList<string> listOne = new CustomList<string>() { "one", "three", "five" };
            CustomList<string> listTwo = new CustomList<string>() { "two", "four", "six" };
            CustomList<string> expected = new CustomList<string>() { "one", "two", "three", "four", "five", "six" };
            CustomList<string> result;
            result = listOne.Zipper(listTwo);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CustomList_ZipperTestWithObject_zipper()
        {
            CustomList<Person> listOne = new CustomList<Person>()
            {
                new Person("Nathen", 21, "Guy"),
                new Person("Donkey", 21, "Guy")
            };
            CustomList<Person> listTwo = new CustomList<Person>()
            {
                new Person("Jimmy", 21, "Raptor"),
                new Person("Jimmi", 34, "TRexDog")
            };
            CustomList<Person> expected = new CustomList<Person>()
            {
                new Person("Nathen", 21, "Guy"),
                new Person("Jimmy", 21, "Raptor"),
                new Person("Donkey", 21, "Guy"),
                new Person("Jimmi", 34, "TRexDog")
            };
            CustomList<Person> result;
            result = listOne.Zipper(listTwo);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CustomList_ZipperTestWithActingListLonger_zipper()
        {
            CustomList<int> listOne = new CustomList<int>();
            CustomList<int> listTwo = new CustomList<int>();
            CustomList<int> expected = new CustomList<int>();
            CustomList<int> result;
            for (int index = 0; index < 30; index += 2)
            {
                listOne.Add(index);
            }
            for (int index = 1; index < 20; index += 2)
            {
                listTwo.Add(index);
            }
            result = listOne.Zipper(listTwo);
            for (int index = 0; index < 20; index++)
            {
                expected.Add(index);
            }
            for(int index = 20; index < 30; index += 2)
            {
                expected.Add(index);
            }
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CustomList_ZipperTestWithGivenListLonger_zipper()
        {
            CustomList<int> listOne = new CustomList<int>();
            CustomList<int> listTwo = new CustomList<int>();
            CustomList<int> expected = new CustomList<int>();
            CustomList<int> result;
            for (int index = 0; index < 20; index += 2)
            {
                listOne.Add(index);
            }
            for (int index = 1; index < 30; index += 2)
            {
                listTwo.Add(index);
            }
            result = listOne.Zipper(listTwo);
            for (int index = 0; index < 20; index++)
            {
                expected.Add(index);
            }
            for (int index = 21; index < 30; index += 2)
            {
                expected.Add(index);
            }
            Assert.AreEqual(expected, result);
        }
    }
}
