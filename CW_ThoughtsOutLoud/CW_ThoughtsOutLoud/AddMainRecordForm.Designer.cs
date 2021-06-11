
namespace CW_ThoughtsOutLoud
{
	partial class AddMainRecordForm
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
			this.dateComboBox = new System.Windows.Forms.ComboBox();
			this.categoryComboBox = new System.Windows.Forms.ComboBox();
			this.nameTextBox = new System.Windows.Forms.TextBox();
			this.colorTextBox = new System.Windows.Forms.TextBox();
			this.cancelButton = new System.Windows.Forms.Button();
			this.addRecordButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// dateComboBox
			// 
			this.dateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.dateComboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.dateComboBox.FormattingEnabled = true;
			this.dateComboBox.Location = new System.Drawing.Point(153, 65);
			this.dateComboBox.Name = "dateComboBox";
			this.dateComboBox.Size = new System.Drawing.Size(151, 36);
			this.dateComboBox.TabIndex = 0;
			this.dateComboBox.SelectedIndexChanged += new System.EventHandler(this.DateComboBox_SelectedIndexChanged);
			// 
			// categoryComboBox
			// 
			this.categoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.categoryComboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.categoryComboBox.FormattingEnabled = true;
			this.categoryComboBox.Location = new System.Drawing.Point(153, 253);
			this.categoryComboBox.Name = "categoryComboBox";
			this.categoryComboBox.Size = new System.Drawing.Size(151, 36);
			this.categoryComboBox.TabIndex = 0;
			this.categoryComboBox.SelectedIndexChanged += new System.EventHandler(this.CategoryComboBox_SelectedIndexChanged);
			// 
			// nameTextBox
			// 
			this.nameTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.nameTextBox.Location = new System.Drawing.Point(153, 115);
			this.nameTextBox.Name = "nameTextBox";
			this.nameTextBox.ReadOnly = true;
			this.nameTextBox.Size = new System.Drawing.Size(151, 34);
			this.nameTextBox.TabIndex = 1;
			// 
			// colorTextBox
			// 
			this.colorTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.colorTextBox.Location = new System.Drawing.Point(153, 315);
			this.colorTextBox.Name = "colorTextBox";
			this.colorTextBox.ReadOnly = true;
			this.colorTextBox.Size = new System.Drawing.Size(151, 34);
			this.colorTextBox.TabIndex = 1;
			// 
			// cancelButton
			// 
			this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.cancelButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.cancelButton.Location = new System.Drawing.Point(215, 406);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(105, 35);
			this.cancelButton.TabIndex = 3;
			this.cancelButton.Text = "Отмена";
			this.cancelButton.UseVisualStyleBackColor = true;
			// 
			// addRecordButton
			// 
			this.addRecordButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.addRecordButton.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.addRecordButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.addRecordButton.Location = new System.Drawing.Point(104, 406);
			this.addRecordButton.Name = "addRecordButton";
			this.addRecordButton.Size = new System.Drawing.Size(105, 35);
			this.addRecordButton.TabIndex = 4;
			this.addRecordButton.Text = "OK";
			this.addRecordButton.UseVisualStyleBackColor = true;
			// 
			// AddMainRecordForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(332, 453);
			this.Controls.Add(this.cancelButton);
			this.Controls.Add(this.addRecordButton);
			this.Controls.Add(this.colorTextBox);
			this.Controls.Add(this.nameTextBox);
			this.Controls.Add(this.categoryComboBox);
			this.Controls.Add(this.dateComboBox);
			this.Name = "AddMainRecordForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Добавить запись";
			this.Load += new System.EventHandler(this.AddMainRecordForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		public System.Windows.Forms.ComboBox dateComboBox;
		public System.Windows.Forms.ComboBox categoryComboBox;
		public System.Windows.Forms.TextBox nameTextBox;
		public System.Windows.Forms.TextBox colorTextBox;
		protected internal System.Windows.Forms.Button cancelButton;
		protected internal System.Windows.Forms.Button addRecordButton;
	}
}