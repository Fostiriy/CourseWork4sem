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
	public partial class SearchMainRecordForm : Form
	{
		MainForm mainWindow;

		public SearchMainRecordForm()
		{
			InitializeComponent();
		}

		private void DateTreeRadioButton_CheckedChanged(object sender, EventArgs e)
		{
			dateTreeGroupBox.Enabled = !dateTreeGroupBox.Enabled;
		}

		private void SearchMainRecordForm_Load(object sender, EventArgs e)
		{
			mainWindow = (MainForm)Owner;
			mainWindow.mainGridRows = new DataGridViewRow[mainWindow.currentGrid.Rows.Count];
			mainWindow.currentGrid.Rows.CopyTo(mainWindow.mainGridRows, 0);
		}

		private void SearchRecordButton_Click(object sender, EventArgs e)
		{
			if (dateTreeGroupBox.Enabled)
			{
				string date1 = inputDateFromTimePicker.Text;
				string time1 = inputTimeFromTimePicker.Text;
				double key1 = mainWindow.ConvertToTreeKey($"{date1} {time1}");

				string date2 = inputDateToTimePicker.Text;
				string time2 = inputTimeToTimePicker.Text;
				double key2 = mainWindow.ConvertToTreeKey($"{date2} {time2}");

				if (key1 <= key2)
				{
					var nodesFound = mainWindow.dateTree.Search(key1, key2);

					if (nodesFound.Count != 0)
					{
						SingleLinkedList<int> indexes = new SingleLinkedList<int>();
						foreach (var node in nodesFound)
						{
							foreach (var row in node.Data)
							{
								indexes.PushBack(row.Index);
							}
						}

						mainWindow.currentGrid.Rows.Clear();
						foreach (var index in indexes)
						{
							mainWindow.currentGrid.Rows.Add(mainWindow.mainGridRows[index]);
						}

						mainWindow.showAllButton.Enabled = !mainWindow.showAllButton.Enabled;
						mainWindow.searchRecordButton.Enabled = !searchRecordButton.Enabled;
					}
					else
					{
						MessageBox.Show("Ничего не найдено.", "Результаты поиска", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}

				}
				else
				{
					MessageBox.Show("Неверно задан диапазон. Дата и время первой строки должны предшествовать дате и времени второй строки" +
						"или совпадать с ними.", "Ошибка в диапазоне", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}
	}
}
