using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DLLLibrary
{
    public class ListUtility
    {
        public static DoublyLinkedListImpl createNewList()
        {
            return new DoublyLinkedListImpl();
        }

        /// <summary>
        /// This method broken a line into words and insert each word to list, if that word is not already in the list.
        /// </summary>
        /// <param name="list">DoublyLinkedListImpl to add words</param>
        /// <param name="line">line of words to be inserted</param>
        public static void AddnewWordstoDoublylinkedList(DoublyLinkedListImpl list, String line)
        {
            string[] wordds = line.Split(' ');
            foreach (string Str in wordds)
            {
                if (!list.IsContains(Str))
                {
                    list.Insert(Str);
                }
            }
        }

        /// <summary>
        /// This method broken a line into words and delete each word from the list if it is in the list.
        /// </summary>
        /// <param name="list">DoublyLinkedListImpl from which words are removed</param>
        /// <param name="line">line of words to be deleted</param>
        internal static void RemoveWordstoDoublylinkedList(DoublyLinkedListImpl list, string line)
        {
            string[] wordds = line.Split(' ');
            foreach (string Str in wordds)
            {
                list.Delete(Str);
            }
        }
    }
}
