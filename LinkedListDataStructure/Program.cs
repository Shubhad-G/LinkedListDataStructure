using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListDataStructure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("implementation of simple Single Linked List program");
            CustomLinkedList node = new CustomLinkedList();
            node.addFirst(56);
            node.addLast(70);
            node.addBetween(30);
            node.displayLinkedList();
            node.searchList(30);
            node.insertAfter(40, 30);
            node.displayLinkedList();
            node.deleteBetween(40);
            node.displayLinkedList();
            node.size();
            Console.ReadLine();
        }
    }
}
