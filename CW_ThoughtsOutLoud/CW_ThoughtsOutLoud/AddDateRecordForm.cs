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

		private bool IsDateCorrect(string date)
		{
			bool result = false;

			if (!date.Contains(' '))
			{
				string[] components = date.Split('.');
				int day = int.Parse(components[0]);
				int month = int.Parse(components[1]);
				int year = int.Parse(components[2]);
				if (day >= 1 && day <= 31)
				{
					if (month >= 1 && month <= 12)
					{
						if (year >= 1900 && month <= 2021)
						{
							result = true;
						}
					}
				}
			}

			return result;
		}

		private bool IsTimeCorrect(string time)
		{
			bool result = false;

			if (!time.Contains(' '))
			{
				string[] components = time.Split(':');
				int hours = int.Parse(components[0]);
				int minutes = int.Parse(components[1]);
				int seconds = int.Parse(components[2]);
				if (hours >= 0 && hours <= 23)
				{
					if (minutes >= 0 && minutes <= 59)
					{
						if (seconds >= 0 && seconds <= 59)
						{
							result = true;
						}
					}
				}
			}

			return result;
		}

		private void AddRecordButton_Click(object sender, EventArgs e)
		{
			string name = inputNameTextBox.Text.Trim();
			string date = inputDateTextBox.Text;
			string time = inputTimeTextBox.Text;

			if (name != string.Empty && IsDateCorrect(date) && IsTimeCorrect(time))
			{
				string key = date + " " + time;

				if (mainWindow.dateNameBook.Insert(key, name))
				{
					mainWindow.currentGrid.Rows.Add(name, key);
					mainWindow.addMainRecordWindow.dateComboBox.Items.Add(key);
					mainWindow.ChangeDebugInfo(0);
				}
				else
				{
					MessageBox.Show("Запись с таким ключом уже есть в справочнике", "Повторное добавление",
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
