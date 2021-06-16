using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_ThoughtsOutLoud
{
	// Класс узла
	public class ListNode<Tdata>
	{
		public ListNode<Tdata> Next;
		public Tdata Data;

		public ListNode(Tdata value)
		{
			Data = value;
		}
	}

	// Класс односвязного списка
	public class SingleLinkedList<Tdata> : IEnumerable<Tdata>
	{
		// Голова и счётчик количества узлов
		private ListNode<Tdata> head;
		public int Count { get; private set; } = 0;

		// Очищает список
		public void Clear() => head = null;

		// Возвращает строку, содержащую значения узлов списка по порядку
		public string Info()
		{
			string result = string.Empty;
			ListNode<Tdata> current = head;
			while (current != null)
			{
				result += current.Data + " -> ";
				current = current.Next;
			}
			result += "null";

			return result;
		}

		// Возвращает строку, содержащую значения узлов списка по порядку
		public string ElementsInfo()
		{
			string result = string.Empty;
			ListNode<Tdata> current = head;
			while (current != null)
			{
				result += $"{current.Data}\n";
				current = current.Next;
			}

			return result;
		}

		// Возвращает адрес нужного узла по ключу
		public ListNode<Tdata> Find(Tdata key)
		{
			if (Count == 0)
				return null;

			ListNode<Tdata> current = head;
			while (!current.Data.Equals(key))
			{
				current = current.Next;
				if (current == null)
					return null;
			}

			return current;
		}

		// Возвращает адрес нужного узла по индексу
		public ListNode<Tdata> FindByIndex(int index)
		{
			if (index > Count || index < 0)
				return null;

			ListNode<Tdata> node = head;
			int k = 0;

			while (k < index)
			{
				k++;
				node = node.Next;
			}

			return node;
		}

		// Возвращает последний узел, содержащий значение key
		public ListNode<Tdata> FindLast(Tdata key)
		{
			ListNode<Tdata> result_node = null;

			for (ListNode<Tdata> node = head; node != null; node = node.Next)
			{
				if (node.Data.Equals(key))
					result_node = node;
			}

			return result_node;
		}

		// Возвращает адрес последнего узла (хвоста)
		private ListNode<Tdata> FindTail()
		{
			if (Count == 0)
			{
				return null;
			}

			ListNode<Tdata> current = head;
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
			ListNode<Tdata> newNode = new ListNode<Tdata>(item);
			if (Count == 0)
			{
				head = newNode;
			}
			else
			{
				ListNode<Tdata> tail = FindTail();
				tail.Next = newNode;
			}

			Count++;
		}

		// Добавление узла в начало списка
		public void PushFront(Tdata item)
		{
			ListNode<Tdata> newNode = new ListNode<Tdata>(item);

			if (Count != 0)
			{
				newNode.Next = head;
			}

			head = newNode;
			Count++;
		}

		// Добавление узла после указанного узла
		public void AddAfter(ListNode<Tdata> node, Tdata item)
		{
			if (node == null)
				return; // ничего не делаем, если адрес пустой

			ListNode<Tdata> newNode = new ListNode<Tdata>(item);

			newNode.Next = node.Next;
			node.Next = newNode;

			Count++;
		}

		private void AddAfter(ListNode<Tdata> nodeAfter, ListNode<Tdata> node)
		{
			if (nodeAfter == null)
				return; // ничего не делаем, если адрес пустой

			node.Next = nodeAfter.Next;
			nodeAfter.Next = node;

			Count++;
		}

		// Добавление узла перед указанным узлом
		public void AddBefore(ListNode<Tdata> node, Tdata item)
		{
			if (node == null)
				return; // ничего не делаем, если адрес пустой

			ListNode<Tdata> newNode = new ListNode<Tdata>(item);

			if (head == node)
			{
				newNode.Next = head;
				head = newNode;
			}
			else
			{
				ListNode<Tdata> current = head;

				while (current.Next != node)
					current = current.Next;
				current.Next = newNode;
				newNode.Next = node;
			}

			Count++;
		}

		// Добавляет элементы переданного массива в конец
		public void PushBackRange(Tdata[] array)
		{
			ListNode<Tdata> tail = FindTail();

			for (int i = 0; i < array.Length; i++)
			{
				ListNode<Tdata> newNode = new ListNode<Tdata>(array[i]);
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
				ListNode<Tdata> current = head;
				while (current.Next.Next != null)
				{
					current = current.Next;
				}

				current.Next = null;
			}

			Count--;
		}

		// Удаление произвольного узла
		public void RemoveNode(ListNode<Tdata> node)
		{
			if (head == node)
			{
				head = node.Next;
			}
			else
			{
				ListNode<Tdata> current = head;
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
				ListNode<Tdata> current = head;

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

			ListNode<Tdata> current = head;
			ListNode<Tdata> node = null;

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
			ListNode<Tdata> current = head;

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

			ListNode<Tdata> prev = null;
			ListNode<Tdata> current = head;
			ListNode<Tdata> next = current.Next;

			while (next != null)
			{
				next = current.Next;
				current.Next = prev;
				prev = current;
				current = next;
			}

			head = prev;
		}

		// Реализация foreach
		IEnumerator<Tdata> IEnumerable<Tdata>.GetEnumerator()
		{
			ListNode<Tdata> pointer = head;
			while (pointer != null)
			{
				yield return pointer.Data;
				pointer = pointer.Next;
			}
		}

		// Реализация foreach
		IEnumerator IEnumerable.GetEnumerator()
		{
			ListNode<Tdata> pointer = head;
			while (pointer != null)
			{
				yield return pointer.Data;
				pointer = pointer.Next;
			}
		}
	}
}
