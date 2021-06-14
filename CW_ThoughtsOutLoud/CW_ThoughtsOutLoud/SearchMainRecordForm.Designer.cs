
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
			this.inputDateFromTextBox = new System.Windows.Forms.MaskedTextBox();
			this.inputDateLabel = new System.Windows.Forms.Label();
			this.cancelButton = new System.Windows.Forms.Button();
			this.searchRecordButton = new System.Windows.Forms.Button();
			this.inputDateToTextBox = new System.Windows.Forms.MaskedTextBox();
			this.dateTreeRadioButton = new System.Windows.Forms.RadioButton();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.inputTimeFromTextBox = new System.Windows.Forms.MaskedTextBox();
			this.inputTimeToTextBox = new System.Windows.Forms.MaskedTextBox();
			this.dateTreeGroupBox = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.dateTreeGroupBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// inputDateFromTextBox
			// 
			this.inputDateFromTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.inputDateFromTextBox.Location = new System.Drawing.Point(1, 42);
			this.inputDateFromTextBox.Mask = "00/00/0000";
			this.inputDateFromTextBox.Name = "inputDateFromTextBox";
			this.inputDateFromTextBox.ResetOnSpace = false;
			this.inputDateFromTextBox.Size = new System.Drawing.Size(175, 34);
			this.inputDateFromTextBox.TabIndex = 11;
			this.inputDateFromTextBox.ValidatingType = typeof(System.DateTime);
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
			// inputDateToTextBox
			// 
			this.inputDateToTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.inputDateToTextBox.Location = new System.Drawing.Point(1, 82);
			this.inputDateToTextBox.Mask = "00/00/0000";
			this.inputDateToTextBox.Name = "inputDateToTextBox";
			this.inputDateToTextBox.ResetOnSpace = false;
			this.inputDateToTextBox.Size = new System.Drawing.Size(175, 34);
			this.inputDateToTextBox.TabIndex = 11;
			this.inputDateToTextBox.ValidatingType = typeof(System.DateTime);
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
			// inputTimeFromTextBox
			// 
			this.inputTimeFromTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.inputTimeFromTextBox.Location = new System.Drawing.Point(182, 42);
			this.inputTimeFromTextBox.Mask = "00:00:00";
			this.inputTimeFromTextBox.Name = "inputTimeFromTextBox";
			this.inputTimeFromTextBox.ResetOnSpace = false;
			this.inputTimeFromTextBox.Size = new System.Drawing.Size(175, 34);
			this.inputTimeFromTextBox.TabIndex = 16;
			// 
			// inputTimeToTextBox
			// 
			this.inputTimeToTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.inputTimeToTextBox.Location = new System.Drawing.Point(182, 82);
			this.inputTimeToTextBox.Mask = "00:00:00";
			this.inputTimeToTextBox.Name = "inputTimeToTextBox";
			this.inputTimeToTextBox.ResetOnSpace = false;
			this.inputTimeToTextBox.Size = new System.Drawing.Size(175, 34);
			this.inputTimeToTextBox.TabIndex = 16;
			// 
			// dateTreeGroupBox
			// 
			this.dateTreeGroupBox.Controls.Add(this.inputTimeToTextBox);
			this.dateTreeGroupBox.Controls.Add(this.inputDateLabel);
			this.dateTreeGroupBox.Controls.Add(this.inputTimeFromTextBox);
			this.dateTreeGroupBox.Controls.Add(this.inputDateFromTextBox);
			this.dateTreeGroupBox.Controls.Add(this.inputDateToTextBox);
			this.dateTreeGroupBox.Enabled = false;
			this.dateTreeGroupBox.Location = new System.Drawing.Point(12, 42);
			this.dateTreeGroupBox.Name = "dateTreeGroupBox";
			this.dateTreeGroupBox.Size = new System.Drawing.Size(358, 135);
			this.dateTreeGroupBox.TabIndex = 17;
			this.dateTreeGroupBox.TabStop = false;
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

		public System.Windows.Forms.MaskedTextBox inputDateFromTextBox;
		private System.Windows.Forms.Label inputDateLabel;
		protected internal System.Windows.Forms.Button cancelButton;
		protected internal System.Windows.Forms.Button searchRecordButton;
		public System.Windows.Forms.MaskedTextBox inputDateToTextBox;
		private System.Windows.Forms.RadioButton dateTreeRadioButton;
		private System.Windows.Forms.RadioButton radioButton2;
		public System.Windows.Forms.MaskedTextBox inputTimeFromTextBox;
		public System.Windows.Forms.MaskedTextBox inputTimeToTextBox;
		private System.Windows.Forms.GroupBox dateTreeGroupBox;
		private System.Windows.Forms.GroupBox groupBox2;
	}
}