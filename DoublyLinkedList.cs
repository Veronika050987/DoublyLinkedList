using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublyLinkedList
{
	class DoublyLinkedList<T>
	{
		public Node<T> Head { get; private set; }
		public Node<T> Tail { get; private set; }
		public int Count { get; private set; }

		public DoublyLinkedList()
		{
			Head = null;
			Tail = null;
			Count = 0;
		}

		public void AddLast(T data)
		{
			Node<T> newNode = new Node<T>(data);

			if (Head == null)
			{
				Head = newNode;
				Tail = newNode;
			}
			else
			{
				newNode.Previous = Tail;
				Tail.Next = newNode;
				Tail = newNode;
			}

			Count++;
		}

		public void AddFirst(T data)
		{
			Node<T> newNode = new Node<T>(data);

			if (Head == null)
			{
				Head = newNode;
				Tail = newNode;
			}
			else
			{
				newNode.Next = Head;
				Head.Previous = newNode;
				Head = newNode;
			}

			Count++;
		}

		public void RemoveFirst()
		{
			if (Head == null)
				return;

			if (Head == Tail)
			{
				Head = null;
				Tail = null;
			}
			else
			{
				Head = Head.Next;
				Head.Previous = null;
			}

			Count--;
		}

		public void RemoveLast()
		{
			if (Tail == null)
				return;

			if (Head == Tail)
			{
				Head = null;
				Tail = null;
			}
			else
			{
				Tail = Tail.Previous;
				Tail.Next = null;
			}

			Count--;
		}

		public void PrintForward()
		{
			Node<T> current = Head;
			while (current != null)
			{
				Console.Write(current.Data + " ");
				current = current.Next;
			}
			Console.WriteLine();
		}

		public void PrintBackward()
		{
			Node<T> current = Tail;
			while (current != null)
			{
				Console.Write(current.Data + " ");
				current = current.Previous;
			}
			Console.WriteLine();
		}
	}
}
