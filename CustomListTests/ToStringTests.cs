using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;
using System.Collections.Generic;


namespace CustomListTests
{
    [TestClass]
    public class ToStringTests
    {
        [TestMethod]
        public void CustomList_TestForObjects_ToString()
        {
            CustomList<Person> people = new CustomList<Person>
            {
                new Person("Nathen", 12, "Guy"),
                new Person("Jason", 12, "Guy"),
                new Person("Jimmi", 12, "Guy"),
                new Person("Jimmy", 12, "Guy")
            };
            string expected = "";
            for (int index = 0; index < people.Count; index++)
            {
                if (index > 0)
                {
                    expected += ", " + people[index].ToString();
                }
                else
                {
                    expected += people[index].ToString();
                }
            }
            string result = people.ToString();
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CustomList_TestForNumber_ToString()
        {
            CustomList<int> numbers = new CustomList<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            string expected = "";
            for (int index = 0; index < numbers.Count; index++)
            {
                if (index > 0)
                {
                    expected += ", " + numbers[index];
                }
                else
                {
                    expected += numbers[index];
                }
            }
            string result = numbers.ToString();
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CustomList_TestForStrings_ToString()
        {
            CustomList<string> numbers = new CustomList<string>() {"monkey","donkay","other","otherThings"};
            string expected = "";
            for (int index = 0; index < numbers.Count; index++)
            {
                if (index > 0)
                {
                    expected += ", " + numbers[index];
                }
                else
                {
                    expected += numbers[index];
                }
            }
            string result = numbers.ToString();
            Assert.AreEqual(expected, result);
        }
    }
}
