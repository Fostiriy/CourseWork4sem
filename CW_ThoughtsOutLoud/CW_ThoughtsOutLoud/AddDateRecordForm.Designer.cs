
namespace CW_ThoughtsOutLoud
{
	partial class AddDateRecordForm
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
			this.inputDateLabel = new System.Windows.Forms.Label();
			this.inputTimeLabel = new System.Windows.Forms.Label();
			this.cancelButton = new System.Windows.Forms.Button();
			this.inputDateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.inputTimeTimePicker = new System.Windows.Forms.DateTimePicker();
			this.SuspendLayout();
			// 
			// addRecordButton
			// 
			this.addRecordButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.addRecordButton.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.addRecordButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.addRecordButton.Location = new System.Drawing.Point(104, 206);
			this.addRecordButton.Name = "addRecordButton";
			this.addRecordButton.Size = new System.Drawing.Size(105, 35);
			this.addRecordButton.TabIndex = 3;
			this.addRecordButton.Text = "OK";
			this.addRecordButton.UseVisualStyleBackColor = true;
			this.addRecordButton.Click += new System.EventHandler(this.AddRecordButton_Click);
			// 
			// inputNameTextBox
			// 
			this.inputNameTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.inputNameTextBox.Location = new System.Drawing.Point(12, 45);
			this.inputNameTextBox.Name = "inputNameTextBox";
			this.inputNameTextBox.Size = new System.Drawing.Size(308, 34);
			this.inputNameTextBox.TabIndex = 0;
			this.inputNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputNameTextBox_KeyPress);
			// 
			// inputNameLabel
			// 
			this.inputNameLabel.AutoSize = true;
			this.inputNameLabel.Location = new System.Drawing.Point(12, 22);
			this.inputNameLabel.Name = "inputNameLabel";
			this.inputNameLabel.Size = new System.Drawing.Size(194, 20);
			this.inputNameLabel.TabIndex = 2;
			this.inputNameLabel.Text = "Введите имя аудиозаписи:";
			// 
			// inputDateLabel
			// 
			this.inputDateLabel.AutoSize = true;
			this.inputDateLabel.Location = new System.Drawing.Point(12, 107);
			this.inputDateLabel.Name = "inputDateLabel";
			this.inputDateLabel.Size = new System.Drawing.Size(101, 20);
			this.inputDateLabel.TabIndex = 2;
			this.inputDateLabel.Text = "Введите дату:";
			// 
			// inputTimeLabel
			// 
			this.inputTimeLabel.AutoSize = true;
			this.inputTimeLabel.Location = new System.Drawing.Point(12, 147);
			this.inputTimeLabel.Name = "inputTimeLabel";
			this.inputTimeLabel.Size = new System.Drawing.Size(116, 20);
			this.inputTimeLabel.TabIndex = 2;
			this.inputTimeLabel.Text = "Введите время:";
			// 
			// cancelButton
			// 
			this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.cancelButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.cancelButton.Location = new System.Drawing.Point(215, 206);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(105, 35);
			this.cancelButton.TabIndex = 4;
			this.cancelButton.Text = "Отмена";
			this.cancelButton.UseVisualStyleBackColor = true;
			// 
			// inputDateTimePicker
			// 
			this.inputDateTimePicker.CalendarFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.inputDateTimePicker.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.inputDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.inputDateTimePicker.Location = new System.Drawing.Point(145, 95);
			this.inputDateTimePicker.MaxDate = new System.DateTime(2999, 12, 31, 0, 0, 0, 0);
			this.inputDateTimePicker.Name = "inputDateTimePicker";
			this.inputDateTimePicker.Size = new System.Drawing.Size(175, 34);
			this.inputDateTimePicker.TabIndex = 5;
			this.inputDateTimePicker.Value = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
			// 
			// inputTimeTimePicker
			// 
			this.inputTimeTimePicker.CalendarFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.inputTimeTimePicker.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.inputTimeTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
			this.inputTimeTimePicker.Location = new System.Drawing.Point(145, 135);
			this.inputTimeTimePicker.Name = "inputTimeTimePicker";
			this.inputTimeTimePicker.ShowUpDown = true;
			this.inputTimeTimePicker.Size = new System.Drawing.Size(175, 34);
			this.inputTimeTimePicker.TabIndex = 6;
			this.inputTimeTimePicker.Value = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
			// 
			// AddDateRecordForm
			// 
			this.AcceptButton = this.addRecordButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.cancelButton;
			this.ClientSize = new System.Drawing.Size(332, 253);
			this.Controls.Add(this.inputTimeTimePicker);
			this.Controls.Add(this.inputDateTimePicker);
			this.Controls.Add(this.inputTimeLabel);
			this.Controls.Add(this.inputDateLabel);
			this.Controls.Add(this.inputNameLabel);
			this.Controls.Add(this.inputNameTextBox);
			this.Controls.Add(this.cancelButton);
			this.Controls.Add(this.addRecordButton);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "AddDateRecordForm";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Добавить запись";
			this.Load += new System.EventHandler(this.AddDateRecordForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		protected internal System.Windows.Forms.Button addRecordButton;
		private System.Windows.Forms.Label inputNameLabel;
		private System.Windows.Forms.Label inputDateLabel;
		private System.Windows.Forms.Label inputTimeLabel;
		public System.Windows.Forms.TextBox inputNameTextBox;
		protected internal System.Windows.Forms.Button cancelButton;
		private System.Windows.Forms.DateTimePicker inputDateTimePicker;
		private System.Windows.Forms.DateTimePicker inputTimeTimePicker;
	}
}