using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublyLinkedList
{
	class DoublyLinkedList
	{
		Element Head { get; set; }
		Element Tail { get; set; } // добавление конца очереди
		public int Length { get; private set; }

		public DoublyLinkedList()
		{
			Head = null;
			Tail = null;
			Length = 0;
			Console.WriteLine($"LConstructor:\t{GetHashCode()}");
		}

		~DoublyLinkedList()
		{
			Clear();
			Console.WriteLine($"LDestructor:\t{GetHashCode()}");
		}

		public void Clear()
		{
			while (Head != null)
			{
				Dequeue();
			}
		}
		
		public void Enqueue(int data)// добавление в конец
		{
			Element newElement = new Element(data);

			if (Head == null)
			{
				Head = newElement;
				Tail = newElement;
			}
			else
			{
				Tail.pNext = newElement;
				newElement.pPrev = Tail;
				Tail = newElement;
			}
			Length++;
		}

		public int? Dequeue()		// удаление с головы
		{
			if (Head == null)
			{
				return null;
			}

			int dequeuedData = Head.Data;
			Head = Head.pNext;

			if (Head != null)
			{
				Head.pPrev = null;
			}
			else
			{
				Tail = null;
			}

			Length--;
			return dequeuedData;
		}

		public int? Peek() //определение первого элемента
		{
			if (Head == null)
			{
				return null;
			}
			return Head.Data;
		}

		public void Print()
		{
			for (Element Temp = Head; Temp != null; Temp = Temp.pNext)
			{
				Console.Write($"{Temp.Data}\t");
			}
			Console.WriteLine();
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine($"\nКоличество элементов в очереди: \n{Length}");
			Console.ResetColor();
		}
	}
}
