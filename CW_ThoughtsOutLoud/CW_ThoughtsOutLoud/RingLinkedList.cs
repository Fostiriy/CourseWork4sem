using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_ThoughtsOutLoud
{
	// Класс односвязного кольцевого списка с хвостом (без головы)
	// цепочка - односвязный кольцевой список
	public class RingLinkedList
	{
		private Node tail;
		private int count;

		// Входные данные: пусто
		// Конструктор
		// Выходные данные: объект класса
		public RingLinkedList()
		{
			tail = null;
			count = 0;
		}

		// Входные данные: объект класса
		// Возвращает количество узлов
		// Выходные данные: количество узлов в цепочке
		public int GetSize()
		{
			return count;
		}

		// Входные данные: объект класса
		// Возвращает строку — значения узлов списка по порядку от хвоста
		// Выходные данные: строка с полями элементов цепочки
		public string Info()
		{
			if (count == 0)
			{
				return string.Empty;
			}

			return Info(tail.Next);
		}

		// Входные данные: целочисленный ключ, объект класса
		// Возвращает узел по заданному ключу
		// Выходные данные: элемент с данным ключом в цепочке или null
		public Node Find(int key)
		{
			if (count == 0)
			{
				return null;
			}

			Node current = tail;
			do
			{
				if (current.Key == key)
				{
					return current;
				}

				current = current.Next;
			}
			while (current != tail);

			return null;
		}

		// Входные данные: объект класса, целочисленный ключ, целочисленное число - данные элемента
		// Добавление узла с переданными полями по возрастанию
		// Выходные данные: изменённая цепочка с новым элементом
		public void Insert(int key, int item)
		{
			Node newNode = new Node(key, item);
			if (count == 0)
			{
				InsertToEmpty(newNode);
			}
			else
			{
				InsertAscending(newNode);
			}
		}

		// Входные данные: объект класса, элемент, который нужно вставить
		// Добавление узла по возрастанию
		// Выходные данные: изменённая цепочка с новым элементом
		public void Insert(Node node)
		{
			if (count == 0)
			{
				InsertToEmpty(node);
			}
			else
			{
				InsertAscending(node);
			}
		}

		// Входные данные: объект класса, целочисленный ключ
		// Удаляет первое вхождение указанного значения из списка. 
		// Возвращает true при удалении, иначе false
		// Выходные данные: true или false, при true изменённая цепочка без элемента с искомым ключом
		public bool Remove(int key)
		{
			Node node = Find(key);

			if (node != null)
			{
				RemoveNode(node);
				return true;
			}

			return false;
		}

		// Входные данные: объект класса, элемент
		// Удаляет первое вхождение указанного значения из списка. 
		// Возвращает true при удалении, иначе false
		// Выходные данные: true или false, при true изменённая цепочка без элемента
		public bool Remove(Node node)
		{
			if (node != null)
			{
				RemoveNode(node);
				return true;
			}

			return false;
		}

		// Входные данные: объект класса
		// Удаляет все элементы цепочки
		// Выходные данные: цепочка без элементов, tail = null
		public void Clear()
		{
			while (tail != null)
			{
				Remove(tail);
			}
		}

		// Входные данные: объект класса, элемент
		// Возвращает строку - значения узлов по порядку от переданного узла
		// Выходные данные: строка с информацией об элементе
		private string Info(Node node)
		{
			if (count == 0)
			{
				Console.WriteLine(string.Empty);
			}

			string result = "";
			Node current = node;
			do
			{
				result += $"{current.Key} {current.Data}\n";
				current = current.Next;
			} while (current != node);

			return result;
		}

		// Входные данные: объект класса, элемент
		// Вставляет узел в пустой список:
		// Выходные данные: цепочка с одним элементов
		private void InsertToEmpty(Node node)
		{
			node.Next = node;
			tail = node;
			count++;
		}

		// Входные данные: объект класса, элемент
		// Добавляет новый узел по возрастанию
		// Выходные данные: цепочка с добавленным элементом
		private void InsertAscending(Node node)
		{
			if (node.Key > tail.Key)
			{
				InsertAfterInternal(tail, node);
				tail = node;
			}
			else
			{
				Node current = tail.Next;
				while (node.Key > current.Key && current.Next != tail)
					current = current.Next;
				InsertAfterInternal(current, node);
			}
		}

		// Входные данные: объект класса, элемент, новый элемент
		// Добавляет новый узел после переданного узла, т.е. newNode после node
		// Выходные данные: цепочка с новым элементом, добавленным после элемента
		private void InsertAfterInternal(Node node, Node newNode)
		{
			newNode.Next = node.Next;
			node.Next = newNode;
			count++;
		}

		// Входные данные: объект класса, элемент
		// Удаляет переданный узел
		// Выходные данные: цепочка без переданного элемента
		private void RemoveNode(Node node)
		{
			if (count == 0)
			{
				throw new Exception("Список пуст");
			}

			Node current = node;
			while (current.Next != node)
			{
				current = current.Next;
			}

			RemoveAfterNodeInternal(current);
		}

		// Входные данные: объект класса, элемент
		// Удаляет узел после переданного узла
		// Выходные данные: цепочка без элемента, следующего за переданным элементом
		private void RemoveAfterNodeInternal(Node node)
		{
			if (count == 0)
			{
				throw new Exception("Список пуст");
			}

			if (count == 1)
			{
				tail = null;
			}
			else
			{
				if (node.Next == tail)
				{
					tail = node;
				}

				node.Next = node.Next.Next;
			}

			count--;
		}

	}
}
