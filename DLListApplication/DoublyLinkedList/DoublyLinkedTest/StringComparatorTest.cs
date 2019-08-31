using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DoublyLinkedApplication;
namespace DoublyLinkedTest
{
    [TestClass]
    public class StringComparatorTest
    {

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ComparisonOfTwoNullStringsShouldthrowExceptions()
        {
            StringUtility.getDifference(null, null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ComparisonOfoNullAndEmptyStringsShouldthrowExceptions()
        {
            StringUtility.getDifference(null, "");
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ComparisonOfTwoEmptyStringsShouldthrowExceptions()
        {
            StringUtility.getDifference("", "");
        }

        public void comparisonOfSameStringshouldReturnEmptyList()
        {
            String one = "Mango";
            String two = "Mango";
            Assert.IsTrue(StringUtility.getDifference(one, two).IsEmpty());
            one = "Mango Mango";
            Assert.IsTrue(StringUtility.getDifference(one, two).IsEmpty());
        }

        [TestMethod]
        public void comparisonOfDifferentStringshouldReturnDifference()
        {
            String one = "Mango Apple";
            String two = "Mango";
            DoublyLinkedList diff = StringUtility.getDifference(one, two);
            Assert.AreEqual(1, diff.Size());
            Assert.AreEqual("[ Apple ]", diff.ToString());

            two = "Apple";
            diff = StringUtility.getDifference(one, two);
            Assert.AreEqual(1, diff.Size());
            Assert.AreEqual("[ Mango ]", diff.ToString());

            one = "Mango Apple PineApples";
            two = "Apple";
            diff = StringUtility.getDifference(one, two);
            Assert.AreEqual(2, diff.Size());
            Assert.AreEqual("[ Mango PineApples ]", diff.ToString());
        }
    }
}
