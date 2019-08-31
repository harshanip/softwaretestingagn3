using System;
using DLLLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DoublyLinkedTest
{
    [TestClass]
    public class DoublyLinkedListDeleteTest
    {

        [TestMethod]
        public void DeleteFromEmptyListShouldReturnFalse()
        {
            DoublyLinkedListImpl emptyList = new DoublyLinkedListImpl();
            Assert.IsFalse(emptyList.Delete("Mango"));
            Assert.IsTrue(emptyList.IsEmpty());
        }

        [TestMethod]
        public void DeleteNodefromOneNodeListShouldReturnTrue()
        {
            DoublyLinkedListImpl list = new DoublyLinkedListImpl();
            list.Insert("Mango");
            Assert.IsTrue(list.Delete("Mango"));
        }

        [TestMethod]
        public void DeleteFirstNodefromTwoNodeListShouldReturnTrue()
        {
            DoublyLinkedListImpl list = new DoublyLinkedListImpl();
            list.Insert("Mango");
            list.Insert("Grapes");
            Assert.IsTrue(list.Delete("Mango"));
        }

        [TestMethod]
        public void DeleteLastNodefromTwoNodeListShouldReturnTrue()
        {
            DoublyLinkedListImpl list = new DoublyLinkedListImpl();
            list.Insert("Mango");
            list.Insert("Grapes");
            Assert.IsTrue(list.Delete("Grapes"));
        }

        [TestMethod]
        public void DeleteDuplicatesItems()
        {
            DoublyLinkedListImpl fruitList = new DoublyLinkedListImpl();
            fruitList.Insert("Grapes");
            fruitList.Insert("Mango");
            fruitList.Insert("Mango");
            fruitList.Insert("Apple");
            fruitList.Insert("Kiwi");
            Assert.IsTrue(fruitList.Delete("Mango"));
            Assert.AreEqual(4, fruitList.Size());
            Assert.IsTrue(fruitList.Delete("Mango"));
            Assert.AreEqual(3, fruitList.Size());

        }

        [TestMethod]
        public void DeleteFromMiddleListShouldNotBreakOrder()
        {
            DoublyLinkedListImpl list = new DoublyLinkedListImpl();
            list.Insert("PineApple");
            list.Insert("Apple");
            list.Insert("Mango");
            Assert.IsTrue(list.Delete("Apple"));
            Assert.AreEqual("[ Mango PineApple ]", list.ToString());
        }

        [TestMethod]
        public void DeleteItemsfromHead()
        {
            DoublyLinkedListImpl fruitList = new DoublyLinkedListImpl();
            fruitList.Insert("Grapes");
            fruitList.Insert("Mango");
            fruitList.Insert("Mango");
            fruitList.Insert("Apple");
            fruitList.Insert("Kiwi");

            Assert.IsTrue(fruitList.Delete("Kiwi"));
            Assert.IsFalse(fruitList.IsContains("Kiwi"));
            Assert.IsTrue(fruitList.IsContains("Apple"));
            Assert.IsTrue(fruitList.IsContains("Grapes"));
            Assert.IsTrue(fruitList.IsContains("Mango"));
            Assert.AreEqual(4, fruitList.Size());

            Assert.IsTrue(fruitList.Delete("Apple"));
            Assert.IsFalse(fruitList.IsContains("Apple"));
            Assert.IsTrue(fruitList.IsContains("Grapes"));
            Assert.IsTrue(fruitList.IsContains("Mango"));
            Assert.AreEqual(3, fruitList.Size());

            Assert.IsTrue(fruitList.Delete("Mango"));
            Assert.IsTrue(fruitList.IsContains("Mango"));
            Assert.IsTrue(fruitList.IsContains("Grapes"));
            Assert.AreEqual(2, fruitList.Size());

            Assert.IsTrue(fruitList.Delete("Mango"));
            Assert.IsFalse(fruitList.IsContains("Mango"));
            Assert.IsTrue(fruitList.IsContains("Grapes"));
            Assert.AreEqual(1, fruitList.Size());

            Assert.IsTrue(fruitList.Delete("Grapes"));
            Assert.IsTrue(fruitList.IsEmpty());
        }
        //----------------------End of Testing Delete Method
    }
    [TestClass]
    public class DoublyLinkedListSearchTest
    {

        public void SearchEmptyListShouldReturnFalse()
        {
            DoublyLinkedListImpl emptyList = new DoublyLinkedListImpl();
            Assert.IsFalse(emptyList.IsContains("Mango"));
        }

        [TestMethod]
        public void SearchOneNodeListShouldReturnTrue()
        {
            DoublyLinkedListImpl list = new DoublyLinkedListImpl();
            list.Insert("Mango");
            Assert.IsTrue(list.IsContains("Mango"));
        }

        [TestMethod]
        public void SearchNonExistingWordInOneNodeListShouldReturnFalse()
        {
            DoublyLinkedListImpl list = new DoublyLinkedListImpl();
            list.Insert("Mango");
            Assert.IsFalse(list.IsContains("Grapes"));
        }

        [TestMethod]
        public void SearchFirstWordInTwoNodeListShouldReturnTrue()
        {
            DoublyLinkedListImpl list = new DoublyLinkedListImpl();
            list.Insert("Mango");
            list.Insert("Grapes");
            Assert.IsTrue(list.IsContains("Mango"));
        }

        [TestMethod]
        public void SearchSecondWordInTwoNodeListShouldReturnTrue()
        {
            DoublyLinkedListImpl list = new DoublyLinkedListImpl();
            list.Insert("Mango");
            list.Insert("Grapes");
            Assert.IsTrue(list.IsContains("Grapes"));
        }

        [TestMethod]
        public void SearchNonExistingWordInTwoNodeListShouldReturnTrue()
        {
            DoublyLinkedListImpl list = new DoublyLinkedListImpl();
            list.Insert("Mango");
            list.Insert("Grapes");
            Assert.IsFalse(list.IsContains("Apple"));
        }

        [TestMethod]
        public void SearchInListwithMultipleItems()
        {
            DoublyLinkedListImpl list = new DoublyLinkedListImpl();
            list.Insert("Grapes");
            list.Insert("Mango");
            list.Insert("Mango");
            list.Insert("Apple");
            list.Insert("Kiwi");
            Assert.IsTrue(list.IsContains("Grapes"));
            Assert.IsTrue(list.IsContains("Mango"));
            Assert.IsTrue(list.IsContains("Apple"));
            Assert.IsTrue(list.IsContains("Kiwi"));
            Assert.IsFalse(list.IsContains("kiwi"));
        }
    }
    [TestClass]
    public class DoublyLinkedListToStringTest
    {
        [TestMethod]
        public void TestToString()
        {
            DoublyLinkedListImpl emptyList = new DoublyLinkedListImpl();
            DoublyLinkedListImpl fruitList = new DoublyLinkedListImpl();
            fruitList.Insert("Grapes");
            fruitList.Insert("Mango");
            fruitList.Insert("Mango");
            fruitList.Insert("Apple");
            fruitList.Insert("Kiwi");
            Assert.AreEqual("[ ]", emptyList.ToString());
            Assert.AreEqual("[ Kiwi Apple Mango Mango Grapes ]", fruitList.ToString());
        }

    }
    [TestClass]
    public class DoublyLinkedListInsertTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddNullToHeadShouldThrowException()
        {

            DoublyLinkedListImpl emptyList = new DoublyLinkedListImpl();
            emptyList.Insert(null);
        }

        [TestMethod]
        public void InsertShouldReturnCorrectvalue()
        {
            DoublyLinkedListImpl list = new DoublyLinkedListImpl();
            list.Insert("Mango");
            Assert.IsTrue(list.IsContains("Mango"));
            Assert.AreEqual(1, list.Size());
            Assert.IsFalse(list.IsEmpty());

            list.Insert("Apple");
            Assert.IsTrue(list.IsContains("Mango"));
            Assert.IsTrue(list.IsContains("Apple"));
            Assert.AreEqual(2, list.Size());
            Assert.IsFalse(list.IsEmpty());
        }

    }

    [TestClass]
    public class DoublyLinkedListDisplayTest
    {


        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ConvertListToMultipleLineStringWithLessThanOneShouldThrowAnException()
        {
            new DoublyLinkedListImpl().display(0);
        }

        [TestMethod]
        public void TestConvertListToMultipleLineString()
        {
            DoublyLinkedListImpl fruitList = new DoublyLinkedListImpl();
            fruitList.Insert("Grapes");
            fruitList.Insert("Mango");
            fruitList.Insert("Mango");
            fruitList.Insert("Apple");
            fruitList.Insert("Kiwi");
            fruitList.Insert("Mango");
            fruitList.Insert("Apple");
            fruitList.Insert("Kiwi");
            Assert.AreEqual("Kiwi Apple Mango Kiwi Apple Mango Mango Grapes", fruitList.display(10));
            Assert.AreEqual("Kiwi Apple Mango Kiwi Apple Mango Mango Grapes", fruitList.display(9));
            Assert.AreEqual("Kiwi Apple Mango Kiwi Apple Mango Mango Grapes" + Environment.NewLine
                , fruitList.display(8));
            Assert.AreEqual("Kiwi Apple Mango Kiwi Apple Mango Mango" + Environment.NewLine + "Grapes"
                , fruitList.display(7));
            Assert.AreEqual("Kiwi Apple Mango Kiwi Apple Mango" + Environment.NewLine + "Mango Grapes"
                , fruitList.display(6));
            Assert.AreEqual("Kiwi Apple Mango Kiwi Apple" + Environment.NewLine + "Mango Mango Grapes"
                , fruitList.display(5));
            Assert.AreEqual("Kiwi Apple Mango Kiwi" + Environment.NewLine + "Apple Mango Mango Grapes" + Environment.NewLine
                , fruitList.display(4));
            Assert.AreEqual("Kiwi Apple Mango" + Environment.NewLine + "Kiwi Apple Mango" + Environment.NewLine + "Mango Grapes"
                , fruitList.display(3));
            Assert.AreEqual("Kiwi Apple" + Environment.NewLine + "Mango Kiwi"
                + Environment.NewLine + "Apple Mango" + Environment.NewLine + "Mango Grapes" + Environment.NewLine, fruitList.display(2));
            Assert.AreEqual("Kiwi" + Environment.NewLine + "Apple" + Environment.NewLine + "Mango" + Environment.NewLine + "Kiwi" + Environment.NewLine + "Apple" + Environment.NewLine + "Mango" + Environment.NewLine + "Mango" + Environment.NewLine + "Grapes" + Environment.NewLine, fruitList.display(1));
            Assert.AreEqual("", new DoublyLinkedListImpl().display(1));
        }
    }
}
