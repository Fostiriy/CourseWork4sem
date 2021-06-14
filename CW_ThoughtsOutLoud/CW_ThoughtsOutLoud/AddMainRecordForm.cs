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
	public partial class AddMainRecordForm : Form
	{
		MainForm mainWindow;

		public AddMainRecordForm()
		{
			InitializeComponent();
		}

		private void DateComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			string recordName = mainWindow.dateNameBook.Search(dateComboBox.Text).Data;
			nameTextBox.Text = recordName;
		}

		private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			string color = mainWindow.categoryColorBook.Search(categoryComboBox.Text).Data;
			colorTextBox.Text = color;
		}

		private void AddMainRecordForm_Load(object sender, EventArgs e)
		{
			mainWindow = (MainForm)Owner;
		}

		private void AddRecordButton_Click(object sender, EventArgs e)
		{
			var key1 = dateComboBox.Text;
			var data1 = nameTextBox.Text;
			var key2 = categoryComboBox.Text;
			var data2 = colorTextBox.Text;
			if (key1 != string.Empty && data1 != string.Empty
				&& key2 != string.Empty && data2 != string.Empty)
			{
				int gridIndex = mainWindow.currentGrid.Rows.Add(data1, key1, key2, data2);
				key1 = key1.Replace(" ", "");
				key1 = key1.Replace("\t", "");
				key1 = key1.Replace(".", "");
				key1 = key1.Replace(":", "");
				mainWindow.dateTree.Insert(double.Parse(key1), mainWindow.currentGrid.Rows[gridIndex]);
				mainWindow.ChangeDebugInfo(2);
			}
			else
			{
				MessageBox.Show("Присутствуют пустые поля! Запись не будет добавлена.", "Некорректные данные",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
