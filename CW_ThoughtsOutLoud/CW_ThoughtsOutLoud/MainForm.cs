using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CW_ThoughtsOutLoud
{
	public partial class MainForm : Form
	{
		HashTable<string, string> nameDateBook = new HashTable<string, string>(8);
		string currentFileName;

		public void FillHT(HashTable<string, string> HT, string path)
		{
			FileInfo inputFile = new FileInfo(path);

			using (StreamReader istream = inputFile.OpenText())
			{
				while (!istream.EndOfStream)
				{
					string[] info = istream.ReadLine().Split('|');
					string data = info[0].Trim('\t', ' ');
					string key = info[1] + info[2];
					key = key.Replace("\t", "");
					key = key.Replace(".", "");
					key = key.Replace(":", "");

					HT.Insert(key, data);
				}
			}
		}


		public MainForm()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		// Открытие файла
		private void button1_Click(object sender, EventArgs e)
		{
			if (openFileDialog.ShowDialog() == DialogResult.Cancel)
				return;
			// получаем выбранный файл
			currentFileName = openFileDialog.FileName;
			FillHT(nameDateBook, currentFileName);
		}

		private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void nameDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		// Запись в файл
		private void saveFileButton_Click(object sender, EventArgs e)
		{
			if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
				return;
			// получаем выбранный файл
			string filename = saveFileDialog.FileName;
			// сохраняем текст в файл
			File.WriteAllText(filename, nameDateBook.Info());
			MessageBox.Show("Файл сохранён");
		}
	}
}
