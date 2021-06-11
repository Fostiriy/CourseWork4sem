
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
			this.inputDateTextBox = new System.Windows.Forms.MaskedTextBox();
			this.inputTimeTextBox = new System.Windows.Forms.MaskedTextBox();
			this.cancelButton = new System.Windows.Forms.Button();
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
			this.addRecordButton.TabIndex = 0;
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
			this.inputNameTextBox.TabIndex = 1;
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
			// inputDateTextBox
			// 
			this.inputDateTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.inputDateTextBox.Location = new System.Drawing.Point(145, 97);
			this.inputDateTextBox.Mask = "00/00/0000";
			this.inputDateTextBox.Name = "inputDateTextBox";
			this.inputDateTextBox.Size = new System.Drawing.Size(175, 34);
			this.inputDateTextBox.TabIndex = 3;
			this.inputDateTextBox.ValidatingType = typeof(System.DateTime);
			// 
			// inputTimeTextBox
			// 
			this.inputTimeTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.inputTimeTextBox.Location = new System.Drawing.Point(145, 137);
			this.inputTimeTextBox.Mask = "00:00:00";
			this.inputTimeTextBox.Name = "inputTimeTextBox";
			this.inputTimeTextBox.Size = new System.Drawing.Size(175, 34);
			this.inputTimeTextBox.TabIndex = 3;
			// 
			// cancelButton
			// 
			this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.cancelButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.cancelButton.Location = new System.Drawing.Point(215, 206);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(105, 35);
			this.cancelButton.TabIndex = 0;
			this.cancelButton.Text = "Отмена";
			this.cancelButton.UseVisualStyleBackColor = true;
			// 
			// AddDateRecordForm
			// 
			this.AcceptButton = this.addRecordButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.cancelButton;
			this.ClientSize = new System.Drawing.Size(332, 253);
			this.Controls.Add(this.inputTimeTextBox);
			this.Controls.Add(this.inputDateTextBox);
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
		public System.Windows.Forms.MaskedTextBox inputDateTextBox;
		public System.Windows.Forms.MaskedTextBox inputTimeTextBox;
		protected internal System.Windows.Forms.Button cancelButton;
	}
}