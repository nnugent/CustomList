using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;
using System.Collections.Generic;

namespace CustomListTests
{
    [TestClass]
    public class ForEachTests
    {
        [TestMethod]
        public void CustomList_TestForIteration_ForEach()
        {
            string result = "";
            string expected = "0123456789";
            CustomList<int> myArray = new CustomList<int>();
            for(int index = 0; index < 10; index++)
            {
                myArray.Add(index);
            }
            foreach(int item in myArray)
            {
                result += item;
            }
            Assert.AreEqual(expected, result);
        }
    }
}
