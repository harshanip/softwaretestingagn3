using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using DLLLibrary;

namespace DoublyLinkedTest
{
    /// <summary>
    /// Summary description for FileUtilityTest
    /// </summary>
    [TestClass]
    public class FileUtilityTest
    {
        
        [TestMethod]
        public void ComparingEmptyFoldersShouldreturnEmptyList()
        {
            DirectoryInfo folder1 = CreateTemporaryDirectory();
            DirectoryInfo folder2 = CreateTemporaryDirectory();
            FileUtility util = new FileUtility();
            util.AddFolderContentToList(folder1.FullName);
            util.RemoveFolderContentFromList(folder2.FullName);
            Assert.IsTrue(util.GetList().IsEmpty());
        }



        [TestMethod]
        public void ComparingFolderWithOneFileToEmptyFolder()
        {
            string[] lines = { "First line", "Second line", "Third line" };
            DirectoryInfo folder1 = CreateTemporaryDirectory();
            DirectoryInfo folder2 = CreateTemporaryDirectory();
            FileUtility util = new FileUtility();
            createFileContaingLines(folder1, lines);
            util.AddFolderContentToList(folder1.FullName);
            util.RemoveFolderContentFromList(folder2.FullName);
            Assert.AreEqual("[ Third Second line First ]", util.GetList().ToString());

            Directory.Delete(folder1.FullName, true);
            Directory.Delete(folder2.FullName, true);
        }




        [TestMethod]
        public void ComparingFoldersWithSameContentShouldReturnEmptyList()
        {
            string[] lines = { "First line", "Second line", "Third line" };
            DirectoryInfo folder1 = CreateTemporaryDirectory();
            DirectoryInfo folder2 = CreateTemporaryDirectory();
            FileUtility util = new FileUtility();
            createFileContaingLines(folder1, lines);
            createFileContaingLines(folder2, lines);
            util.AddFolderContentToList(folder1.FullName);
            util.RemoveFolderContentFromList(folder2.FullName);
            Assert.IsTrue(util.GetList().IsEmpty());

            Directory.Delete(folder1.FullName, true);
            Directory.Delete(folder2.FullName, true);
        }


        [TestMethod]
        public void ComparingFoldersWithMultipleAndFiles()
        {
            DirectoryInfo folder1 = CreateTemporaryDirectory();
            DirectoryInfo folder2 = CreateTemporaryDirectory();
            string[] file1 = { "Imagine there's no heaven", "It's easy if you try", "No hell below us" };
            string[] file2 = { "Above us only sky", "Imagine all the people living for today" };
            string[] file3 = { "Imagine there's no countries", "It isn't hard to do" };
            string[] file4 = { "Nothing to kill or die for","And no religion too" };
            string[] file5 = { "Imagine all the people living life in peace" };
            string expectedResult ="heaven It's easy if you try No hell below us Above only sky all the people today living life in peace";
            FileUtility util = new FileUtility();
            createFileContaingLines(folder1, file1);
            createFileContaingLines(folder1, file2);
            createFileContaingLines(folder1, file5);
            createFileContaingLines(folder2, file3);
            createFileContaingLines(folder2, file4);
            util.AddFolderContentToList(folder1.FullName);
            util.RemoveFolderContentFromList(folder2.FullName);
            DoublyLinkedListImpl list = util.GetList();
            Assert.AreEqual(21,list.Size());
            //verify each word is in the list
            foreach(string word in expectedResult.Split(' '))
            {
                Assert.IsTrue(list.IsContains(word), word +" is not in the list");
            }
           

            Directory.Delete(folder1.FullName, true);
            Directory.Delete(folder2.FullName, true);
        }


        [TestMethod]
        public void ComparingFoldersWithSubFoldersAndFiles()
        {

            DirectoryInfo folder1 = CreateTemporaryDirectory();
            DirectoryInfo folder2 = CreateTemporaryDirectory();
            DirectoryInfo subFolderInFolder1 = CreateSubDirectory(folder1);
            DirectoryInfo subFolderInFolder2 = CreateSubDirectory(folder2);
            string[] file1 = { "Imagine there's no heaven", "It's easy if you try", "No hell below us" };
            string[] file2 = { "Above us only sky", "Imagine all the people living for today" };
            string[] file3 = { "Imagine there's no countries", "It isn't hard to do" };
            string[] file4 = { "Nothing to kill or die for", "And no religion too" };
            string[] file5 = { "Imagine all the people living life in peace" };
            string expectedResult = "heaven It's easy if you try No hell below us Above only sky all the people today living life in peace";
            FileUtility util = new FileUtility();
            createFileContaingLines(folder1, file1);
            createFileContaingLines(subFolderInFolder1, file2);
            createFileContaingLines(subFolderInFolder1, file5);
            createFileContaingLines(folder2, file3);
            createFileContaingLines(subFolderInFolder2, file4);
            util.AddFolderContentToList(folder1.FullName);
            util.RemoveFolderContentFromList(folder2.FullName);
            DoublyLinkedListImpl list = util.GetList();
            Assert.AreEqual(21, list.Size());
            //verify each word is in the list
            foreach (string word in expectedResult.Split(' '))
            {
                Assert.IsTrue(list.IsContains(word), word + " is not in the list");
            }


            Directory.Delete(folder1.FullName, true);
            Directory.Delete(folder2.FullName, true);
        }



        private static DirectoryInfo CreateTemporaryDirectory()
        {
            string tempDirectory = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
            return Directory.CreateDirectory(tempDirectory);


        }

        private static DirectoryInfo CreateSubDirectory(DirectoryInfo directoryInfo)
        {
            string tempDirectory = Path.GetRandomFileName();
            return  directoryInfo.CreateSubdirectory(tempDirectory);
        }

        private static void createFileContaingLines(DirectoryInfo directory, String[] lines)
        {
            string file = Path.Combine(directory.FullName, Path.GetRandomFileName() + ".txt");
            using (StreamWriter outputFile = new StreamWriter(file))
            {
                foreach (string line in lines)
                    outputFile.WriteLine(line);
            }
        }


    }
}
