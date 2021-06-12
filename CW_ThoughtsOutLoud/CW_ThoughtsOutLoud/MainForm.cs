using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace CW_ThoughtsOutLoud
{
	public partial class MainForm : Form
	{
		internal HashTable<string, string> dateNameBook = new HashTable<string, string>(8);
		internal HashTable<string, string> categoryColorBook = new HashTable<string, string>(8);
		internal RBTree<double, DataGridViewRow> dateTree = new RBTree<double, DataGridViewRow>();
		internal string[] debugInfo = new string[4];
		internal DataGridView currentGrid;

		internal AddMainRecordForm addMainRecordWindow = new AddMainRecordForm();
		internal AddDateRecordForm addDateRecordWindow = new AddDateRecordForm();
		internal AddCategoryRecordForm addCategoryRecordWindow = new AddCategoryRecordForm();
		DebugForm debugWindow;

		private void FillDateNameBook(HashTable<string, string> HT, string path)
		{
			FileInfo inputFile = new FileInfo(path);

			using (StreamReader istream = inputFile.OpenText())
			{
				while (!istream.EndOfStream)
				{
					string[] info = istream.ReadLine().Split('|');
					string data = info[0].Trim('\t', ' ');
					string key = info[1];

					addMainRecordWindow.dateComboBox.Items.Add(key);

					dateNameGrid.Rows.Add(data, key);
					HT.Insert(key, data);
				}
			}
			debugInfo[0] += String.Join('\n',HT.Info());
		}

		public MainForm()
		{
			InitializeComponent();
			addMainRecordWindow.Owner = this;
			addDateRecordWindow.Owner = this;
		}

		private void OpenFileButton_Click(object sender, EventArgs e)
		{
			if (openFileDialog.ShowDialog() == DialogResult.Cancel)
				return;
			dateNameGrid.Rows.Clear();
			FillDateNameBook(dateNameBook, openFileDialog.FileName);
		}

		private void SaveFileButton_Click(object sender, EventArgs e)
		{
			if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
				return;
			string filename = saveFileDialog.FileName;
			File.WriteAllText(filename, dateNameBook.InfoToFile());

			MessageBox.Show("Файл сохранён!", "Сохранение файла", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void AddRecordButton_Click(object sender, EventArgs e)
		{
			Form currentWindow = null;
			switch (booksTabControl.SelectedIndex)
			{
				case 0:
					currentGrid = mainGrid;
					currentWindow = addMainRecordWindow;
					break;
				case 1:
					currentGrid = dateNameGrid;
					currentWindow = addDateRecordWindow;
					break;
				case 2:
					currentGrid = categoryColorGrid;
					currentWindow = addCategoryRecordWindow;
					break;
				default: break;
			}
			currentWindow.ShowDialog();
		}

		private void ShowDebugButton_Click(object sender, EventArgs e)
		{
			if (showDebugButton.Text == "Показать окно отладки")
			{
				debugWindow = new DebugForm();
				debugWindow.Owner = this;
				debugWindow.StartPosition = FormStartPosition.Manual;
				debugWindow.Location = new Point(Location.X + Size.Width, Location.Y);
				debugWindow.Show();
				showDebugButton.Text = "Скрыть окно отладки";
			}
			else if (showDebugButton.Text == "Скрыть окно отладки")
			{
				debugWindow.Close();
			}
		}

		private void DeleteRecordButton_Click(object sender, EventArgs e)
		{
			DataGridViewRow currentRow = null;
			DialogResult result = DialogResult.Yes;
			double keyDate = 0;
			string keyCategory = string.Empty;

			switch (booksTabControl.SelectedIndex)
			{
				case 0:
					currentGrid = mainGrid;
					currentRow = currentGrid.CurrentRow;
					break;
				case 1:
					currentGrid = dateNameGrid;
					currentRow = currentGrid.CurrentRow;
					if (currentRow != null)
					{
						string date = currentRow.Cells[1].Value.ToString();
						date = date.Replace(" ", "");
						date = date.Replace(".", "");
						date = date.Replace(":", "");
						keyDate = double.Parse(date);
					}
					break;
				case 2:
					currentGrid = categoryColorGrid;
					currentRow = currentGrid.CurrentRow;

					// добавить обработку для keyCategory

					break;
				default: break;
			}

			if (keyDate != 0 && dateTree.Find(keyDate) != dateTree.Nil)
			{
				result = MessageBox.Show("В основном справочнике содержатся записи, связанные с записью, которую вы хотите удалить.\n" +
					"Всё равно удалить?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
				if (result == DialogResult.Yes)
				{
					string date = currentRow.Cells[0].Value.ToString();
					dateNameBook.Remove(date);
					SingleLinkedList<DataGridViewRow> deletedIndexes = dateTree.Delete(keyDate);
					foreach (DataGridViewRow row in deletedIndexes)
					{
						mainGrid.Rows.RemoveAt(row.Index);
					}
				}
			}

			if (result == DialogResult.Yes)
			{
				if (currentRow != null)
				{
					currentGrid.Rows.RemoveAt(currentGrid.CurrentRow.Index);
				}
				else
				{
					MessageBox.Show("Необходимо выбрать строку для удаления в таблице!",
						"Не выбрана строка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void SearchRecordButton_Click(object sender, EventArgs e)
		{

		}

		private void NewBookButton_Click(object sender, EventArgs e)
		{
			dateNameBook.Clear();
			dateNameGrid.Rows.Clear();
		}

		private void MainForm_LocationChanged(object sender, EventArgs e)
		{
			if (debugWindow != null)
				debugWindow.Location = new Point(Location.X + Size.Width, Location.Y);
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			debugInfo[0] += "Хеш-таблица о времени записи.\nКлюч: (string) дата время.\nЗначение: (string) имя аудиозаписи.\n" +
				"Метод разрешения коллизий: открытая линейная адресация.\n";
			debugInfo[1] += "Хеш-таблица о категориях аудиозаписей.\nКлюч: (string) название категории.\nЗначение: (string) цвет категории.\n" +
				"Метод разрешения коллизий: метод цепочек.\n";
			debugInfo[2] += "Красно-чёрное двоичное дерево.\nПоиск: диапазон дат.\nКлюч: (double) дата время.\n";
			debugInfo[3] += "АВЛ двоичное дерево.\nПоиск: категории в алфавитном порядке.\nКлюч: (string) название категории.\n";
		}
	}
}
