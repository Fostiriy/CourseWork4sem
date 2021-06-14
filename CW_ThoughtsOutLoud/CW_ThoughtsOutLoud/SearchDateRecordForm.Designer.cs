
namespace CW_ThoughtsOutLoud
{
	partial class SearchDateRecordForm
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
			this.inputTimeTextBox = new System.Windows.Forms.MaskedTextBox();
			this.inputDateTextBox = new System.Windows.Forms.MaskedTextBox();
			this.inputTimeLabel = new System.Windows.Forms.Label();
			this.inputDateLabel = new System.Windows.Forms.Label();
			this.cancelButton = new System.Windows.Forms.Button();
			this.searchRecordButton = new System.Windows.Forms.Button();
			this.searchInfoRichTextBox = new System.Windows.Forms.RichTextBox();
			this.SuspendLayout();
			// 
			// inputTimeTextBox
			// 
			this.inputTimeTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.inputTimeTextBox.Location = new System.Drawing.Point(145, 52);
			this.inputTimeTextBox.Mask = "00:00:00";
			this.inputTimeTextBox.Name = "inputTimeTextBox";
			this.inputTimeTextBox.ResetOnSpace = false;
			this.inputTimeTextBox.Size = new System.Drawing.Size(175, 34);
			this.inputTimeTextBox.TabIndex = 6;
			// 
			// inputDateTextBox
			// 
			this.inputDateTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.inputDateTextBox.Location = new System.Drawing.Point(145, 12);
			this.inputDateTextBox.Mask = "00/00/0000";
			this.inputDateTextBox.Name = "inputDateTextBox";
			this.inputDateTextBox.ResetOnSpace = false;
			this.inputDateTextBox.Size = new System.Drawing.Size(175, 34);
			this.inputDateTextBox.TabIndex = 5;
			this.inputDateTextBox.ValidatingType = typeof(System.DateTime);
			// 
			// inputTimeLabel
			// 
			this.inputTimeLabel.AutoSize = true;
			this.inputTimeLabel.Location = new System.Drawing.Point(12, 62);
			this.inputTimeLabel.Name = "inputTimeLabel";
			this.inputTimeLabel.Size = new System.Drawing.Size(116, 20);
			this.inputTimeLabel.TabIndex = 7;
			this.inputTimeLabel.Text = "Введите время:";
			// 
			// inputDateLabel
			// 
			this.inputDateLabel.AutoSize = true;
			this.inputDateLabel.Location = new System.Drawing.Point(12, 22);
			this.inputDateLabel.Name = "inputDateLabel";
			this.inputDateLabel.Size = new System.Drawing.Size(101, 20);
			this.inputDateLabel.TabIndex = 8;
			this.inputDateLabel.Text = "Введите дату:";
			// 
			// cancelButton
			// 
			this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.cancelButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.cancelButton.Location = new System.Drawing.Point(215, 109);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(105, 35);
			this.cancelButton.TabIndex = 10;
			this.cancelButton.Text = "Закрыть";
			this.cancelButton.UseVisualStyleBackColor = true;
			// 
			// searchRecordButton
			// 
			this.searchRecordButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.searchRecordButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.searchRecordButton.Location = new System.Drawing.Point(104, 109);
			this.searchRecordButton.Name = "searchRecordButton";
			this.searchRecordButton.Size = new System.Drawing.Size(105, 35);
			this.searchRecordButton.TabIndex = 9;
			this.searchRecordButton.Text = "Найти";
			this.searchRecordButton.UseVisualStyleBackColor = true;
			this.searchRecordButton.Click += new System.EventHandler(this.SearchRecordButton_Click);
			// 
			// searchInfoRichTextBox
			// 
			this.searchInfoRichTextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.searchInfoRichTextBox.Location = new System.Drawing.Point(0, 162);
			this.searchInfoRichTextBox.Name = "searchInfoRichTextBox";
			this.searchInfoRichTextBox.ReadOnly = true;
			this.searchInfoRichTextBox.Size = new System.Drawing.Size(332, 91);
			this.searchInfoRichTextBox.TabIndex = 11;
			this.searchInfoRichTextBox.Text = "";
			// 
			// SearchDateRecordForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.cancelButton;
			this.ClientSize = new System.Drawing.Size(332, 253);
			this.Controls.Add(this.searchInfoRichTextBox);
			this.Controls.Add(this.inputTimeTextBox);
			this.Controls.Add(this.inputDateTextBox);
			this.Controls.Add(this.inputTimeLabel);
			this.Controls.Add(this.inputDateLabel);
			this.Controls.Add(this.cancelButton);
			this.Controls.Add(this.searchRecordButton);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "SearchDateRecordForm";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "SearchDateRecordForm";
			this.Load += new System.EventHandler(this.SearchDateRecordForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		public System.Windows.Forms.MaskedTextBox inputTimeTextBox;
		public System.Windows.Forms.MaskedTextBox inputDateTextBox;
		private System.Windows.Forms.Label inputTimeLabel;
		private System.Windows.Forms.Label inputDateLabel;
		protected internal System.Windows.Forms.Button cancelButton;
		protected internal System.Windows.Forms.Button searchRecordButton;
		private System.Windows.Forms.RichTextBox searchInfoRichTextBox;
	}
}