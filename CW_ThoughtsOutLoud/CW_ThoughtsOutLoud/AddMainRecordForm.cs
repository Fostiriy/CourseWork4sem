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

		private void dateComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			string recordName = mainWindow.nameDateBook.Search(dateComboBox.Text).Data;
			nameTextBox.Text = recordName;
		}

		private void categoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			string recordName = mainWindow.categoryColorBook.Search(dateComboBox.Text).Data;
			nameTextBox.Text = recordName;
		}

		private void AddMainRecordForm_Load(object sender, EventArgs e)
		{
			mainWindow = (MainForm)Owner;
		}
	}
}
