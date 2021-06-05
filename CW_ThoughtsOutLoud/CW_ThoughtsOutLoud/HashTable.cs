//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CW_ThoughtsOutLoud
//{
//	// Класс узла
//	public class HTNode
//	{
//		public HTNode Next;   // Элемент, следующий за данным
//		public int Key;     // Ключ - натуральное число
//		public int Data;    // Данные - целочисленное число

//		// Входные данные: целочислленый ключ, число-данные
//		// Конструктор
//		// Выходные данные: объект класса с данными ключом и данными
//		public HTNode(int key, int data)
//		{
//			Key = key;
//			Data = data;
//		}
//	}

//	class HashTable
//	{
//		private const double HASH_CONST = 0.341;	// Константа для хеш-функции
//		private SingleLinkedList<HTNode>[] items;				// Массив цепочек
//		private int size;							// Размер хеш-таблицы (длина массива items)

//		// Входные данные: размер хеш-таблицы
//		// Конструктор по размеру
//		// Выходные данные: хеш-таблица с заданной размерностью
//		public HashTable(int size)
//		{
//			items = new RingLinkedList[size];
//			this.size = size;
//			for (int i = 0; i < this.size; i++)
//			{
//				items[i] = new RingLinkedList();
//			}
//		}

//		// Входные данные: объект класса
//		// Метод, возвращающий размермерность хеш-таблицы
//		// Выходные данные: размерность хеш-таблицы
//		public int GetSize()
//		{
//			return size;
//		}

//		// Входные данные: объект класса
//		// Метод, возвращающий строку с информацией о таблице
//		// Выходные данные: строка с информацией о всех элементах таблицы
//		public string Info()
//		{
//			string result = string.Empty;

//			for (int i = 0; i < size; i++)
//			{
//				result += "\t" + i + ":\n" + items[i].Info();
//			}

//			return result;
//		}

//		// Входные данные: объект класса, целочисленный ключ, целое число-данные
//		// Вставка элемента с заданным ключом и заданными данными
//		// Выходные данные: хеш-таблица с вставленным элементом с переданными данными
//		public void Insert(int key, int data)
//		{
//			var hashCode = GetHashCode(key);
//			var newItem = new RBNode(key, data);

//			// проверка дупликатов
//			if (items[hashCode].Find(key) != null)
//			{
//				Console.WriteLine("Ключ " + key + " уже есть в таблице");
//			}
//			else
//			{
//				items[hashCode].Insert(newItem);
//			}
//		}

//		// Входные данные: объект класса, целочисленный ключ
//		// Удаление элемента по заданному ключу
//		// Выходные данные: хеш-таблица без элемента с переданным ключом
//		public bool Remove(int key)
//		{
//			var hashCode = GetHashCode(key);
//			var itemsWithSameHashCode = items[hashCode];
//			RBNode keyThere = itemsWithSameHashCode.Find(key);

//			return itemsWithSameHashCode.Remove(keyThere);
//		}

//		// Входные данные: объект класса, целочисленный ключ
//		// Поиск данных элемента по заданному ключу
//		// Выходные данные: данные элемента с данным ключом
//		public int Search(int key)
//		{
//			var hashCode = GetHashCode(key);
//			var resultItem = items[hashCode].Find(key);
//			if (resultItem != null)
//			{
//				return items[hashCode].Find(key).Data;
//			}
//			else
//			{
//				Console.WriteLine("Элемента с ключом " + key + " не существует в таблице");
//				return -1;
//			}
//		}

//		// Входные данные: объект класса
//		// Очистка цепочек массива items
//		// Выходные данные: пустая хеш-таблица
//		public void Clear()
//		{
//			for (int i = 0; i < size; i++)
//			{
//				items[i].Clear();
//			}
//		}

//		// Входные данные: объект класса, ключ
//		// Хеш-функция - мультипликативная
//		// Выходные данные: целое число - хеш для ключа
//		private int GetHashCode(int key)
//		{
//			return (int)(size * (key * HASH_CONST % 1));
//		}

//	}
//}
