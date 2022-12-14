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
            Console.WriteLine("{0} is inserted between the list",data);
        }
        public void displayLinkedList()
        {
            Node temp = head;
            if (temp == null)
                Console.WriteLine("Linked list empty");
            else
            {
                Console.Write("\nlinked list elements\n");
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
                head = head.referenceToNextNode;//made the next node as head by assigning the link of head node's next reference to next node and hence the link is deleted
                Console.WriteLine("{0} is deleted from the linked list",data);
            }
        }
          
        public void popLast(int data)
        {
            Node temp = head;
            if (temp == null)
                Console.WriteLine("Linked list is empty");
            else
            {
                while (temp.referenceToNextNode.referenceToNextNode != null)
                {
                    temp = temp.referenceToNextNode;
                    
                }
                temp.referenceToNextNode = null;
                Console.WriteLine("{0} is deleted from the linked list", data);
            }
        }
        public void searchList(int data)
        {
            Node temp = head;
            if (temp == null)
                Console.WriteLine("Linked list is empty");
            else
            {
                while(temp.referenceToNextNode!=null)
                {
                    if (temp.data == data)
                    {
                        Console.WriteLine("\n{0} is present in the linked list", temp.data);
                        break;
                    }
                    else
                        temp = temp.referenceToNextNode;
                }
            }
        }
        public void insertAfter(int data,int afterData)
        {
            Node newNode=new Node(data);
            Node temp = head;
            if (temp == null)
                Console.WriteLine("Linked list is empty");
            else
            {
                while (temp.referenceToNextNode!=null)
                {
                    if (temp.data == afterData)
                    {
                        newNode.referenceToNextNode = temp.referenceToNextNode;
                        temp.referenceToNextNode = newNode;
                        Console.WriteLine("{0} is inserted between {1} and {2}", data, afterData, newNode.referenceToNextNode.data);
                    }
                    temp = temp.referenceToNextNode;
                }
            }
        }
        public void deleteBetween(int data)
        {
            Node temp = head;
            
            if (temp == null)
                Console.WriteLine("Linked list is empty");
            else
            {
                while (temp.referenceToNextNode!=null)
                {
                  
                    if (temp.referenceToNextNode.data==data)
                    { 
                        temp.referenceToNextNode = temp.referenceToNextNode.referenceToNextNode;
                        Console.WriteLine("\n{0} is deleted from the list", temp.data);
                        break;
                    }
                    temp = temp.referenceToNextNode;  
                }
               
            }
        }
        public void size()
        {
            Node temp = head;
            int elements=0;
            if (temp == null)
                Console.WriteLine("Linked list is empty hence there are {0} elements in the linked list",elements);
            else
            {
                while (temp != null)
                {
                    elements++;
                    temp = temp.referenceToNextNode;
                }
                Console.WriteLine("\nSize of linked list is: {0}", elements);
            }
        }
    }
}
