
namespace CW_ThoughtsOutLoud
{
	partial class DebugForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DebugForm));
			this.splitContainer = new System.Windows.Forms.SplitContainer();
			this.debugInfoRichTextBox = new System.Windows.Forms.RichTextBox();
			this.dateTreeRadioButton = new System.Windows.Forms.RadioButton();
			this.categoryTreeRadioButton = new System.Windows.Forms.RadioButton();
			this.categoryColorBookRadioButton = new System.Windows.Forms.RadioButton();
			this.dateNameBookRadioButton = new System.Windows.Forms.RadioButton();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
			this.splitContainer.Panel1.SuspendLayout();
			this.splitContainer.Panel2.SuspendLayout();
			this.splitContainer.SuspendLayout();
			this.SuspendLayout();
			// 
			// splitContainer
			// 
			this.splitContainer.Cursor = System.Windows.Forms.Cursors.HSplit;
			this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer.IsSplitterFixed = true;
			this.splitContainer.Location = new System.Drawing.Point(0, 0);
			this.splitContainer.Name = "splitContainer";
			this.splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer.Panel1
			// 
			this.splitContainer.Panel1.Controls.Add(this.debugInfoRichTextBox);
			// 
			// splitContainer.Panel2
			// 
			this.splitContainer.Panel2.Controls.Add(this.dateTreeRadioButton);
			this.splitContainer.Panel2.Controls.Add(this.categoryTreeRadioButton);
			this.splitContainer.Panel2.Controls.Add(this.categoryColorBookRadioButton);
			this.splitContainer.Panel2.Controls.Add(this.dateNameBookRadioButton);
			this.splitContainer.Panel2.Cursor = System.Windows.Forms.Cursors.Default;
			this.splitContainer.Size = new System.Drawing.Size(382, 673);
			this.splitContainer.SplitterDistance = 586;
			this.splitContainer.TabIndex = 0;
			// 
			// debugInfoRichTextBox
			// 
			this.debugInfoRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.debugInfoRichTextBox.Location = new System.Drawing.Point(0, 0);
			this.debugInfoRichTextBox.Name = "debugInfoRichTextBox";
			this.debugInfoRichTextBox.ReadOnly = true;
			this.debugInfoRichTextBox.Size = new System.Drawing.Size(382, 586);
			this.debugInfoRichTextBox.TabIndex = 0;
			this.debugInfoRichTextBox.Text = "";
			// 
			// dateTreeRadioButton
			// 
			this.dateTreeRadioButton.AutoSize = true;
			this.dateTreeRadioButton.Location = new System.Drawing.Point(226, 14);
			this.dateTreeRadioButton.Name = "dateTreeRadioButton";
			this.dateTreeRadioButton.Size = new System.Drawing.Size(144, 24);
			this.dateTreeRadioButton.TabIndex = 2;
			this.dateTreeRadioButton.Text = "БДП дата-время";
			this.dateTreeRadioButton.UseVisualStyleBackColor = true;
			this.dateTreeRadioButton.CheckedChanged += new System.EventHandler(this.dateTreeRadioButton_CheckedChanged);
			// 
			// categoryTreeRadioButton
			// 
			this.categoryTreeRadioButton.AutoSize = true;
			this.categoryTreeRadioButton.Location = new System.Drawing.Point(226, 44);
			this.categoryTreeRadioButton.Name = "categoryTreeRadioButton";
			this.categoryTreeRadioButton.Size = new System.Drawing.Size(134, 24);
			this.categoryTreeRadioButton.TabIndex = 4;
			this.categoryTreeRadioButton.Text = "БДП категория";
			this.categoryTreeRadioButton.UseVisualStyleBackColor = true;
			this.categoryTreeRadioButton.CheckedChanged += new System.EventHandler(this.categoryTreeRadioButton_CheckedChanged);
			// 
			// categoryColorBookRadioButton
			// 
			this.categoryColorBookRadioButton.AutoSize = true;
			this.categoryColorBookRadioButton.Location = new System.Drawing.Point(12, 44);
			this.categoryColorBookRadioButton.Name = "categoryColorBookRadioButton";
			this.categoryColorBookRadioButton.Size = new System.Drawing.Size(158, 24);
			this.categoryColorBookRadioButton.TabIndex = 3;
			this.categoryColorBookRadioButton.Text = "ХТ категория-цвет";
			this.categoryColorBookRadioButton.UseVisualStyleBackColor = true;
			this.categoryColorBookRadioButton.CheckedChanged += new System.EventHandler(this.categoryColorBookRadioButton_CheckedChanged);
			// 
			// dateNameBookRadioButton
			// 
			this.dateNameBookRadioButton.AutoSize = true;
			this.dateNameBookRadioButton.Location = new System.Drawing.Point(12, 14);
			this.dateNameBookRadioButton.Name = "dateNameBookRadioButton";
			this.dateNameBookRadioButton.Size = new System.Drawing.Size(165, 24);
			this.dateNameBookRadioButton.TabIndex = 1;
			this.dateNameBookRadioButton.Text = "ХТ имя-дата-время";
			this.dateNameBookRadioButton.UseVisualStyleBackColor = true;
			this.dateNameBookRadioButton.CheckedChanged += new System.EventHandler(this.dateNameBookRadioButton_CheckedChanged);
			// 
			// DebugForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(382, 673);
			this.Controls.Add(this.splitContainer);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "DebugForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Окно отладки";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DebugForm_FormClosing);
			this.Load += new System.EventHandler(this.DebugForm_Load);
			this.splitContainer.Panel1.ResumeLayout(false);
			this.splitContainer.Panel2.ResumeLayout(false);
			this.splitContainer.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
			this.splitContainer.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer splitContainer;
		private System.Windows.Forms.RichTextBox debugInfoRichTextBox;
		private System.Windows.Forms.RadioButton dateTreeRadioButton;
		private System.Windows.Forms.RadioButton categoryTreeRadioButton;
		private System.Windows.Forms.RadioButton categoryColorBookRadioButton;
		private System.Windows.Forms.RadioButton dateNameBookRadioButton;
	}
}