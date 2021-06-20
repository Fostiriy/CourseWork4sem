using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CW_ThoughtsOutLoud
{
	public partial class SearchDateRecordForm : Form
	{
		MainForm mainWindow;

		public SearchDateRecordForm()
		{
			InitializeComponent();
		}

		private void SearchRecordButton_Click(object sender, EventArgs e)
		{
			string date = inputDateTimePicker.Text;
			string time = inputTimeTimePicker.Text;
			string key = $"{date} {time}";
			var foundNode = mainWindow.dateNameBook.Search(key);
			if (foundNode != null)
			{
				searchInfoRichTextBox.Text = $"Запись была найдена!\nЕё значение: {foundNode.Data}.\n";
				searchInfoRichTextBox.Text += $"Количество сравнений при поиске: {mainWindow.dateNameBook.ComparisonsNumber}.\n";
				int rowFoundIndex = -1;
				foreach (DataGridViewRow row in mainWindow.currentGrid.Rows)
				{
					if (row.Cells[1].Value.ToString() == key)
					{
						rowFoundIndex = row.Index;
					}
				}
				if (rowFoundIndex != -1)
				{
					mainWindow.currentGrid.Rows[rowFoundIndex].Selected = true;
				}
			}
			else
			{
				searchInfoRichTextBox.Text = "Записи с таким ключом нет в справочнике.\n";
				searchInfoRichTextBox.Text += $"Количество сравнений при поиске: {mainWindow.dateNameBook.ComparisonsNumber}.\n";
			}
		}

		private void SearchDateRecordForm_Load(object sender, EventArgs e)
		{
			mainWindow = (MainForm)Owner;
		}
	}
}
