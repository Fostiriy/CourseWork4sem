
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
			this.inputDateTextBox = new System.Windows.Forms.MaskedTextBox();
			this.inputDateLabel = new System.Windows.Forms.Label();
			this.cancelButton = new System.Windows.Forms.Button();
			this.searchRecordButton = new System.Windows.Forms.Button();
			this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
			this.dateTreeRadioButton = new System.Windows.Forms.RadioButton();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.inputTimeTextBox = new System.Windows.Forms.MaskedTextBox();
			this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
			this.dateTreeGroupBox = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.dateTreeGroupBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// inputDateTextBox
			// 
			this.inputDateTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.inputDateTextBox.Location = new System.Drawing.Point(1, 42);
			this.inputDateTextBox.Mask = "00/00/0000";
			this.inputDateTextBox.Name = "inputDateTextBox";
			this.inputDateTextBox.ResetOnSpace = false;
			this.inputDateTextBox.Size = new System.Drawing.Size(175, 34);
			this.inputDateTextBox.TabIndex = 11;
			this.inputDateTextBox.ValidatingType = typeof(System.DateTime);
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
			this.searchRecordButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.searchRecordButton.Location = new System.Drawing.Point(154, 356);
			this.searchRecordButton.Name = "searchRecordButton";
			this.searchRecordButton.Size = new System.Drawing.Size(105, 35);
			this.searchRecordButton.TabIndex = 13;
			this.searchRecordButton.Text = "Найти";
			this.searchRecordButton.UseVisualStyleBackColor = true;
			// 
			// maskedTextBox1
			// 
			this.maskedTextBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.maskedTextBox1.Location = new System.Drawing.Point(1, 82);
			this.maskedTextBox1.Mask = "00/00/0000";
			this.maskedTextBox1.Name = "maskedTextBox1";
			this.maskedTextBox1.ResetOnSpace = false;
			this.maskedTextBox1.Size = new System.Drawing.Size(175, 34);
			this.maskedTextBox1.TabIndex = 11;
			this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
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
			// inputTimeTextBox
			// 
			this.inputTimeTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.inputTimeTextBox.Location = new System.Drawing.Point(182, 42);
			this.inputTimeTextBox.Mask = "00:00:00";
			this.inputTimeTextBox.Name = "inputTimeTextBox";
			this.inputTimeTextBox.ResetOnSpace = false;
			this.inputTimeTextBox.Size = new System.Drawing.Size(175, 34);
			this.inputTimeTextBox.TabIndex = 16;
			// 
			// maskedTextBox2
			// 
			this.maskedTextBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.maskedTextBox2.Location = new System.Drawing.Point(182, 82);
			this.maskedTextBox2.Mask = "00:00:00";
			this.maskedTextBox2.Name = "maskedTextBox2";
			this.maskedTextBox2.ResetOnSpace = false;
			this.maskedTextBox2.Size = new System.Drawing.Size(175, 34);
			this.maskedTextBox2.TabIndex = 16;
			// 
			// dateTreeGroupBox
			// 
			this.dateTreeGroupBox.Controls.Add(this.maskedTextBox2);
			this.dateTreeGroupBox.Controls.Add(this.inputDateLabel);
			this.dateTreeGroupBox.Controls.Add(this.inputTimeTextBox);
			this.dateTreeGroupBox.Controls.Add(this.inputDateTextBox);
			this.dateTreeGroupBox.Controls.Add(this.maskedTextBox1);
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
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
			this.dateTreeGroupBox.ResumeLayout(false);
			this.dateTreeGroupBox.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		public System.Windows.Forms.MaskedTextBox inputDateTextBox;
		private System.Windows.Forms.Label inputDateLabel;
		protected internal System.Windows.Forms.Button cancelButton;
		protected internal System.Windows.Forms.Button searchRecordButton;
		public System.Windows.Forms.MaskedTextBox maskedTextBox1;
		private System.Windows.Forms.RadioButton dateTreeRadioButton;
		private System.Windows.Forms.RadioButton radioButton2;
		public System.Windows.Forms.MaskedTextBox inputTimeTextBox;
		public System.Windows.Forms.MaskedTextBox maskedTextBox2;
		private System.Windows.Forms.GroupBox dateTreeGroupBox;
		private System.Windows.Forms.GroupBox groupBox2;
	}
}