using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace CW_ThoughtsOutLoud
{
	public partial class MainForm : Form
	{
		internal HashTable<string, string> nameDateBook = new HashTable<string, string>(8);
		internal HashTable<string, string> categoryColorBook = new HashTable<string, string>(8);
		RBTree<double, DataGridViewRow> dateTree = new RBTree<double, DataGridViewRow>();

		AddMainRecordForm addMainRecordWindow = new AddMainRecordForm();
		AddDateRecordForm addRecordWindow = new AddDateRecordForm();
		DebugForm debugWindow;

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
			var dialogResult = addMainRecordWindow.ShowDialog();
			string key, data, key2, data2;

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
						key = addMainRecordWindow.dateComboBox.Text;
						data = addMainRecordWindow.nameTextBox.Text;
						key2 = addMainRecordWindow.categoryComboBox.Text;
						data2 = addMainRecordWindow.colorTextBox.Text;
						// нормальное имя придумай
						int index = currentGrid.Rows.Add(data, key, key2, data2);
						key = key.Replace(" ", "");
						key = key.Replace("\t", "");
						key = key.Replace(".", "");
						key = key.Replace(":", "");
						dateTree.Insert(double.Parse(key), currentGrid.Rows[index]);
						break;
					case 1:
						currentGrid = dateNameGrid;
						//currentGrid.Rows.Add(data, key);
						//nameDateBook.Insert(key, data);
						//addMainRecordWindow.dateComboBox.Items.Add(key);
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
			nameDateBook.Clear();
			dateNameGrid.Rows.Clear();
		}

		private void MainForm_LocationChanged(object sender, EventArgs e)
		{
			if (debugWindow != null)
				debugWindow.Location = new Point(Location.X + Size.Width, Location.Y);
		}
	}
}
