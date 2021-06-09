﻿
namespace CW_ThoughtsOutLoud
{
	partial class MainForm
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.BooksTabControl = new System.Windows.Forms.TabControl();
			this.MainTabPage = new System.Windows.Forms.TabPage();
			this.dataGridView2 = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.AlexeyTabPage = new System.Windows.Forms.TabPage();
			this.nameDateGrid = new System.Windows.Forms.DataGridView();
			this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TimeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.EgorTabPage = new System.Windows.Forms.TabPage();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.addRecordButton = new System.Windows.Forms.Button();
			this.deleteRecordButton = new System.Windows.Forms.Button();
			this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.button2 = new System.Windows.Forms.Button();
			this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
			this.showDebugButton = new System.Windows.Forms.Button();
			this.openFileButton = new System.Windows.Forms.Button();
			this.newBookButton = new System.Windows.Forms.Button();
			this.saveFileButton = new System.Windows.Forms.Button();
			this.fileWorkingBox = new System.Windows.Forms.GroupBox();
			this.bookWorkingBox = new System.Windows.Forms.GroupBox();
			this.BooksTabControl.SuspendLayout();
			this.MainTabPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
			this.AlexeyTabPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nameDateGrid)).BeginInit();
			this.EgorTabPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.fileWorkingBox.SuspendLayout();
			this.bookWorkingBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// BooksTabControl
			// 
			this.BooksTabControl.Controls.Add(this.MainTabPage);
			this.BooksTabControl.Controls.Add(this.AlexeyTabPage);
			this.BooksTabControl.Controls.Add(this.EgorTabPage);
			this.BooksTabControl.Dock = System.Windows.Forms.DockStyle.Left;
			this.BooksTabControl.Location = new System.Drawing.Point(0, 0);
			this.BooksTabControl.Name = "BooksTabControl";
			this.BooksTabControl.SelectedIndex = 0;
			this.BooksTabControl.Size = new System.Drawing.Size(993, 673);
			this.BooksTabControl.TabIndex = 1;
			// 
			// MainTabPage
			// 
			this.MainTabPage.Controls.Add(this.dataGridView2);
			this.MainTabPage.Location = new System.Drawing.Point(4, 29);
			this.MainTabPage.Name = "MainTabPage";
			this.MainTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.MainTabPage.Size = new System.Drawing.Size(985, 640);
			this.MainTabPage.TabIndex = 0;
			this.MainTabPage.Text = "Общая информация";
			this.MainTabPage.UseVisualStyleBackColor = true;
			// 
			// dataGridView2
			// 
			this.dataGridView2.AllowUserToAddRows = false;
			this.dataGridView2.AllowUserToDeleteRows = false;
			this.dataGridView2.AllowUserToResizeColumns = false;
			this.dataGridView2.AllowUserToResizeRows = false;
			this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
			this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView2.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.dataGridView2.Location = new System.Drawing.Point(3, 3);
			this.dataGridView2.Name = "dataGridView2";
			this.dataGridView2.RowHeadersWidth = 51;
			this.dataGridView2.RowTemplate.Height = 29;
			this.dataGridView2.Size = new System.Drawing.Size(979, 634);
			this.dataGridView2.TabIndex = 2;
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn3.HeaderText = "Имя аудиозаписи";
			this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn4.HeaderText = "Дата и время записи";
			this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			// 
			// AlexeyTabPage
			// 
			this.AlexeyTabPage.Controls.Add(this.nameDateGrid);
			this.AlexeyTabPage.Location = new System.Drawing.Point(4, 29);
			this.AlexeyTabPage.Name = "AlexeyTabPage";
			this.AlexeyTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.AlexeyTabPage.Size = new System.Drawing.Size(985, 640);
			this.AlexeyTabPage.TabIndex = 1;
			this.AlexeyTabPage.Text = "Имя-дата-время";
			this.AlexeyTabPage.UseVisualStyleBackColor = true;
			// 
			// nameDateGrid
			// 
			this.nameDateGrid.AllowUserToAddRows = false;
			this.nameDateGrid.AllowUserToDeleteRows = false;
			this.nameDateGrid.AllowUserToResizeColumns = false;
			this.nameDateGrid.AllowUserToResizeRows = false;
			this.nameDateGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.nameDateGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.nameDateGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameColumn,
            this.TimeColumn});
			this.nameDateGrid.Dock = System.Windows.Forms.DockStyle.Fill;
			this.nameDateGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.nameDateGrid.Location = new System.Drawing.Point(3, 3);
			this.nameDateGrid.Name = "nameDateGrid";
			this.nameDateGrid.RowHeadersWidth = 51;
			this.nameDateGrid.RowTemplate.Height = 29;
			this.nameDateGrid.Size = new System.Drawing.Size(979, 634);
			this.nameDateGrid.TabIndex = 1;
			this.nameDateGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.NameDataGrid_CellContentClick);
			// 
			// NameColumn
			// 
			this.NameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.NameColumn.HeaderText = "Имя аудиозаписи";
			this.NameColumn.MinimumWidth = 6;
			this.NameColumn.Name = "NameColumn";
			this.NameColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			// 
			// TimeColumn
			// 
			this.TimeColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.TimeColumn.HeaderText = "Дата и время записи";
			this.TimeColumn.MinimumWidth = 6;
			this.TimeColumn.Name = "TimeColumn";
			this.TimeColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			// 
			// EgorTabPage
			// 
			this.EgorTabPage.Controls.Add(this.dataGridView1);
			this.EgorTabPage.Location = new System.Drawing.Point(4, 29);
			this.EgorTabPage.Name = "EgorTabPage";
			this.EgorTabPage.Size = new System.Drawing.Size(985, 640);
			this.EgorTabPage.TabIndex = 2;
			this.EgorTabPage.Text = "Категория-цвет";
			this.EgorTabPage.UseVisualStyleBackColor = true;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AllowUserToResizeColumns = false;
			this.dataGridView1.AllowUserToResizeRows = false;
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.dataGridView1.Location = new System.Drawing.Point(0, 0);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 29;
			this.dataGridView1.Size = new System.Drawing.Size(985, 640);
			this.dataGridView1.TabIndex = 3;
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn1.HeaderText = "Имя аудиозаписи";
			this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn2.HeaderText = "Дата и время записи";
			this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			// 
			// addRecordButton
			// 
			this.addRecordButton.Location = new System.Drawing.Point(36, 40);
			this.addRecordButton.Name = "addRecordButton";
			this.addRecordButton.Size = new System.Drawing.Size(155, 29);
			this.addRecordButton.TabIndex = 3;
			this.addRecordButton.Text = "Добавить запись...";
			this.addRecordButton.UseVisualStyleBackColor = true;
			this.addRecordButton.Click += new System.EventHandler(this.AddRecordButton_Click);
			// 
			// deleteRecordButton
			// 
			this.deleteRecordButton.Location = new System.Drawing.Point(36, 86);
			this.deleteRecordButton.Name = "deleteRecordButton";
			this.deleteRecordButton.Size = new System.Drawing.Size(155, 29);
			this.deleteRecordButton.TabIndex = 3;
			this.deleteRecordButton.Text = "Удалить запись...";
			this.deleteRecordButton.UseVisualStyleBackColor = true;
			this.deleteRecordButton.Click += new System.EventHandler(this.DeleteRecordButton_Click);
			// 
			// openFileDialog
			// 
			this.openFileDialog.DefaultExt = "txt";
			this.openFileDialog.InitialDirectory = "C:\\Users\\fosti\\source\\repos\\Fostiriy\\University\\CW_ThoughtsOutLoud";
			this.openFileDialog.Title = "Открыть файл-справочник";
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(36, 132);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(155, 29);
			this.button2.TabIndex = 3;
			this.button2.Text = "Найти...";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.SearchRecordButton_Click);
			// 
			// saveFileDialog
			// 
			this.saveFileDialog.DefaultExt = "txt";
			this.saveFileDialog.FileName = "saveFileName";
			this.saveFileDialog.InitialDirectory = "C:\\Users\\fosti\\source\\repos\\Fostiriy\\University\\CW_ThoughtsOutLoud";
			this.saveFileDialog.Title = "Сохранить справочник в файл";
			// 
			// showDebugButton
			// 
			this.showDebugButton.Location = new System.Drawing.Point(1014, 525);
			this.showDebugButton.Name = "showDebugButton";
			this.showDebugButton.Size = new System.Drawing.Size(226, 58);
			this.showDebugButton.TabIndex = 3;
			this.showDebugButton.Text = "Показать окно отладки";
			this.showDebugButton.UseVisualStyleBackColor = true;
			this.showDebugButton.Click += new System.EventHandler(this.ShowDebugButton_Click);
			// 
			// openFileButton
			// 
			this.openFileButton.Location = new System.Drawing.Point(36, 30);
			this.openFileButton.Name = "openFileButton";
			this.openFileButton.Size = new System.Drawing.Size(155, 29);
			this.openFileButton.TabIndex = 3;
			this.openFileButton.Text = "Открыть...";
			this.openFileButton.UseVisualStyleBackColor = true;
			this.openFileButton.Click += new System.EventHandler(this.OpenFileButton_Click);
			// 
			// newBookButton
			// 
			this.newBookButton.Location = new System.Drawing.Point(36, 178);
			this.newBookButton.Name = "newBookButton";
			this.newBookButton.Size = new System.Drawing.Size(155, 29);
			this.newBookButton.TabIndex = 3;
			this.newBookButton.Text = "Очистить";
			this.newBookButton.UseVisualStyleBackColor = true;
			this.newBookButton.Click += new System.EventHandler(this.NewBookButton_Click);
			// 
			// saveFileButton
			// 
			this.saveFileButton.Location = new System.Drawing.Point(36, 74);
			this.saveFileButton.Name = "saveFileButton";
			this.saveFileButton.Size = new System.Drawing.Size(155, 29);
			this.saveFileButton.TabIndex = 3;
			this.saveFileButton.Text = "Сохранить как...";
			this.saveFileButton.UseVisualStyleBackColor = true;
			this.saveFileButton.Click += new System.EventHandler(this.SaveFileButton_Click);
			// 
			// fileWorkingBox
			// 
			this.fileWorkingBox.Controls.Add(this.saveFileButton);
			this.fileWorkingBox.Controls.Add(this.openFileButton);
			this.fileWorkingBox.Location = new System.Drawing.Point(1014, 89);
			this.fileWorkingBox.Name = "fileWorkingBox";
			this.fileWorkingBox.Size = new System.Drawing.Size(226, 132);
			this.fileWorkingBox.TabIndex = 4;
			this.fileWorkingBox.TabStop = false;
			this.fileWorkingBox.Text = "Работа с файлом";
			// 
			// bookWorkingBox
			// 
			this.bookWorkingBox.Controls.Add(this.button2);
			this.bookWorkingBox.Controls.Add(this.newBookButton);
			this.bookWorkingBox.Controls.Add(this.deleteRecordButton);
			this.bookWorkingBox.Controls.Add(this.addRecordButton);
			this.bookWorkingBox.Location = new System.Drawing.Point(1014, 247);
			this.bookWorkingBox.Name = "bookWorkingBox";
			this.bookWorkingBox.Size = new System.Drawing.Size(226, 246);
			this.bookWorkingBox.TabIndex = 5;
			this.bookWorkingBox.TabStop = false;
			this.bookWorkingBox.Text = "Работа со справочником";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(1262, 673);
			this.Controls.Add(this.bookWorkingBox);
			this.Controls.Add(this.fileWorkingBox);
			this.Controls.Add(this.showDebugButton);
			this.Controls.Add(this.BooksTabControl);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Мысли вслух";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.BooksTabControl.ResumeLayout(false);
			this.MainTabPage.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
			this.AlexeyTabPage.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.nameDateGrid)).EndInit();
			this.EgorTabPage.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.fileWorkingBox.ResumeLayout(false);
			this.bookWorkingBox.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.TabControl BooksTabControl;
		private System.Windows.Forms.TabPage MainTabPage;
		private System.Windows.Forms.TabPage AlexeyTabPage;
		private System.Windows.Forms.TabPage EgorTabPage;
		private System.Windows.Forms.DataGridView nameDateGrid;
		private System.Windows.Forms.Button addRecordButton;
		private System.Windows.Forms.Button deleteRecordButton;
		private System.Windows.Forms.OpenFileDialog openFileDialog;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.SaveFileDialog saveFileDialog;
		private System.Windows.Forms.Button showDebugButton;
		private System.Windows.Forms.Button openFileButton;
		private System.Windows.Forms.Button newBookButton;
		private System.Windows.Forms.Button saveFileButton;
		private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn TimeColumn;
		private System.Windows.Forms.DataGridView dataGridView2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private System.Windows.Forms.GroupBox fileWorkingBox;
		private System.Windows.Forms.GroupBox bookWorkingBox;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
	}
}

