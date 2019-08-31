using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DLLLibrary;
namespace DoublyLinkedTest
{
    [TestClass]
    public class ListUtilityTest
    {

        [TestMethod]
        public void AddOneWordstoEmptyList()
        {
            String one  = "Mango";
            DoublyLinkedListImpl diff = new DoublyLinkedListImpl();
            ListUtility.AddnewWordstoDoublylinkedList(diff, one);
            Assert.AreEqual("[ Mango ]", diff.ToString());

        }
        
        [TestMethod]
        public void AddDuplicatedWordstoListShouldNotIncludeduplicates()
        {
            String one = "Mango Apple Mango Kiwi Grapes Oranges";
            DoublyLinkedListImpl diff = new DoublyLinkedListImpl();
            ListUtility.AddnewWordstoDoublylinkedList(diff, one);
            Assert.AreEqual("[ Oranges Grapes Kiwi Apple Mango ]", diff.ToString());

        }

        [TestMethod]
        public void AddTwoWordstoEmptyList()
        {
            String two = "Mango Apple"; 
            DoublyLinkedListImpl diff = new DoublyLinkedListImpl();
            ListUtility.AddnewWordstoDoublylinkedList(diff, two);
            Assert.AreEqual("[ Apple Mango ]", diff.ToString());
 
        }
    }
}
