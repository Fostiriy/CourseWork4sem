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

		public void FillDateNameBook(HashTable<string, string> HT, string path)
		{
			FileInfo inputFile = new FileInfo(path);

			using (StreamReader istream = inputFile.OpenText())
			{
				while (!istream.EndOfStream)
				{
					string[] info = istream.ReadLine().Split('|');
					string data = info[0].Trim('\t', ' ');
					string key = info[1] + " " + info[2];

					addMainRecordWindow.dateComboBox.Items.Add(key);

					dateNameGrid.Rows.Add(data, key);
					HT.Insert(key, data);
				}
			}
		}

		public void RedrawGrid(DataGridView grid, HashTable<string, string> HT)
		{

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
			FillDateNameBook(dateNameBook, openFileDialog.FileName);
		}

		private void SaveFileButton_Click(object sender, EventArgs e)
		{
			if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
				return;
			// получаем выбранный файл
			string filename = saveFileDialog.FileName;
			// сохраняем текст в файл
			string infoHT = String.Join('\n', dateNameBook.Info());
			File.WriteAllText(filename, infoHT);

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
			debugInfo[0] += "Хеш-таблицао времени записи.\nКлюч: (string) дата время.\nЗначение: (string) имя аудиозаписи.\n" +
				"Метод разрешения коллизий: открытая линейная адресация.\n";
			debugInfo[1] += "Хеш-таблица о категориях аудиозаписей.\nКлюч: (string) название категории.\nЗначение: (string) цвет категории.\n" +
				"Метод разрешения коллизий: метод цепочек.\n";
			debugInfo[2] += "Красно-чёрное двоичное дерево.\nПоиск: диапазон дат.\nКлюч: (double) дата время.\n";
			debugInfo[3] += "АВЛ двоичное дерево.\nПоиск: категории в алфавитном порядке.\nКлюч: (string) название категории.\n";
		}
	}
}
