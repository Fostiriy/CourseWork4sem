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
	public partial class AddDateRecordForm : Form
	{
		MainForm mainWindow;

		public AddDateRecordForm()
		{
			InitializeComponent();
		}

		private void AddRecordButton_Click(object sender, EventArgs e)
		{
			string name = inputNameTextBox.Text.Trim();
			string date = inputDateTimePicker.Text;
			string time = inputTimeTimePicker.Text;

			if (name != string.Empty)
			{
				string key = $"{date} {time}";

				if (mainWindow.dateNameBook.Insert(key, name))
				{
					mainWindow.currentGrid.Rows.Add(name, key);
					mainWindow.addMainRecordWindow.dateComboBox.Items.Add(key);
					mainWindow.ChangeDebugInfo(0);
				}
				else
				{
					MessageBox.Show("Запись с таким ключом уже есть в справочнике.", "Повторное добавление",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			else
			{
				MessageBox.Show("Ошибка в введённых данных! Запись не будет добавлена.", "Некорректные данные",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void AddDateRecordForm_Load(object sender, EventArgs e)
		{
			mainWindow = (MainForm)Owner;
		}

		private void InputNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
		{
			char symbol = e.KeyChar;
			if (!Char.IsLetterOrDigit(symbol) 
				&& !Char.IsPunctuation(symbol) 
				&& symbol != 8 && symbol != ' ' || symbol == '|')
			{
				e.Handled = true;
			}
		}
	}
}
