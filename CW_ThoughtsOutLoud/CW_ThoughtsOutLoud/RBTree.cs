/* Красно-чёрное дерево с повторяющимися ключами. 
 * В элементе дерева хранится data: день 2 цифры, месяц 2 цифры.
 * При удалении брать min справа. 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_ThoughtsOutLoud
{
	public enum Colour // Перечислимый тип, отвечающий за цвет узла
	{
		Red, // Красный цвет
		Black // Чёрный цвет
	}

	public class RBNode<TKey, TData> where TKey:IComparable // Класс узла
	{
		// Поле цвета
		internal Colour color;
		// Поле-узел слева
		public RBNode<TKey, TData> left;
		// Поле-узел справа
		public RBNode<TKey, TData> right;
		// Поле-узел, являющийся родителем
		public RBNode<TKey, TData> parent;
		// Счётчик вставок узла с данным ключом в дерево
		public SingleLinkedList<TData> IndexesList { get; } = new SingleLinkedList<TData>();
		// Поле данных
		public TKey key;

		// Конструктор узла
		// Формальные параметры: ключ - числа day и month
		// Входные данные: пусто
		// Выходные данные: узел с заданным ключом
		public RBNode(TKey key)
		{
			this.key = key;
		}

		public RBNode(TKey key, TData data)
		{
			this.key = key;
			IndexesList.PushBack(data);
		}

		// Конструктор узла
		// Формальные параметры: цвет узла color
		// Входные данные: пусто
		// Выходные данные: узел с заданным цветом
		public RBNode(Colour color)
		{
			this.color = color;
		}

		// Проверяет, меньше ли ключ первого узла, чем ключ второго узла
		// Формальные параметры: узел node2
		// Входные данные: 2 узла
		// Выходные данные: True или False
		public bool IsLess(RBNode<TKey, TData> node2) => key.CompareTo(node2.key) < 0;

		// Проверяет, больше ли ключ первого узла, чем ключ второго узла
		// Формальные параметры: узел node2
		// Входные данные: 2 узла
		// Выходные данные: True или False
		public bool IsMore(RBNode<TKey, TData> node2) => key.CompareTo(node2.key) > 0;

		// Проверяет, равны ли ключи первого и второго узлов
		// Формальные параметры: узел node2
		// Входные данные: 2 узла
		// Выходные данные: True или False
		public bool IsEqual(RBNode<TKey, TData> node2) => key.CompareTo(node2.key) == 0;
	}

	class RB<TKey, TData> where TKey : IComparable
	{
		private RBNode<TKey, TData> root; // Узел-корень дерева
		private RBNode<TKey, TData> nil; // Пустой узел-лист дерева


		// Конструктор дерева
		// Формальные параметры: пусто
		// Входные данные: узлы root и nil
		// Выходные данные: инициализация чёрного узла nil, root = nil
		public RB()
		{
			nil = new RBNode<TKey, TData>(Colour.Black);
			nil.parent = nil;
			nil.left = nil;
			nil.right = nil;
			nil.key = default;
			root = nil;
		}

		// Удаляет все элементы дерева, освобождая память
		// Формальные параметры: пусто
		// Входные данные: дерево
		// Выходные данные: root = nil
		public void Clear()
		{
			Console.WriteLine("Clearing the tree.");
			while (root != nil)
				Delete(root);
			DisplayTree();
		}


		// Вращает дерево налево относительно узла
		// Формальные параметры: узел X
		// Входные данные: дерево
		// Выходные данные: дерево с изменёнными связями около X
		private void LeftRotate(RBNode<TKey, TData> X)
		{
			RBNode<TKey, TData> Y = X.right; // set Y
			X.right = Y.left; // turn Y's left subtree into X's right subtree

			if (Y.left != nil)
				Y.left.parent = X;

			if (Y != nil)
				Y.parent = X.parent; // link X's parent to Y

			if (X.parent == nil)
				root = Y;
			else if (X == X.parent.left)
				X.parent.left = Y;
			else
				X.parent.right = Y;

			Y.left = X; // put X on Y's left

			if (X != nil)
				X.parent = Y;
		}

		// Вращает дерево направо относительно узла
		// Формальные параметры: узел X
		// Входные данные: дерево
		// Выходные данные: дерево с изменёнными связями около X
		private void RightRotate(RBNode<TKey, TData> Y)
		{
			RBNode<TKey, TData> X = Y.left;
			Y.left = X.right;

			if (X.right != nil)
				X.right.parent = Y;

			if (X != nil)
				X.parent = Y.parent;

			if (Y.parent == nil)
				root = X;
			else if (Y == Y.parent.right)
				Y.parent.right = X;
			else
				Y.parent.left = X;

			X.right = Y; // put Y on X's right

			if (Y != nil)
				Y.parent = X;
		}

		// Нахождение узла с заданным ключом в дереве
		// Формальные параметры: поля структуры ключа day и month
		// Входные данные: дерево
		// Выходные данные: узел с заданным ключом
		public RBNode<TKey, TData> Find(TKey key, TData data)
		{
			bool isFound = false;
			RBNode<TKey, TData> temp = root;
			RBNode<TKey, TData> node = new RBNode<TKey, TData>(key);

			while (!isFound)
			{
				if (temp == nil)
					break;
				if (node.IsLess(temp))
					temp = temp.left;
				else if (node.IsMore(temp))
					temp = temp.right;
				else if (temp.IndexesList.Contains(data))
					isFound = true;
				else
					break;
			}

			if (isFound)
				return temp;
			else
				return nil;
		}

		// Нахождение узла с минимальным ключом в дереве
		// Формальные параметры: пусто
		// Входные данные: дерево
		// Выходные данные: узел с минимальным ключом
		public RBNode<TKey, TData> FindMinimum()
		{
			RBNode<TKey, TData> node = FindMinimum(root);
			Console.WriteLine("Minimal node {0} in the tree was found.", node.key);
			return node;
		}

		// Нахождение узла с минимальным ключом в поддереве
		// Формальные параметры: узел-корень node поддерева
		// Входные данные: дерево
		// Выходные данные: узел с минимальным ключом в поддереве
		public RBNode<TKey, TData> FindMinimum(RBNode<TKey, TData> node)
		{
			RBNode<TKey, TData> temp = node;

			if (temp == nil)
				return nil;

			while (temp.left != nil)
				temp = temp.left;

			return temp;
		}

		// Выводит значения полей узлов дерева на экран с учётом связей
		// Формальные параметры: пусто
		// Входные данные: дерево
		// Выходные данные: значения узлов дерева по порядку
		public void DisplayTree()
		{
			if (root == nil)
			{
				Console.WriteLine("The tree is empty.");
				return;
			}
			if (root != nil)
			{
				Display(root, 0);
				Console.WriteLine("____________________________________");
			}
		}

		// Выводит значения полей узлов поддерева на экран с учётом связей
		// Формальные параметры: узел-корень поддерева, число пробелов n
		// Входные данные: дерево
		// Выходные данные: значения узлов поддерева по порядку
		private void Display(RBNode<TKey, TData> current, int n)
		{
			if (current != nil)
			{
				Display(current.right, n + 1);

				for (int i = 0; i < n; i++)
					Console.Write("	");
				Console.Write("{0} ", current.key);
				if (current.color == Colour.Black)
					Console.WriteLine(" (B, {0})", current.IndexesList.Print());
				else
					Console.WriteLine(" (R, {0})", current.IndexesList.Print());

				Display(current.left, n + 1);
			}
		}

		// Выводит ключи узлов согласно прямому обходу дерева
		// Формальные параметры: пусто
		// Входные данные: дерево
		// Выходные данные: значения узлов дерева в порядке КЛП
		public void TraversalNLR()
		{
			Console.WriteLine("Pre-order NLR");
			TraversalNLR(root);
			if (root == nil)
				Console.WriteLine("Empty tree.");
			Console.WriteLine();
		}

		// Выводит ключи узлов согласно прямому обходу поддерева
		// Формальные параметры: узел-корень current поддерева
		// Входные данные: дерево
		// Выходные данные: значения узлов поддерева в порядке КЛП
		private void TraversalNLR(RBNode<TKey, TData> current)
		{
			if (current != nil)
			{
				Console.Write("{0} ", current.key);
				TraversalNLR(current.left);
				TraversalNLR(current.right);
			}
		}

		// Выводит ключи узлов согласно симметричному обходу дерева
		// Формальные параметры: пусто
		// Входные данные: дерево
		// Выходные данные: значения узлов дерева в порядке ЛКП
		public void TraversalLNR()
		{
			Console.WriteLine("In-order LNR");
			TraversalLNR(root);
			if (root == nil)
				Console.WriteLine("Empty tree.");
			Console.WriteLine();
		}

		// Выводит ключи узлов согласно симметричному обходу поддерева
		// Формальные параметры: узел-корень current поддерева
		// Входные данные: дерево
		// Выходные данные: значения узлов поддерева в порядке ЛКП
		private void TraversalLNR(RBNode<TKey, TData> current)
		{
			if (current != nil)
			{
				TraversalLNR(current.left);
				Console.Write("{0} ", current.key);
				TraversalLNR(current.right);
			}
		}

		// Выводит ключи узлов согласно обратному симметричному обходу дерева
		// Формальные параметры: пусто
		// Входные данные: дерево
		// Выходные данные: значения узлов дерева в порядке ПКЛ
		public void TraversalRNL()
		{
			Console.WriteLine("Reverse in-order RNL");
			TraversalRNL(root);
			if (root == nil)
				Console.WriteLine("Empty tree.");
			Console.WriteLine();
		}

		// Выводит ключи узлов согласно обратному симметричному обходу поддерева
		// Формальные параметры: узел-корень current поддерева
		// Входные данные: дерево
		// Выходные данные: значения узлов поддерева в порядке ПКЛ
		private void TraversalRNL(RBNode<TKey, TData> current)
		{
			if (current != nil)
			{
				TraversalRNL(current.right);
				Console.Write("{0} ", current.key);
				TraversalRNL(current.left);
			}
		}

		// Выводит ключи узлов согласно обратному обходу дерева
		// Формальные параметры: пусто
		// Входные данные: дерево
		// Выходные данные: значения узлов дерева в порядке ЛПК
		public void TraversalLRN()
		{
			Console.WriteLine("Post-order LRN");
			TraversalLRN(root);
			if (root == nil)
				Console.WriteLine("Empty tree.");
			Console.WriteLine();
		}

		// Выводит ключи узлов согласно обратному обходу поддерева
		// Формальные параметры: узел-корень current поддерева
		// Входные данные: дерево
		// Выходные данные: значения узлов поддерева в порядке ЛПК
		private void TraversalLRN(RBNode<TKey, TData> current)
		{
			if (current != nil)
			{
				TraversalLRN(current.left);
				TraversalLRN(current.right);
				Console.Write("{0} ", current.key);
			}
		}


		// Добавляет новый узел в дерево по правилу вставки в бинарное дерево
		// Формальные параметры: поля структуры ключа day и month
		// Входные данные: дерево
		// Выходные данные: дерево с новым узлом, удовлетворяющее свойствам КЧ дерева
		public void Insert(TKey key, TData data)
		{
			RBNode<TKey, TData> Z = new RBNode<TKey, TData>(key, data);
			RBNode<TKey, TData> Y = nil;
			RBNode<TKey, TData> X = root;

			while (X != nil)
			{
				Y = X;
				if (Z.IsEqual(X))
				{
					X.IndexesList.PushBack(data);
					return;
				}
				else if (Z.IsLess(X))
					X = X.left;
				else
					X = X.right;
			}
			Z.parent = Y;

			if (Y == nil)
				root = Z;
			else if (Z.IsLess(Y))
				Y.left = Z;
			else
				Y.right = Z;

			Z.left = nil;
			Z.right = nil;
			Z.color = Colour.Red; // colour the new node red

			InsertFixUp(Z); // call method to check for violations and fix
		}

		// Добавляет новый узел в дерево по правилу вставки в бинарное дерево и выводит дерево на экран
		// Формальные параметры: поля структуры ключа day и month
		// Входные данные: дерево
		// Выходные данные: дерево с новым узлом, удовлетворяющее свойствам КЧ дерева,
		//					и его изображение на экране
		public void InsertAndDisplay(TKey key, TData data)
		{
			Console.WriteLine("Inserting {0} with data {1}", key, data);
			this.Insert(key, data);
			this.DisplayTree();
		}

		// Проверяет, нарушены ли свойства КЧ дерева после вставки узла, и исправляет нарушения
		// Формальные параметры: вставленный узел Z
		// Входные данные: дерево
		// Выходные данные: дерево, удовлетворяющее свойствам КЧ дерева
		private void InsertFixUp(RBNode<TKey, TData> Z)
		{
			while (Z != root && Z.parent.color == Colour.Red)
			{
				if (Z.parent == Z.parent.parent.left)
				{
					RBNode<TKey, TData> Y = Z.parent.parent.right;

					if (Y.color == Colour.Red) // Case 1: uncle is red
					{
						Z.parent.color = Colour.Black;
						Y.color = Colour.Black;
						Z.parent.parent.color = Colour.Red;
						Z = Z.parent.parent;
					}

					else // Case 2: uncle is black
					{
						if (Z == Z.parent.right)
						{
							Z = Z.parent;
							LeftRotate(Z);
						}
						// Case 3: recolour & rotate
						Z.parent.color = Colour.Black;
						Z.parent.parent.color = Colour.Red;
						RightRotate(Z.parent.parent);
					}
				}
				else
				{
					RBNode<TKey, TData> X = Z.parent.parent.left;

					if (X.color == Colour.Red) // Case 1
					{
						Z.parent.color = Colour.Black;
						X.color = Colour.Black;
						Z.parent.parent.color = Colour.Red;
						Z = Z.parent.parent;
					}

					else // Case 2
					{
						if (Z == Z.parent.left)
						{
							Z = Z.parent;
							RightRotate(Z);
						}
						// Case 3 
						Z.parent.color = Colour.Black;
						Z.parent.parent.color = Colour.Red;
						LeftRotate(Z.parent.parent);
					}
				}
			}

			root.color = Colour.Black; // re-colour the root black as necessary
		}

		// Меняет поддеревья местами
		// Формальные параметры: узел X, узел Y
		// Входные данные: дерево
		// Выходные данные: дерево с изменёнными связями
		private void Transplant(RBNode<TKey, TData> X, RBNode<TKey, TData> Y)
		{
			if (X.parent == nil)
				root = Y;
			else if (X == X.parent.left)
				X.parent.left = Y;
			else
				X.parent.right = Y;

			Y.parent = X.parent;
		}

		// Удаляет узел из дерева по правилу удаления в бинарном дереве
		// Формальные параметры: поля структуры ключа day и month
		// Входные данные: дерево
		// Выходные данные: дерево без узла, удовлетворяющее свойствам КЧ дерева
		public void Delete(TKey key, TData data)
		{
			RBNode<TKey, TData> Z = Find(key, data);
			Delete(Z, data);
		}

		// Удаляет узел из дерева по правилу удаления в бинарном дереве или удаляет лишь индекс data
		// Формальные параметры: узел Z дерева
		// Входные данные: дерево
		// Выходные данные: дерево без узла, удовлетворяющее свойствам КЧ дерева
		public void Delete(RBNode<TKey, TData> Z, TData data)
		{
			RBNode<TKey, TData> Y = Z;
			RBNode<TKey, TData> X = nil;
			Colour SavedColor = Y.color;

			if (Z.IndexesList.Count > 1)
			{
				Z.IndexesList.Remove(data);
				return;
			}
			if (Z == nil)
			{
				Console.WriteLine("Nothing to delete!");
				return;
			}
			if (Z.left == nil)
			{
				X = Z.right;
				Transplant(Z, Z.right);
			}
			else if (Z.right == nil)
			{
				X = Z.left;
				Transplant(Z, Z.left);
			}
			else
			{
				Y = FindMinimum(Z.right);
				Console.WriteLine("Minimum {0} was found.", Y.key);
				if (Y == nil)
				{
					Console.WriteLine("Node does not have minimum.");
					return;
				}
				SavedColor = Y.color;
				X = Y.right;
				if (Y.parent == Z)
					X.parent = Y;
				else
				{
					Transplant(Y, Y.right);
					Y.right = Z.right;
					Y.right.parent = Y;
				}
				Transplant(Z, Y);

				Y.left = Z.left;
				Y.left.parent = Y;
				Y.color = Z.color;
			}

			if (SavedColor == Colour.Black)
				DeleteFixUp(X);
		}

		// Удаляет узел из дерева по правилу удаления в бинарном дереве
		// Формальные параметры: узел Z дерева
		// Входные данные: дерево
		// Выходные данные: дерево без узла, удовлетворяющее свойствам КЧ дерева
		public void Delete(RBNode<TKey, TData> Z)
		{
			RBNode<TKey, TData> Y = Z;
			RBNode<TKey, TData> X = nil;
			Colour SavedColor = Y.color;

			if (Z == nil)
			{
				Console.WriteLine("Nothing to delete!");
				return;
			}
			if (Z.left == nil)
			{
				X = Z.right;
				Transplant(Z, Z.right);
			}
			else if (Z.right == nil)
			{
				X = Z.left;
				Transplant(Z, Z.left);
			}
			else
			{
				Y = FindMinimum(Z.right);
				Console.WriteLine("Minimum {0} was found.", Y.key);
				if (Y == nil)
				{
					Console.WriteLine("Node does not have minimum.");
					return;
				}
				SavedColor = Y.color;
				X = Y.right;
				if (Y.parent == Z)
					X.parent = Y;
				else
				{
					Transplant(Y, Y.right);
					Y.right = Z.right;
					Y.right.parent = Y;
				}
				Transplant(Z, Y);

				Y.left = Z.left;
				Y.left.parent = Y;
				Y.color = Z.color;
			}

			if (SavedColor == Colour.Black)
				DeleteFixUp(X);
		}

		// Удаляет узел из дерева по правилу удаления в бинарном дереве
		// Формальные параметры: поля структуры ключа day и month
		// Входные данные: дерево
		// Выходные данные: дерево без узла, удовлетворяющее свойствам КЧ дерева,
		//					и его изображение на экране
		public void DeleteAndDisplay(TKey key, TData data)
		{
			Console.WriteLine("Deleting {0} with data {1}", key, data);
			this.Delete(key, data);
			this.DisplayTree();
		}

		// Проверяет, нарушены ли свойства КЧ дерева после удаления узла, и исправляет нарушения
		// Формальные параметры: текущий узел X
		// Входные данные: дерево
		// Выходные данные: дерево, удовлетворяющее свойствам КЧ дерева
		private void DeleteFixUp(RBNode<TKey, TData> X)
		{
			while (X != root && X.color == Colour.Black)
			{
				RBNode<TKey, TData> Y = X.parent;
				if (X == Y.left)
				{
					RBNode<TKey, TData> W = Y.right;

					if (W.color == Colour.Red)
					{
						W.color = Colour.Black; //case 1
						Y.color = Colour.Red;
						LeftRotate(Y);
						W = Y.right;
					}

					if (W.left.color == Colour.Black && W.right.color == Colour.Black)
					{
						W.color = Colour.Red; //case 2
						X = Y;
					}
					else
					{
						if (W.right.color == Colour.Black)
						{
							W.left.color = Colour.Black; //case 3
							W.color = Colour.Red;
							RightRotate(W);
							W = Y.right;
						}

						W.color = Y.color; //case 4
						Y.color = Colour.Black;
						W.right.color = Colour.Black;
						LeftRotate(Y);
						X = root;
					}
				}
				else //mirror code from above with "right" & "left" exchanged
				{
					RBNode<TKey, TData> W = Y.left;

					if (W.color == Colour.Red)
					{
						W.color = Colour.Black;
						Y.color = Colour.Red;
						RightRotate(Y);
						W = Y.left;
					}

					if (W.right.color == Colour.Black && W.left.color == Colour.Black)
					{
						W.color = Colour.Red;
						X = Y;
					}
					else
					{
						if (W.left.color == Colour.Black)
						{
							W.right.color = Colour.Black;
							W.color = Colour.Red;
							LeftRotate(W);
							W = Y.left;
						}

						W.color = Y.color;
						Y.color = Colour.Black;
						W.left.color = Colour.Black;
						RightRotate(Y);
						X = root;
					}
				}
			}

			X.color = Colour.Black;
		}

	}
}
