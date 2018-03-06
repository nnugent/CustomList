using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;


namespace CustomListTests
{
    [TestClass]
    public class RemoveTest
    {
        [TestMethod]
        public void CustomList_TestForRemovingValue_Remove()
        {
            CustomList<string> list = new CustomList<string>{"Monkay", "Donkay", "Things", "Another One"};
            bool result = list.Remove("Things");
            bool expected = true;
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CustomList_TestForRemoveValueAfterAnIndex_Remove()
        {
            CustomList<string> list = new CustomList<string>() { "Things", "Donkay", "Things", "Anotha One"};
            bool result = list.Remove("Things", 2);
            bool expected = true;
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CustomList_TestForRemoveIndex_Remove()
        {
            CustomList<int> list = new CustomList<int>();
            for (int i = 0; i < 15; i++)
            {
                list.Add(i + 10);
            }
            bool result = list.Remove(list[10]);
            bool expected = true;
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CustomList_TestForRemoveNoCase_Remove()
        {
            CustomList<int> list = new CustomList<int>();
            for (int i = 0; i < 15; i++)
            {
                list.Add(i + 10);
            }
            bool result = list.Remove(39);
            bool expected = false;
            Assert.AreEqual(expected, result);
        }
    }
}
