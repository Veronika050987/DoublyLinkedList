using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublyLinkedList
{
	class Element
	{
		public int Data { get; set; }
		public Element pNext { get; set; }
		public Element pPrev { get; set; }

		public Element(int data)
		{
			Data = data;
			pNext = null;
			pPrev = null;
			Console.WriteLine($"EConstructor:\t{GetHashCode()}");
		}

		~Element()
		{
			Console.WriteLine($"EDestructor:\t{GetHashCode()}");
		}
	}
}
