using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublyLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
			DoublyLinkedList<int> list = new DoublyLinkedList<int>();

			list.AddLast(10);
			list.AddLast(20);
			list.AddLast(30);
			list.AddFirst(5);

			Console.WriteLine("List forward: ");
			list.PrintForward();

			Console.WriteLine("List backward: ");
			list.PrintBackward();

			list.RemoveFirst();
			list.RemoveLast();

			Console.WriteLine("List forward after removing first and last: ");
			list.PrintForward();
		}
    }
}
