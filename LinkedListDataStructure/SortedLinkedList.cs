using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListDataStructure
{
    internal class SortedLinkedList
    {
        public Node head;

        public void SortAndAdd(int data)
        {
            Node temp= head;
            Node newNode = new Node(data);
            if (temp == null)//if there are no nodes present in the list then newnode is added and it becomes the head
            {
                head = newNode;
                Console.WriteLine("{0} is added to the list and it is currently the head of the list",newNode.data);
            }
            else if (newNode.data <= head.data) //condition to check whether the new node data is less than head data then newnode becomes the head and it will point towards previous headnode
            {
                newNode.referenceToNextNode = head;
                head = newNode;
                Console.WriteLine("{0} is added to the list and it is currently the head of the list", newNode.data);
            }
            else
            {
                temp = head;
                while(temp != null)//traversing the list to get the correct sorted position to insert the new node 
                {
                    if(temp.referenceToNextNode.data<newNode.data)
                    { 
                        newNode.referenceToNextNode=temp.referenceToNextNode;
                        temp.referenceToNextNode = newNode;
                        Console.WriteLine("{0} is inserted in the list", newNode.data);
                       
                    }
                    else if(temp.referenceToNextNode.data>newNode.data )
                    {
                        temp.referenceToNextNode = newNode.referenceToNextNode;
                        newNode.referenceToNextNode = temp;
                        Console.WriteLine("{0} is inserted in the list", newNode.data);
                        
                       
                    }
                    else//last condition if newnode data is greater than all the data present in the list then newnode is inserted at the last position
                    {
                        temp.referenceToNextNode = newNode;
                        newNode.referenceToNextNode = null;
                        Console.WriteLine("{0} is inserted at the last position", newNode.data);
                        break;
                        
                    }
                    temp=temp.referenceToNextNode;
                }
            }
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

    }
}
