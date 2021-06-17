using System;

namespace CW_ThoughtsOutLoud
{
	// Класс элемента ХТ
	public class HTNode<TKey, TData> where TKey : IComparable
	{
		// Ключ узла
		public TKey Key;
		// Значение узла
		public TData Data;
		// Метка, отвечающая за то, был ли элемент удалён
		public bool wasDeleted = false;

		// Конструктор узла по ключу и значению
		// Формальные параметры: ключ key, значение data
		// Входные данные: пусто
		// Выходные данные: объект класса
		public HTNode(TKey key, TData data)
		{
			Key = key;
			Data = data;
		}
	}

	// Класс ХТ с методом открытой адресации, линейное зондирование
	public class HashTable<TKey, TData> where TKey : IComparable
	{
		// Константа для хеш-функции
		private const double HASH_CONST = 0.6180339887;
		// Массив элементов
		private HTNode<TKey, TData>[] items;
		// Размер хеш-таблицы (длина массива items)
		public int Size { get; private set; }
		// Счётчик сравнений при поиске
		public int ComparisonsNumber { get; private set; }

		// Конструктор по размеру
		// Формальные параметры: размер хеш-таблицы size
		// Входные данные: пусто
		// Выходные данные: хеш-таблица с заданной размерностью
		public HashTable(int size)
		{
			Size = size;
			items = new HTNode<TKey, TData>[Size];
		}

		// Создание нового массива items размера 8
		// Формальные параметры: пусто
		// Входные данные: хеш-таблица
		// Выходные данные: пустая хеш-таблица
		public void Clear()
		{
			Size = 8;
			items = new HTNode<TKey, TData>[Size];
		}


		// Вывод информации об элементах хеш-таблицы в строку
		// с разделителями для работы в проекте
		// Формальные параметры: пусто
		// Входные данные: хеш-таблица
		// Выходные данные: хеш-таблица, строка
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

		// Вывод информации об элементах хеш-таблицы в массив строк
		// Формальные параметры: пусто
		// Входные данные: хеш-таблица
		// Выходные данные: хеш-таблица, массив строк
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
						$"Индекс: {i}\n" +
						$"Хеш: {GetHashCode(items[i].Key)}\n";
					k++;
				}
			}

			return result;
		}

		// Рехеширование таблицы с изменением размера
		// Формальные параметры: размер таблицы newSize
		// Входные данные: хеш-таблица
		// Выходные данные: хеш-таблица
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

		// Рехеширование таблицы без изменения размера
		// Формальные параметры: пусто
		// Входные данные: хеш-таблица
		// Выходные данные: хеш-таблица
		private void Rehash() => Rehash(Size);

		// Вставка элемента с заданным ключом и заданным значением
		// Формальные параметры: ключ key, значение data
		// Входные данные: хеш-таблица
		// Выходные данные: хеш-таблица
		public bool Insert(TKey key, TData data)
		{
			var newItem = new HTNode<TKey, TData>(key, data);
			return Insert(newItem);
		}

		// Вставка переданного элемента
		// Формальные параметры: элемент хеш-таблицы item
		// Входные данные: хеш-таблица
		// Выходные данные: хеш-таблица
		private bool Insert(HTNode<TKey, TData> item)
		{
			bool result = true;

			var hashCode = GetHashCode(item.Key);

			if (items[hashCode] == null || items[hashCode].wasDeleted)
			{
				items[hashCode] = item;
			}
			else if (items[hashCode].Key.Equals(item.Key))
			{
				Console.WriteLine("Ключ " + item.Key + " уже есть в таблице");
				result = false;
			}
			else
			{
				for (int i = hashCode + 1; i < Size; i++)
				{
					if (items[i] == null || items[i].wasDeleted)
					{
						items[i] = item;
						return result;
					}
				}
				for (int i = 0; i < hashCode; i++)
				{
					if (items[i] == null || items[i].wasDeleted)
					{
						items[i] = item;
						return result;
					}
				}
				Rehash(Size * 2);
				Insert(item);
			}

			return result;
		}

		// Удаление элемента по заданному ключу и возвращения информации,
		// был ли удалён элемент
		// Формальные параметры: ключ key
		// Входные данные: хеш-таблица
		// Выходные данные: хеш-таблица,
		// в зависимости от успеха удаления True или False
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

		// Поиск данных элемента по заданному ключу
		// Формальные параметры: ключ key
		// Входные данные: хеш-таблица
		// Выходные данные: элемент хеш-таблицы, содержащий заданный ключ
		public HTNode<TKey, TData> Search(TKey key)
		{
			ComparisonsNumber = 0;
			var hashCode = GetHashCode(key);
			HTNode<TKey, TData> result = null;

			if (items[hashCode] == null)
			{
				Console.WriteLine("Элемента с ключом {0} нет в массиве", key);
			}
			else if (items[hashCode].Key.Equals(key))
			{
				ComparisonsNumber++;
				return items[hashCode];
			}
			else
			{
				for (int i = hashCode + 1; i < Size; i++)
				{
					ComparisonsNumber++;
					if (items[i] == null)
						return result;
					if (items[i].Key.Equals(key))
					{
						if (!items[i].wasDeleted)
							result = items[i];
						return result;
					}
				}
				for (int i = 0; i < hashCode; i++)
				{
					ComparisonsNumber++;
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

			return result;
		}

		// Преобразование ключа в число типа double
		// Формальные параметры: ключ key
		// Входные данные: хеш-таблица
		// Выходные данные: вещественное число - представление ключа
		private double ConvertToNumber(TKey key)
		{
			double result = 0;
			string keyString = key.ToString();

			foreach (char symbol in keyString)
				result += symbol;

			return result;
		}

		// Вычисление мультипликативной хеш-функции для переданного ключа
		// Формальные параметры: ключ key
		// Входные данные: хеш-таблица
		// Выходные данные: целое число - хеш для ключа
		private int GetHashCode(TKey key)
		{
			return (int)(Size * (ConvertToNumber(key) * HASH_CONST % 1));
		}

	}
}
