using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DLLLibrary
{
    public class FileUtility
    {

        DoublyLinkedListImpl list;

        public FileUtility()
        {
            list = ListUtility.createNewList();
        }


        public DoublyLinkedListImpl GetList()
        {
            return list;
        }

        public void AddFolderContentToList(String folderPath)
        {
            DirectoryInfo diTop = new DirectoryInfo(@folderPath);


            foreach (var file in Directory.EnumerateFiles(folderPath, "*.txt", SearchOption.AllDirectories))
            {
                foreach (string line in File.ReadLines(file))
                {
                    ListUtility.AddnewWordstoDoublylinkedList(list, line);
                }
            }
        }

        public void RemoveFolderContentFromList(string folderPath)
        {
            DirectoryInfo diTop = new DirectoryInfo(@folderPath);


            foreach (var file in Directory.EnumerateFiles(folderPath, "*.txt", SearchOption.AllDirectories))
            {
                foreach (string line in File.ReadLines(file))
                {
                    ListUtility.RemoveWordstoDoublylinkedList(list, line);
                }
            }
        }


    }
}
