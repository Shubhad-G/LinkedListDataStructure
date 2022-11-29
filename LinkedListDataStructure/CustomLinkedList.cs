using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListDataStructure
{
    internal class CustomLinkedList
    {
        public Node head;
        public void addFirst(int data)
        {
            Node newNode = new Node(data);
            if (head == null)
            {
                head = newNode;
                Console.WriteLine("{0} is added to the Linked list", newNode.data);
            }
            else
            {
                newNode.referenceToNextNode = head;
                head = newNode;
                Console.WriteLine("{0} is inserted at the first position", newNode.data);

            }
        }
        public void addLast(int data)
        {
            Node newNode = new Node(data);
            if (head == null)//to check whether there are any nodes present or not
                head = newNode;//if there are no nodes new node becomes the head node 
            else
            {
                Node temp = head;
                while (temp.referenceToNextNode != null)//to iterate throgh the linked list
                {
                    temp = temp.referenceToNextNode;
                }
                temp.referenceToNextNode = newNode;//here adding the linked list at the end of linked list
            }
            Console.WriteLine("{0} is inserted at the end of linked list", newNode.data);
        }

        public void addBetween(int data)
        {
            Node newNode = new Node(data);
            if (head == null)
                head = newNode;
            else
            {
                newNode.referenceToNextNode = head.referenceToNextNode;
                head.referenceToNextNode = newNode;
            }
        }
        public void displayLinkedList()
        {
            Node temp = head;
            if (temp == null)
                Console.WriteLine("Linked list empty");
            else
            {
                Console.Write("linked list elements\n");
                while (temp != null)
                {
                    Console.Write(" " + temp.data);
                    temp = temp.referenceToNextNode;
                }
            }
        }
        public void popFirst(int data)
        {
            Node temp = head;
            if (temp == null)
                Console.WriteLine("Linked list is empty");
            else
            {
                head = head.referenceToNextNode;
                Console.WriteLine("{0} is deleted from the linked list",data);
            }
        }
    }
}
