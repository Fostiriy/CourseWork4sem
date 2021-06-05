using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_ThoughtsOutLoud
{
	// Класс узла
	public class Node<Tdata>
	{
		public Node<Tdata> Next;
		public Tdata Data;

		public Node(Tdata value)
		{
			Data = value;
		}
	}

	// Класс односвязного списка
	public class SingleLinkedList<Tdata> : IEnumerable<Tdata>
	{
		// Голова и счётчик количества узлов
		private Node<Tdata> head;
		public int Count { get; private set; } = 0;

		// Возвращает строку, содержащую значения узлов списка по порядку
		public string Print()
		{
			string result = "";
			Node<Tdata> current = head;
			while (current != null)
			{
				result += current.Data + " -> ";
				current = current.Next;
			}
			result += "null";

			return result;
		}

		// Возвращает адрес нужного узла по ключу
		public Node<Tdata> Find(Tdata key)
		{
			if (Count == 0)
				return null;

			Node<Tdata> current = head;
			while (!current.Data.Equals(key))
			{
				current = current.Next;
				if (current == null)
					return null;
			}

			return current;
		}

		// Возвращает адрес нужного узла по индексу
		public Node<Tdata> FindByIndex(int index)
		{
			if (index > Count || index < 0)
				return null;

			Node<Tdata> node = head;
			int k = 0;

			while (k < index)
			{
				k++;
				node = node.Next;
			}

			return node;
		}

		// Возвращает последний узел, содержащий значение key
		public Node<Tdata> FindLast(Tdata key)
		{
			Node<Tdata> result_node = null;

			for (Node<Tdata> node = head; node != null; node = node.Next)
			{
				if (node.Data.Equals(key))
					result_node = node;
			}

			return result_node;
		}

		// Возвращает адрес последнего узла (хвоста)
		private Node<Tdata> FindTail()
		{
			if (Count == 0)
			{
				return null;
			}

			Node<Tdata> current = head;
			while (current.Next != null)
			{
				current = current.Next;
			}

			return current;
		}

		public bool Contains(Tdata key)
		{
			return (Find(key) != null);
		}

		// Добавление узла в конец списка
		public void PushBack(Tdata item)
		{
			Node<Tdata> newNode = new Node<Tdata>(item);
			if (Count == 0)
			{
				head = newNode;
			}
			else
			{
				Node<Tdata> tail = FindTail();
				tail.Next = newNode;
			}

			Count++;
		}

		// Добавление узла в начало списка
		public void PushFront(Tdata item)
		{
			Node<Tdata> newNode = new Node<Tdata>(item);

			if (Count != 0)
			{
				newNode.Next = head;
			}

			head = newNode;
			Count++;
		}

		// Добавление узла после указанного узла
		public void AddAfter(Node<Tdata> node, Tdata item)
		{
			if (node == null)
				return; // ничего не делаем, если адрес пустой

			Node<Tdata> newNode = new Node<Tdata>(item);

			newNode.Next = node.Next;
			node.Next = newNode;

			Count++;
		}

		private void AddAfter(Node<Tdata> nodeAfter, Node<Tdata> node)
		{
			if (nodeAfter == null)
				return; // ничего не делаем, если адрес пустой

			node.Next = nodeAfter.Next;
			nodeAfter.Next = node;

			Count++;
		}

		// Добавление узла перед указанным узлом
		public void AddBefore(Node<Tdata> node, Tdata item)
		{
			if (node == null)
				return; // ничего не делаем, если адрес пустой

			Node<Tdata> newNode = new Node<Tdata>(item);

			if (head == node)
			{
				newNode.Next = head;
				head = newNode;
			}
			else
			{
				Node<Tdata> current = head;

				while (current.Next != node)
					current = current.Next;
				current.Next = newNode;
				newNode.Next = node;
			}

			Count++;
		}

		//public void Insert(Tdata item)
		//{
		//	Node<Tdata> newNode = new Node<Tdata>(item);
		//	if (Count == 0)
		//	{
		//		head = newNode;
		//	}
		//	else
		//	{
		//		InsertAscending(newNode);
		//	}
		//}

		//private void InsertAscending(Node<Tdata> node)
		//{
		//	var tail = FindTail();
		//	if (node > tail)
		//	{
		//		AddAfter(tail, node);
		//		tail = node;
		//	}
		//	else
		//	{
		//		Node current = tail.Next;
		//		while (node.Key > current.Key && current.Next != tail)
		//			current = current.Next;
		//		InsertAfterInternal(current, node);
		//	}
		//}

		// Добавляет элементы переданного массива в конец
		public void PushBackRange(Tdata[] array)
		{
			Node<Tdata> tail = FindTail();

			for (int i = 0; i < array.Length; i++)
			{
				Node<Tdata> newNode = new Node<Tdata>(array[i]);
				if (Count == 0)
					head = newNode;
				else
					tail.Next = newNode;
				tail = newNode;

				Count++;
			}
		}

		// Удаление первого узла
		public void RemoveFirst()
		{
			if (Count == 0)
			{
				throw new Exception("Список пуст"); // Вызывает исключение
			}

			head = head.Next;
			Count--;
		}

		// Удаление последнего узла
		public void RemoveLast()
		{
			if (Count == 0)
			{
				throw new Exception("Список пуст");
			}

			if (Count == 1)
			{
				head = null;
			}
			else
			{
				Node<Tdata> current = head;
				while (current.Next.Next != null)
				{
					current = current.Next;
				}

				current.Next = null;
			}

			Count--;
		}

		// Удаление произвольного узла
		public void RemoveNode(Node<Tdata> node)
		{
			if (head == node)
			{
				head = node.Next;
			}
			else
			{
				Node<Tdata> current = head;
				while (current.Next != node)
				{
					current = current.Next;
				}

				current.Next = node.Next;
			}

			Count--;
		}

		// Возвращает true при удалении первого вхождения указанного элемента, иначе false
		public bool Remove(Tdata item)
		{
			if (Count == 0)
				throw new Exception("Список пуст");
			if (Count == 1)
			{
				if (head.Data.Equals(item))
				{
					head = null;
					Count--;
					return true;
				}
				else
					return false;
			}
			else
			{
				Node<Tdata> current = head;

				if (head.Data.Equals(item))
				{
					head = head.Next;
					Count--;
					return true;
				}

				while (current.Next != null)
				{
					if (current.Next.Data.Equals(item))
					{
						current.Next = current.Next.Next;
						Count--;
						return true;
					}
					current = current.Next;
				}
				return false;
			}
		}

		// Возвращает true при удалении последнего вхождения указанного элемента, иначе false
		public bool RemoveLast(Tdata item)
		{
			if (Count == 0)
				throw new Exception("Список пуст");

			if (Count == 1 && !head.Data.Equals(item))
				return false;

			Node<Tdata> current = head;
			Node<Tdata> node = null;

			while (current.Next != null)
			{
				if (current.Next.Data.Equals(item))
					node = current;
				current = current.Next;
			}

			if (head.Data.Equals(item) && node == null)
			{
				head = head.Next;
				Count--;
				return true;
			}

			if (node != null)
			{
				node.Next = node.Next.Next;
				Count--;
				return true;
			}

			return false;
		}

		// Удаляет все элементы, равные переданному элементу и возвращает количество этих элементов
		public int RemoveAll(Tdata item)
		{
			int k = Count; // Количество элементов в переданном списке
			Node<Tdata> current = head;

			if (k > 2)
			{
				while (current.Next != null)
				{
					if (current.Next.Data.Equals(item))
					{
						current.Next = current.Next.Next;
						Count--;
					}
					else
						current = current.Next;
				}
			}

			if (head.Data.Equals(item))
			{
				head = head.Next;
				Count--;
			}

			return k - Count;
		}

		// Переворачивает все элементы в обратном порядке
		public void Reverse()
		{
			if (Count <= 1)
				return;

			Node<Tdata> prev = null;
			Node<Tdata> current = head;
			Node<Tdata> next = current.Next;

			while (next != null)
			{
				next = current.Next;
				current.Next = prev;
				prev = current;
				current = next;
			}

			head = prev;
		}

		// Очищает список
		public void Clear() => head = null;

		// Реализация foreach
		IEnumerator<Tdata> IEnumerable<Tdata>.GetEnumerator()
		{
			Node<Tdata> pointer = head;
			while (pointer != null)
			{
				yield return pointer.Data;
				pointer = pointer.Next;
			}
		}

		// Реализация foreach
		IEnumerator IEnumerable.GetEnumerator()
		{
			Node<Tdata> pointer = head;
			while (pointer != null)
			{
				yield return pointer.Data;
				pointer = pointer.Next;
			}
		}
	}
}
