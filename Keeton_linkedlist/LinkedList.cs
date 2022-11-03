using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keeton_linkedlist
{
    internal class LinkedList
    {
        Node head;

        public LinkedList()
        {
            head = null;
        }

        public void Add(string data)
        {
            Node node = new Node(data);
            node.Next = head;
            head = node;
        }

        public bool Contains(string data)
        {
            Node current = head;
            if (current == null)
            {
                Console.WriteLine("404 Not Found");
                return false;
            }
            while (current != null)
            {

                if (data.Contains(current.Data))
                {
                    Console.WriteLine("Requested Name Found: \n" + data);
                    return true;
                }

                current = current.Next;
            }

            return false;
        }

        public void Remove(string data)
        {
            Node temp = head;
            Node current = head;
            Node previous = null;

            if (temp == null)
            {
                Console.WriteLine(data + " is not on the List.");
                return;
            }

            while (temp != null)
            {
                current = temp;

                if (temp.Data != data)
                {
                    Console.WriteLine("Name not found. Did you type it correctly?");
                    return;
                }
                if (temp.Data == data)
                {
                    if (previous != null)
                    {
                        previous.Next = current.Next;
                    }
                    else
                    {
                        head = head.Next;
                    }
                    break;
                }
                previous = current;
                temp = temp.Next;
            }
        }
        public void PrintAllNodes()
        {
            Node current = head;
            while (current != null)
            {
                Console.WriteLine(current.Data);
                current = current.Next;
            }
        }
    }
}
