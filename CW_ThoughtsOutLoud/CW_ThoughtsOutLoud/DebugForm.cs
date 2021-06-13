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
	public partial class DebugForm : Form
	{
		MainForm mainWindow;

		public DebugForm()
		{
			InitializeComponent();
		}

		private void DebugForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			mainWindow.showDebugButton.Text = "Показать окно отладки";
		}

		private void DebugForm_Load(object sender, EventArgs e)
		{
			mainWindow = (MainForm)Owner;
		}

		private void DateNameBookRadioButton_CheckedChanged(object sender, EventArgs e)
		{
			debugInfoRichTextBox.Text = mainWindow.debugInfo[0];
		}

		private void CategoryColorBookRadioButton_CheckedChanged(object sender, EventArgs e)
		{
			debugInfoRichTextBox.Text = mainWindow.debugInfo[1];
		}

		private void DateTreeRadioButton_CheckedChanged(object sender, EventArgs e)
		{
			debugInfoRichTextBox.Text = mainWindow.debugInfo[2];
		}

		private void CategoryTreeRadioButton_CheckedChanged(object sender, EventArgs e)
		{
			debugInfoRichTextBox.Text = mainWindow.debugInfo[3];
		}

		private void DebugForm_Activated(object sender, EventArgs e)
		{
			if (dateNameBookRadioButton.Checked)
				debugInfoRichTextBox.Text = mainWindow.debugInfo[0];
			if (categoryColorBookRadioButton.Checked)
				debugInfoRichTextBox.Text = mainWindow.debugInfo[1];
			if (dateTreeRadioButton.Checked)
				debugInfoRichTextBox.Text = mainWindow.debugInfo[2];
			if (categoryTreeRadioButton.Checked)
				debugInfoRichTextBox.Text = mainWindow.debugInfo[3];
		}
	}
}
