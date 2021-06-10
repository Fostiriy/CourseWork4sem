
namespace CW_ThoughtsOutLoud
{
	partial class AddRecordForm
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
			this.addRecordButton = new System.Windows.Forms.Button();
			this.inputNameTextBox = new System.Windows.Forms.TextBox();
			this.inputNameLabel = new System.Windows.Forms.Label();
			this.inputDateTextBox = new System.Windows.Forms.TextBox();
			this.inputTimeTextBox = new System.Windows.Forms.TextBox();
			this.inputDateLabel = new System.Windows.Forms.Label();
			this.inputTimeLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// addRecordButton
			// 
			this.addRecordButton.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.addRecordButton.Location = new System.Drawing.Point(204, 400);
			this.addRecordButton.Name = "addRecordButton";
			this.addRecordButton.Size = new System.Drawing.Size(94, 29);
			this.addRecordButton.TabIndex = 0;
			this.addRecordButton.Text = "Добавить";
			this.addRecordButton.UseVisualStyleBackColor = true;
			this.addRecordButton.Click += new System.EventHandler(this.AddRecordButton_Click);
			// 
			// inputNameTextBox
			// 
			this.inputNameTextBox.Location = new System.Drawing.Point(144, 76);
			this.inputNameTextBox.Name = "inputNameTextBox";
			this.inputNameTextBox.Size = new System.Drawing.Size(141, 27);
			this.inputNameTextBox.TabIndex = 1;
			// 
			// inputNameLabel
			// 
			this.inputNameLabel.AutoSize = true;
			this.inputNameLabel.Location = new System.Drawing.Point(12, 44);
			this.inputNameLabel.Name = "inputNameLabel";
			this.inputNameLabel.Size = new System.Drawing.Size(194, 20);
			this.inputNameLabel.TabIndex = 2;
			this.inputNameLabel.Text = "Введите имя аудиозаписи:";
			// 
			// inputDateTextBox
			// 
			this.inputDateTextBox.Location = new System.Drawing.Point(144, 143);
			this.inputDateTextBox.Name = "inputDateTextBox";
			this.inputDateTextBox.Size = new System.Drawing.Size(141, 27);
			this.inputDateTextBox.TabIndex = 1;
			// 
			// inputTimeTextBox
			// 
			this.inputTimeTextBox.Location = new System.Drawing.Point(144, 218);
			this.inputTimeTextBox.Name = "inputTimeTextBox";
			this.inputTimeTextBox.Size = new System.Drawing.Size(141, 27);
			this.inputTimeTextBox.TabIndex = 1;
			// 
			// inputDateLabel
			// 
			this.inputDateLabel.AutoSize = true;
			this.inputDateLabel.Location = new System.Drawing.Point(12, 134);
			this.inputDateLabel.Name = "inputDateLabel";
			this.inputDateLabel.Size = new System.Drawing.Size(98, 20);
			this.inputDateLabel.TabIndex = 2;
			this.inputDateLabel.Text = "Введите дату";
			// 
			// inputTimeLabel
			// 
			this.inputTimeLabel.AutoSize = true;
			this.inputTimeLabel.Location = new System.Drawing.Point(12, 221);
			this.inputTimeLabel.Name = "inputTimeLabel";
			this.inputTimeLabel.Size = new System.Drawing.Size(113, 20);
			this.inputTimeLabel.TabIndex = 2;
			this.inputTimeLabel.Text = "Введите время";
			// 
			// AddRecordForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(332, 453);
			this.Controls.Add(this.inputTimeLabel);
			this.Controls.Add(this.inputDateLabel);
			this.Controls.Add(this.inputNameLabel);
			this.Controls.Add(this.inputTimeTextBox);
			this.Controls.Add(this.inputDateTextBox);
			this.Controls.Add(this.inputNameTextBox);
			this.Controls.Add(this.addRecordButton);
			this.Name = "AddRecordForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Добавить запись...";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		protected internal System.Windows.Forms.Button addRecordButton;
		private System.Windows.Forms.Label inputNameLabel;
		private System.Windows.Forms.Label inputDateLabel;
		private System.Windows.Forms.Label inputTimeLabel;
		public System.Windows.Forms.TextBox inputNameTextBox;
		public System.Windows.Forms.TextBox inputDateTextBox;
		public System.Windows.Forms.TextBox inputTimeTextBox;
	}
}