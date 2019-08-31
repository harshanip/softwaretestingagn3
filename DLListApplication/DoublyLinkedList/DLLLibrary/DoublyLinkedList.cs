using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLLLibrary

{
    
    public class DoublyLinkedListImpl
    {
        /// <summary>
        /// This private class represent a node in the list with pointers to its previous and next node
        /// </summary>
        private class Node
        {
            public String data;
            public Node previous;
            public Node next;

            public Node(String value, Node previous, Node next)
            {
                if (value == null)
                {
                    throw new ArgumentNullException("value should not be null");
                }
                this.data = value;
                this.previous = previous;
                this.next = next;
            }
        }

        private Node head;
        /// <summary>
        /// Verify if list is empty
        /// </summary>
        /// <returns> true is list is empty, false otherwise</returns>
        public bool IsEmpty()
        {
            return head == null;
        }
        /// <summary>
        /// Size of the list
        /// </summary>
        /// <returns>Size of the list</returns>
        public int Size()
        {
            int size = 0;
            Node tmp = head;
            while (tmp != null)
            {
                size++;
                tmp = tmp.next;
            }
            return size;
        }

        /// <summary>
        /// Insert a word to the head of the list
        /// </summary>
        /// <param name="word">word to be inserted</param>
        public void Insert(String word)
        {
            Node next = head;
            Node newNode = new Node(word, null, next);
            head = newNode;
            if (next != null)
            {
                next.previous = newNode;
            }
        }

        /// <summary>
        /// verify is specific word is already in the list
        /// </summary>
        /// <param name="word">word to be verified</param>
        /// <returns>true if word is in the list, false otherwise</returns>
        public bool IsContains(String word)
        {
            Node tmp = head;
            while (tmp != null)
            {
                if (tmp.data.Equals(word))
                {
                    return true;
                }
                tmp = tmp.next;
            }
            return false;
        }

      
  

        public override string ToString()
        {
            string Str = "[";
            Node n = head;
            while (n != null)
            {
                Str += " ";
                Str += n.data;
                n = n.next;
            }
            Str += " ]";
            return Str;
        }

        /// <summary>
        /// convert words to multiple lines. Each line is seperated by new line of the enviornment
        /// </summary>
        /// <param name="numberOfWordsPerLine">Number of words for each line</param>
        /// <returns></returns>
        public string display(int numberOfWordsPerLine)
        {
            if (numberOfWordsPerLine < 1) throw new ArgumentOutOfRangeException("number of words should be more than or equal to 1");
            StringBuilder result = new StringBuilder();
            StringBuilder line = new StringBuilder();
            int count = 1;
            Node tmp = head;
            while (tmp != null)
            {
                line.Append(tmp.data);
                if (count == numberOfWordsPerLine)
                {
                    result.AppendLine(line.ToString().Trim());
                    line.Clear();
                    count = 0;
                }
                else
                {
                    line.Append(' ');
                }
                count++;
                tmp = tmp.next;
            }
            result.Append(line.ToString().Trim());
            return result.ToString();
        }

        /// <summary>
        /// Delete the first occurance of given word in the list
        /// </summary>
        /// <param name="word">word to be deleted</param>
        /// <returns>true if word was in the list and deleted, false if no word is deleted</returns>
        public bool Delete(string word)
        {
            if (head == null)
            {
                return false;
            }
            Node tmp = head;
            while (tmp != null)
            {
                if (tmp.data.Equals(word))
                {
                    Node next = tmp.next;
                    Node previous = tmp.previous;
                    if (previous == null && next == null)
                    {
                        //If both previous and next are null , then what is left is an empty list
                        head = null;
                    }
                    else if (previous == null)
                    {
                        //This is the head node and it has to have not null next
                        next.previous = null;
                        head = next;
                    }
                    else if (next == null)
                    {
                        //Previous is not null, but this is the last node
                        previous.next = null;
                    }
                    else
                    {
                        //This is a middle node
                        next.previous = previous;
                        previous.next = next;
                    }
                    return true;
                }
                tmp = tmp.next;
            }
            return false;
        }
    }
}
 