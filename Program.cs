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
			DoublyLinkedList queue = new DoublyLinkedList();

			queue.Enqueue(1);
			queue.Enqueue(2);
			queue.Enqueue(3);
			queue.Enqueue(4);

			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("\nСодержимое очереди:");
			queue.Print();
			Console.ResetColor();

			Console.ForegroundColor = ConsoleColor.Magenta;
			Console.WriteLine($"\nПервый элемент очереди (отсчёт с конца): \n{queue.Peek()}");
			Console.ResetColor();

			Console.ForegroundColor = ConsoleColor.Blue;
			Console.WriteLine($"\nУдалён элемент с конца очереди: \n{queue.Dequeue()}");
			Console.WriteLine($"\nУдалён элемент с конца очереди: \n{queue.Dequeue()}");
			Console.ResetColor();

			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("\nСодержимое очереди после удаления элементов:");
			queue.Print();
			Console.ResetColor();

			Console.WriteLine("\nОчистка очереди...");
			queue.Clear();

			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine("\nСодержимое очереди после очистки:");
			queue.Print();
			Console.ResetColor();
			Console.ReadKey();
		}
    }
}
