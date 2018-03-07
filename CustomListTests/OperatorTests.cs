using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;
using System.Collections.Generic;

namespace CustomListTests
{
    [TestClass]
    public class OperatorTests
    {
        [TestMethod]
        public void CustomList_TestForAdditionOperatorStrings_Plus()
        {
            CustomList<string> listOne = new CustomList<string>() { "one", "two", "three" };
            CustomList<string> listTwo = new CustomList<string>() { "four", "five", "six" };
            CustomList<string> expected = new CustomList<string>() { "one", "two", "three", "four", "five", "six" };
            CustomList<string> result = new CustomList<string>();
            result = listOne + listTwo;
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CustomList_TestForAdditionOperatorNumbers_Plus()
        {
            CustomList<int> listOne = new CustomList<int>() { 1, 2, 3 };
            CustomList<int> listTwo = new CustomList<int>() { 4, 5, 6 };
            CustomList<int> expected = new CustomList<int>() { 1, 2, 3, 4, 5, 6 };
            CustomList<int> result = new CustomList<int>();
            result = listOne + listTwo;
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CustomList_TestForAdditionOperatorObjects_Plus()
        {
            CustomList<Person> listOne = new CustomList<Person>()
            {
                new Person("Nathen", 12, "Guy"),
                new Person("Jason", 12, "Guy")
            };
            CustomList<Person> listTwo = new CustomList<Person>()
            {
                new Person("Jimmi", 12, "Guy"),
                new Person("Jimmy", 12, "Guy")
            };
            CustomList<Person> expected = new CustomList<Person>()
            {
                new Person("Nathen", 12, "Guy"),
                new Person("Jason", 12, "Guy"),
                new Person("Jimmi", 12, "Guy"),
                new Person("Jimmy", 12, "Guy")
            };
            CustomList<Person> result = new CustomList<Person>();
            result = listOne + listTwo;
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CustomList_TestForAdditionOperatorStrings_minus()
        {
            CustomList<string> listOne = new CustomList<string>() { "one", "two", "three", "four", "five", "six" };
            CustomList<string> listTwo = new CustomList<string>() { "four", "five", "six" };
            CustomList<string> expected = new CustomList<string>() { "one", "two", "three" };
            CustomList<string> result = new CustomList<string>();
            result = listOne - listTwo;
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CustomList_TestForAdditionOperatorNumbers_minus()
        {
            CustomList<int> listOne = new CustomList<int>() { 1, 2, 3, 4, 5, 6 };
            CustomList<int> listTwo = new CustomList<int>() { 4, 5, 6 };
            CustomList<int> expected = new CustomList<int>() { 1, 2, 3 };
            CustomList<int> result = new CustomList<int>();
            result = listOne - listTwo;
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CustomList_TestForAdditionOperatorObjects_minus()
        {
            CustomList<Person> listOne = new CustomList<Person>()
            {
                new Person("Nathen", 12, "Guy"),
                new Person("Jason", 12, "Guy"),
                new Person("Jimmi", 12, "Guy"),
                new Person("Jimmy", 12, "Guy")
            };
            CustomList<Person> listTwo = new CustomList<Person>()
            {
                new Person("Jimmi", 12, "Guy"),
                new Person("Jimmy", 12, "Guy")
            };
            CustomList<Person> expected = new CustomList<Person>()
            {
                new Person("Nathen", 12, "Guy"),
                new Person("Jason", 12, "Guy")
            };
            CustomList<Person> result = new CustomList<Person>();
            result = listOne - listTwo;
            Assert.AreEqual(expected, result);
        }
    }
}
