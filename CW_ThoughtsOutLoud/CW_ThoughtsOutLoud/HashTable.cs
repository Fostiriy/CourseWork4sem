using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_ThoughtsOutLoud
{
	// Класс узла ХТ
	public class HTNode<TKey, TData> where TKey : IComparable
	{
		// Ключ - натуральное число
		public TKey Key;
		// Данные - целочисленное число
		public TData Data;
		// Метка, отвечающая за то, был ли элемент удалён
		public bool wasDeleted = false;

		// Входные данные: целочислленый ключ, число-данные
		// Конструктор
		// Выходные данные: объект класса с данными ключом и данными
		public HTNode(TKey key, TData data)
		{
			Key = key;
			Data = data;
		}
	}

	// Класс ХТ
	public class HashTable<TKey, TData> where TKey : IComparable
	{
		// Константа для хеш-функции
		private const double HASH_CONST = 0.6180339887;
		// Массив элементов
		private HTNode<TKey, TData>[] items;
		// Размер хеш-таблицы (длина массива items)
		public int Size { get; private set; }
		

		// Входные данные: размер хеш-таблицы
		// Конструктор по размеру
		// Выходные данные: хеш-таблица с заданной размерностью
		public HashTable(int size)
		{
			Size = size;
			items = new HTNode<TKey, TData>[Size];
		}

		// Входные данные: объект класса
		// Очистка цепочек массива items
		// Выходные данные: пустая хеш-таблица
		public void Clear() => items = new HTNode<TKey, TData>[8];


		// Входные данные: объект класса
		// Метод, возвращающий строку с информацией о таблице
		// Выходные данные: строка с информацией о всех элементах таблицы
		public string InfoToFile()
		{
			string result = string.Empty;

			for (int i = 0; i < Size; i++)
			{
				if (items[i] != null && !items[i].wasDeleted)
				{
					result += $"{items[i].Data, -50} |{items[i].Key}\n";
				}
			}

			return result;
		}

		public string[] Info()
		{
			string[] result = new string[Size];
			int k = 0;

			for (int i = 0; i < Size; i++)
			{
				if (items[i] != null && !items[i].wasDeleted)
				{
					result[k] = $"Значение: {items[i].Data}\n" +
						$"Ключ: {items[i].Key,-14} ({ConvertToNumber(items[i].Key)})\n" +
						$"Хеш 1: {GetHashCode(items[i].Key)}\n" +
						$"Хеш 2: {i}\n";
					k++;
				}
			}

			return result;
		}

		private void Rehash(int newSize)
		{
			int oldSize = Size;
			var oldItems = items;
			Size = newSize;
			items = new HTNode<TKey, TData>[Size];

			for (int i = 0; i < oldSize; i++)
			{
				if (oldItems[i] != null && !oldItems[i].wasDeleted)
				{
					Insert(oldItems[i]);
				}
			}
		}

		private void Rehash() => Rehash(Size);

		// Входные данные: объект класса, целочисленный ключ, целое число-данные
		// Вставка элемента с заданным ключом и заданными данными
		// Выходные данные: хеш-таблица с вставленным элементом с переданными данными
		public void Insert(TKey key, TData data)
		{
			var hashCode = GetHashCode(key);
			var newItem = new HTNode<TKey, TData>(key, data);

			// проверка дупликатов
			if (items[hashCode] == null || items[hashCode].wasDeleted)
			{
				items[hashCode] = newItem;
			}
			else if (items[hashCode].Key.Equals(newItem.Key))
			{
				Console.WriteLine("Ключ " + key + " уже есть в таблице");
			}
			else
			{
				for (int i = hashCode; i < Size; i++)
				{
					if (items[i] == null || items[hashCode].wasDeleted)
					{
						items[i] = newItem;
						return;
					}
				}
				for (int i = 0; i < hashCode; i++)
				{
					if (items[i] == null || items[hashCode].wasDeleted)
					{
						items[i] = newItem;
						return;
					}
				}
				Rehash(Size * 2);
				Insert(key, data);
			}
		}

		private void Insert(HTNode<TKey, TData> item)
		{
			var hashCode = GetHashCode(item.Key);

			// проверка дупликатов
			if (items[hashCode] == null || items[hashCode].wasDeleted)
			{
				items[hashCode] = item;
			}
			else if (items[hashCode].Key.Equals(item.Key))
			{
				Console.WriteLine("Ключ " + item.Key + " уже есть в таблице");
			}
			else
			{
				for (int i = hashCode; i < Size; i++)
				{
					if (items[i] == null || items[hashCode].wasDeleted)
					{
						items[i] = item;
						return;
					}
				}
				for (int i = 0; i < hashCode; i++)
				{
					if (items[i] == null || items[hashCode].wasDeleted)
					{
						items[i] = item;
						return;
					}
				}
				Rehash(Size * 2);
				Insert(item);
			}
		}

		// Входные данные: объект класса, целочисленный ключ
		// Удаление элемента по заданному ключу
		// Выходные данные: хеш-таблица без элемента с переданным ключом
		public bool Remove(TKey key)
		{
			var keyToRemove = Search(key);

			if (keyToRemove == null)
			{
				return false;
			}
			else
			{
				keyToRemove.wasDeleted = true;
				return true;
			}
		}

		// Входные данные: объект класса, целочисленный ключ
		// Поиск данных элемента по заданному ключу
		// Выходные данные: данные элемента с данным ключом
		public HTNode<TKey, TData> Search(TKey key)
		{
			var hashCode = GetHashCode(key);
			HTNode<TKey, TData> result = null;

			if (items[hashCode] == null)
			{
				Console.WriteLine("Элемента с ключом {0} нет в массиве", key);
			}
			else if (items[hashCode].Key.Equals(key))
			{
				return items[hashCode];
			}
			else
			{
				for (int i = hashCode; i < Size; i++)
				{
					if (items[i] == null)
						return result;
					if (items[i].Key.Equals(key))
					{
						if (!items[i].wasDeleted)
							result = items[i];
						return result;
					}
				}
				if (result == null)
				{
					for (int i = 0; i < hashCode; i++)
					{
						if (items[i] == null)
							return result;
						if (items[i].Key.Equals(key))
						{
							if (!items[i].wasDeleted)
								result = items[i];
							return result;
						}
					}
				}
			}

			return result;
		}

		private double ConvertToNumber(TKey key)
		{
			double result = 0;
			string keyString = key.ToString();

			foreach (char symbol in keyString)
				result += symbol;

			return result;
		}

		// Входные данные: объект класса, ключ
		// Хеш-функция - мультипликативная
		// Выходные данные: целое число - хеш для ключа
		private int GetHashCode(TKey key)
		{
			return (int)(Size * (ConvertToNumber(key) * HASH_CONST % 1));
		}

	}
}
