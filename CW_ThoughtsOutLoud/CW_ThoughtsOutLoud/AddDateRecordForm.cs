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
			var key = inputDateTextBox.Text + " " + inputTimeTextBox.Text;
			var data = inputNameTextBox.Text;
			mainWindow.currentGrid.Rows.Add(data, key);
			mainWindow.dateNameBook.Insert(key, data);
			mainWindow.addMainRecordWindow.dateComboBox.Items.Add(key);
			mainWindow.ChangeDebugInfo(0);
		}

		private void AddDateRecordForm_Load(object sender, EventArgs e)
		{
			mainWindow = (MainForm)Owner;
		}
	}
}
