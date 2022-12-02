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
            //node.addFirst(56);
            //node.addLast(70);
            //node.addBetween(30);
            //node.displayLinkedList();
            //node.searchList(30);
            //node.insertAfter(40, 30);
            //node.displayLinkedList();
            //node.deleteBetween(40);
            //node.displayLinkedList();
            //node.size();
            SortedLinkedList nodeAdd = new SortedLinkedList();
            //nodeAdd.SortAndAdd(31);
            //nodeAdd.SortAndAdd(30);
            //nodeAdd.SortAndAdd(29);

            nodeAdd.SortAndAdd(56);
            nodeAdd.SortAndAdd(30);
            nodeAdd.SortAndAdd(40);
            nodeAdd.SortAndAdd(70);
            nodeAdd.displayLinkedList();
            Console.ReadLine();
        }
    }
}
