﻿using System;
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

		private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void NameDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

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
			MessageBox.Show("Файл сохранён");
		}

		private void AddRecordButton_Click(object sender, EventArgs e)
		{

		}

		private void ShowDebugButton_Click(object sender, EventArgs e)
		{

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