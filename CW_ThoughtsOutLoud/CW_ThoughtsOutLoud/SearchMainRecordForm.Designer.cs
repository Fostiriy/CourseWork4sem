
namespace CW_ThoughtsOutLoud
{
	partial class SearchMainRecordForm
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
			this.inputDateLabel = new System.Windows.Forms.Label();
			this.cancelButton = new System.Windows.Forms.Button();
			this.searchRecordButton = new System.Windows.Forms.Button();
			this.dateTreeRadioButton = new System.Windows.Forms.RadioButton();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.dateTreeGroupBox = new System.Windows.Forms.GroupBox();
			this.inputTimeToTimePicker = new System.Windows.Forms.DateTimePicker();
			this.inputTimeFromTimePicker = new System.Windows.Forms.DateTimePicker();
			this.inputDateToTimePicker = new System.Windows.Forms.DateTimePicker();
			this.inputDateFromTimePicker = new System.Windows.Forms.DateTimePicker();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.dateTreeGroupBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// inputDateLabel
			// 
			this.inputDateLabel.AutoSize = true;
			this.inputDateLabel.Location = new System.Drawing.Point(7, 19);
			this.inputDateLabel.Name = "inputDateLabel";
			this.inputDateLabel.Size = new System.Drawing.Size(314, 20);
			this.inputDateLabel.TabIndex = 12;
			this.inputDateLabel.Text = "Введите диапазон в формате \"Дата-время\":";
			// 
			// cancelButton
			// 
			this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.cancelButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.cancelButton.Location = new System.Drawing.Point(265, 356);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(105, 35);
			this.cancelButton.TabIndex = 14;
			this.cancelButton.Text = "Закрыть";
			this.cancelButton.UseVisualStyleBackColor = true;
			// 
			// searchRecordButton
			// 
			this.searchRecordButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.searchRecordButton.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.searchRecordButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.searchRecordButton.Location = new System.Drawing.Point(154, 356);
			this.searchRecordButton.Name = "searchRecordButton";
			this.searchRecordButton.Size = new System.Drawing.Size(105, 35);
			this.searchRecordButton.TabIndex = 13;
			this.searchRecordButton.Text = "Найти";
			this.searchRecordButton.UseVisualStyleBackColor = true;
			this.searchRecordButton.Click += new System.EventHandler(this.SearchRecordButton_Click);
			// 
			// dateTreeRadioButton
			// 
			this.dateTreeRadioButton.AutoSize = true;
			this.dateTreeRadioButton.Location = new System.Drawing.Point(12, 12);
			this.dateTreeRadioButton.Name = "dateTreeRadioButton";
			this.dateTreeRadioButton.Size = new System.Drawing.Size(289, 24);
			this.dateTreeRadioButton.TabIndex = 15;
			this.dateTreeRadioButton.TabStop = true;
			this.dateTreeRadioButton.Text = "Поиск по диапазону даты и времени";
			this.dateTreeRadioButton.UseVisualStyleBackColor = true;
			this.dateTreeRadioButton.CheckedChanged += new System.EventHandler(this.DateTreeRadioButton_CheckedChanged);
			// 
			// radioButton2
			// 
			this.radioButton2.AutoSize = true;
			this.radioButton2.Location = new System.Drawing.Point(12, 183);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(248, 24);
			this.radioButton2.TabIndex = 15;
			this.radioButton2.TabStop = true;
			this.radioButton2.Text = "Поиск по диапазону категорий";
			this.radioButton2.UseVisualStyleBackColor = true;
			// 
			// dateTreeGroupBox
			// 
			this.dateTreeGroupBox.Controls.Add(this.inputTimeToTimePicker);
			this.dateTreeGroupBox.Controls.Add(this.inputTimeFromTimePicker);
			this.dateTreeGroupBox.Controls.Add(this.inputDateToTimePicker);
			this.dateTreeGroupBox.Controls.Add(this.inputDateFromTimePicker);
			this.dateTreeGroupBox.Controls.Add(this.inputDateLabel);
			this.dateTreeGroupBox.Enabled = false;
			this.dateTreeGroupBox.Location = new System.Drawing.Point(12, 42);
			this.dateTreeGroupBox.Name = "dateTreeGroupBox";
			this.dateTreeGroupBox.Size = new System.Drawing.Size(358, 135);
			this.dateTreeGroupBox.TabIndex = 17;
			this.dateTreeGroupBox.TabStop = false;
			// 
			// inputTimeToTimePicker
			// 
			this.inputTimeToTimePicker.CalendarFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.inputTimeToTimePicker.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.inputTimeToTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
			this.inputTimeToTimePicker.Location = new System.Drawing.Point(182, 82);
			this.inputTimeToTimePicker.Name = "inputTimeToTimePicker";
			this.inputTimeToTimePicker.ShowUpDown = true;
			this.inputTimeToTimePicker.Size = new System.Drawing.Size(120, 34);
			this.inputTimeToTimePicker.TabIndex = 0;
			this.inputTimeToTimePicker.Value = new System.DateTime(2021, 1, 1, 23, 59, 59, 0);
			// 
			// inputTimeFromTimePicker
			// 
			this.inputTimeFromTimePicker.CalendarFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.inputTimeFromTimePicker.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.inputTimeFromTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
			this.inputTimeFromTimePicker.Location = new System.Drawing.Point(182, 42);
			this.inputTimeFromTimePicker.Name = "inputTimeFromTimePicker";
			this.inputTimeFromTimePicker.ShowUpDown = true;
			this.inputTimeFromTimePicker.Size = new System.Drawing.Size(120, 34);
			this.inputTimeFromTimePicker.TabIndex = 0;
			this.inputTimeFromTimePicker.Value = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
			// 
			// inputDateToTimePicker
			// 
			this.inputDateToTimePicker.CalendarFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.inputDateToTimePicker.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.inputDateToTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.inputDateToTimePicker.Location = new System.Drawing.Point(56, 82);
			this.inputDateToTimePicker.MaxDate = new System.DateTime(2999, 12, 31, 0, 0, 0, 0);
			this.inputDateToTimePicker.Name = "inputDateToTimePicker";
			this.inputDateToTimePicker.Size = new System.Drawing.Size(120, 34);
			this.inputDateToTimePicker.TabIndex = 0;
			this.inputDateToTimePicker.Value = new System.DateTime(2021, 12, 31, 0, 0, 0, 0);
			// 
			// inputDateFromTimePicker
			// 
			this.inputDateFromTimePicker.CalendarFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.inputDateFromTimePicker.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.inputDateFromTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.inputDateFromTimePicker.Location = new System.Drawing.Point(56, 42);
			this.inputDateFromTimePicker.MaxDate = new System.DateTime(2999, 12, 31, 0, 0, 0, 0);
			this.inputDateFromTimePicker.Name = "inputDateFromTimePicker";
			this.inputDateFromTimePicker.Size = new System.Drawing.Size(120, 34);
			this.inputDateFromTimePicker.TabIndex = 0;
			this.inputDateFromTimePicker.Value = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
			// 
			// groupBox2
			// 
			this.groupBox2.Location = new System.Drawing.Point(12, 213);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(358, 125);
			this.groupBox2.TabIndex = 18;
			this.groupBox2.TabStop = false;
			// 
			// SearchMainRecordForm
			// 
			this.AcceptButton = this.searchRecordButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.cancelButton;
			this.ClientSize = new System.Drawing.Size(382, 403);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.dateTreeRadioButton);
			this.Controls.Add(this.dateTreeGroupBox);
			this.Controls.Add(this.radioButton2);
			this.Controls.Add(this.cancelButton);
			this.Controls.Add(this.searchRecordButton);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "SearchMainRecordForm";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.Text = "SearchMainRecordForm";
			this.Load += new System.EventHandler(this.SearchMainRecordForm_Load);
			this.dateTreeGroupBox.ResumeLayout(false);
			this.dateTreeGroupBox.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label inputDateLabel;
		protected internal System.Windows.Forms.Button cancelButton;
		protected internal System.Windows.Forms.Button searchRecordButton;
		private System.Windows.Forms.RadioButton dateTreeRadioButton;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.GroupBox dateTreeGroupBox;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.DateTimePicker inputDateFromTimePicker;
		private System.Windows.Forms.DateTimePicker inputTimeFromTimePicker;
		private System.Windows.Forms.DateTimePicker inputTimeToTimePicker;
		private System.Windows.Forms.DateTimePicker inputDateToTimePicker;
	}
}