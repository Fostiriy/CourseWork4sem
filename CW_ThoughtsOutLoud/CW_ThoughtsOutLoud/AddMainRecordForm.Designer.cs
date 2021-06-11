
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
			this.timeLabel = new System.Windows.Forms.Label();
			this.nameLabel = new System.Windows.Forms.Label();
			this.categoryLabel = new System.Windows.Forms.Label();
			this.colorLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// dateComboBox
			// 
			this.dateComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.dateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.dateComboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.dateComboBox.FormattingEnabled = true;
			this.dateComboBox.Location = new System.Drawing.Point(204, 27);
			this.dateComboBox.Name = "dateComboBox";
			this.dateComboBox.Size = new System.Drawing.Size(216, 36);
			this.dateComboBox.TabIndex = 0;
			this.dateComboBox.SelectedIndexChanged += new System.EventHandler(this.DateComboBox_SelectedIndexChanged);
			// 
			// categoryComboBox
			// 
			this.categoryComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.categoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.categoryComboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.categoryComboBox.FormattingEnabled = true;
			this.categoryComboBox.Location = new System.Drawing.Point(204, 139);
			this.categoryComboBox.Name = "categoryComboBox";
			this.categoryComboBox.Size = new System.Drawing.Size(216, 36);
			this.categoryComboBox.TabIndex = 0;
			this.categoryComboBox.SelectedIndexChanged += new System.EventHandler(this.CategoryComboBox_SelectedIndexChanged);
			// 
			// nameTextBox
			// 
			this.nameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.nameTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.nameTextBox.Location = new System.Drawing.Point(204, 69);
			this.nameTextBox.Name = "nameTextBox";
			this.nameTextBox.ReadOnly = true;
			this.nameTextBox.Size = new System.Drawing.Size(216, 34);
			this.nameTextBox.TabIndex = 1;
			// 
			// colorTextBox
			// 
			this.colorTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.colorTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.colorTextBox.Location = new System.Drawing.Point(204, 181);
			this.colorTextBox.Name = "colorTextBox";
			this.colorTextBox.ReadOnly = true;
			this.colorTextBox.Size = new System.Drawing.Size(216, 34);
			this.colorTextBox.TabIndex = 1;
			// 
			// cancelButton
			// 
			this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.cancelButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.cancelButton.Location = new System.Drawing.Point(315, 256);
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
			this.addRecordButton.Location = new System.Drawing.Point(204, 256);
			this.addRecordButton.Name = "addRecordButton";
			this.addRecordButton.Size = new System.Drawing.Size(105, 35);
			this.addRecordButton.TabIndex = 4;
			this.addRecordButton.Text = "OK";
			this.addRecordButton.UseVisualStyleBackColor = true;
			this.addRecordButton.Click += new System.EventHandler(this.addRecordButton_Click);
			// 
			// timeLabel
			// 
			this.timeLabel.AutoSize = true;
			this.timeLabel.Location = new System.Drawing.Point(12, 37);
			this.timeLabel.Name = "timeLabel";
			this.timeLabel.Size = new System.Drawing.Size(129, 20);
			this.timeLabel.TabIndex = 5;
			this.timeLabel.Text = "Выберите время:";
			// 
			// nameLabel
			// 
			this.nameLabel.AutoSize = true;
			this.nameLabel.Location = new System.Drawing.Point(12, 79);
			this.nameLabel.Name = "nameLabel";
			this.nameLabel.Size = new System.Drawing.Size(136, 20);
			this.nameLabel.TabIndex = 5;
			this.nameLabel.Text = "Имя аудиозаписи:";
			// 
			// categoryLabel
			// 
			this.categoryLabel.AutoSize = true;
			this.categoryLabel.Location = new System.Drawing.Point(12, 149);
			this.categoryLabel.Name = "categoryLabel";
			this.categoryLabel.Size = new System.Drawing.Size(159, 20);
			this.categoryLabel.TabIndex = 5;
			this.categoryLabel.Text = "Выберите категорию:";
			// 
			// colorLabel
			// 
			this.colorLabel.AutoSize = true;
			this.colorLabel.Location = new System.Drawing.Point(12, 191);
			this.colorLabel.Name = "colorLabel";
			this.colorLabel.Size = new System.Drawing.Size(120, 20);
			this.colorLabel.TabIndex = 5;
			this.colorLabel.Text = "Цвет категории:";
			// 
			// AddMainRecordForm
			// 
			this.AcceptButton = this.addRecordButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.cancelButton;
			this.ClientSize = new System.Drawing.Size(432, 303);
			this.Controls.Add(this.colorLabel);
			this.Controls.Add(this.categoryLabel);
			this.Controls.Add(this.nameLabel);
			this.Controls.Add(this.timeLabel);
			this.Controls.Add(this.cancelButton);
			this.Controls.Add(this.addRecordButton);
			this.Controls.Add(this.colorTextBox);
			this.Controls.Add(this.nameTextBox);
			this.Controls.Add(this.categoryComboBox);
			this.Controls.Add(this.dateComboBox);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "AddMainRecordForm";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
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
		private System.Windows.Forms.Label timeLabel;
		private System.Windows.Forms.Label nameLabel;
		private System.Windows.Forms.Label categoryLabel;
		private System.Windows.Forms.Label colorLabel;
	}
}