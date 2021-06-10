using System;
using System.IO;
using System.Windows.Forms;

namespace CW_ThoughtsOutLoud
{
	public partial class MainForm : Form
	{
		HashTable<string, string> nameDateBook = new HashTable<string, string>(8);
		HashTable<string, string> categoryColorBook = new HashTable<string, string>(8);
		RBTree<double, DataGridView> dateTree = new RBTree<double, DataGridView>();

		public void FillHT(HashTable<string, string> HT, string path)
		{
			FileInfo inputFile = new FileInfo(path);

			using (StreamReader istream = inputFile.OpenText())
			{
				while (!istream.EndOfStream)
				{
					string[] info = istream.ReadLine().Split('|');
					string data = info[0].Trim('\t', ' ');
					string key = info[1] + " " + info[2];

					nameDateGrid.Rows.Add(data, key);

					key = key.Replace(" ", "");
					key = key.Replace("\t", "");
					key = key.Replace(".", "");
					key = key.Replace(":", "");
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
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		// Открытие файла
		private void OpenFileButton_Click(object sender, EventArgs e)
		{
			if (openFileDialog.ShowDialog() == DialogResult.Cancel)
				return;
			// получаем выбранный файл
			FillHT(nameDateBook, openFileDialog.FileName);
		}

		// Запись в файл
		private void SaveFileButton_Click(object sender, EventArgs e)
		{
			if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
				return;
			// получаем выбранный файл
			string filename = saveFileDialog.FileName;
			// сохраняем текст в файл
			string infoHT = String.Join('\n', nameDateBook.Info());
			File.WriteAllText(filename, infoHT);

			MessageBox.Show("Файл сохранён!", "Сохранение файла", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void AddRecordButton_Click(object sender, EventArgs e)
		{
			//AddRecordForm addRecordWindow = new AddRecordForm();
			//var dialogResult = addRecordWindow.ShowDialog();
			AddMainRecordForm addMainRecordWindow = new AddMainRecordForm();
			var dialogResult = addMainRecordWindow.ShowDialog();
			string key, data;

			if (dialogResult == DialogResult.OK)
			{
				// Вообще добавь проверку данных

				//key = addRecordWindow.inputDateTextBox.Text + " " + addRecordWindow.inputTimeTextBox.Text;
				//data = addRecordWindow.inputNameTextBox.Text;



				DataGridView currentGrid;
				switch (booksTabControl.SelectedIndex)
				{
					case 0:
						currentGrid = mainGrid;

						break;
					case 1:
						currentGrid = nameDateGrid;
						currentGrid.Rows.Add(data, key);
						key = key.Replace(" ", "");
						key = key.Replace(".", "");
						key = key.Replace(":", "");
						nameDateBook.Insert(key, data);
						break;
					case 2:
						currentGrid = categoryColorGrid;
						break;
					default: break;
				}
			}
			// Описать другие результаты диалога
			
		}

		private void ShowDebugButton_Click(object sender, EventArgs e)
		{
			DebugForm debugWindow = new DebugForm();
			debugWindow.Show();

		}

		private void DeleteRecordButton_Click(object sender, EventArgs e)
		{

		}

		private void SearchRecordButton_Click(object sender, EventArgs e)
		{

		}

		private void NewBookButton_Click(object sender, EventArgs e)
		{
			nameDateBook.Clear();
			nameDateGrid.Rows.Clear();
		}
	}
}
