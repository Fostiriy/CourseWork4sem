
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
			this.booksTabControl = new System.Windows.Forms.TabControl();
			this.mainTabPage = new System.Windows.Forms.TabPage();
			this.mainGrid = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CategoryColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColorColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dateNameTabPage = new System.Windows.Forms.TabPage();
			this.dateNameGrid = new System.Windows.Forms.DataGridView();
			this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TimeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.categoryColorTabPage = new System.Windows.Forms.TabPage();
			this.categoryColorGrid = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
			this.booksTabControl.SuspendLayout();
			this.mainTabPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.mainGrid)).BeginInit();
			this.dateNameTabPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dateNameGrid)).BeginInit();
			this.categoryColorTabPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.categoryColorGrid)).BeginInit();
			this.fileWorkingBox.SuspendLayout();
			this.bookWorkingBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// booksTabControl
			// 
			this.booksTabControl.Controls.Add(this.mainTabPage);
			this.booksTabControl.Controls.Add(this.dateNameTabPage);
			this.booksTabControl.Controls.Add(this.categoryColorTabPage);
			this.booksTabControl.Dock = System.Windows.Forms.DockStyle.Left;
			this.booksTabControl.Location = new System.Drawing.Point(0, 0);
			this.booksTabControl.Name = "booksTabControl";
			this.booksTabControl.SelectedIndex = 0;
			this.booksTabControl.Size = new System.Drawing.Size(993, 673);
			this.booksTabControl.TabIndex = 1;
			// 
			// mainTabPage
			// 
			this.mainTabPage.Controls.Add(this.mainGrid);
			this.mainTabPage.Location = new System.Drawing.Point(4, 29);
			this.mainTabPage.Name = "mainTabPage";
			this.mainTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.mainTabPage.Size = new System.Drawing.Size(985, 640);
			this.mainTabPage.TabIndex = 0;
			this.mainTabPage.Text = "Общая информация";
			this.mainTabPage.UseVisualStyleBackColor = true;
			// 
			// mainGrid
			// 
			this.mainGrid.AllowUserToAddRows = false;
			this.mainGrid.AllowUserToDeleteRows = false;
			this.mainGrid.AllowUserToResizeColumns = false;
			this.mainGrid.AllowUserToResizeRows = false;
			this.mainGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.mainGrid.BackgroundColor = System.Drawing.SystemColors.Menu;
			this.mainGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.mainGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.CategoryColumn,
            this.ColorColumn});
			this.mainGrid.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mainGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.mainGrid.Location = new System.Drawing.Point(3, 3);
			this.mainGrid.MultiSelect = false;
			this.mainGrid.Name = "mainGrid";
			this.mainGrid.RowHeadersVisible = false;
			this.mainGrid.RowHeadersWidth = 51;
			this.mainGrid.RowTemplate.Height = 29;
			this.mainGrid.Size = new System.Drawing.Size(979, 634);
			this.mainGrid.TabIndex = 2;
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.HeaderText = "Имя аудиозаписи";
			this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.HeaderText = "Дата и время записи";
			this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			// 
			// CategoryColumn
			// 
			this.CategoryColumn.HeaderText = "Категория";
			this.CategoryColumn.MinimumWidth = 6;
			this.CategoryColumn.Name = "CategoryColumn";
			this.CategoryColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			// 
			// ColorColumn
			// 
			this.ColorColumn.HeaderText = "Цвет категории";
			this.ColorColumn.MinimumWidth = 6;
			this.ColorColumn.Name = "ColorColumn";
			this.ColorColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			// 
			// dateNameTabPage
			// 
			this.dateNameTabPage.Controls.Add(this.dateNameGrid);
			this.dateNameTabPage.Location = new System.Drawing.Point(4, 29);
			this.dateNameTabPage.Name = "dateNameTabPage";
			this.dateNameTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.dateNameTabPage.Size = new System.Drawing.Size(985, 640);
			this.dateNameTabPage.TabIndex = 1;
			this.dateNameTabPage.Text = "Имя-дата-время";
			this.dateNameTabPage.UseVisualStyleBackColor = true;
			// 
			// dateNameGrid
			// 
			this.dateNameGrid.AllowUserToAddRows = false;
			this.dateNameGrid.AllowUserToDeleteRows = false;
			this.dateNameGrid.AllowUserToResizeColumns = false;
			this.dateNameGrid.AllowUserToResizeRows = false;
			this.dateNameGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dateNameGrid.BackgroundColor = System.Drawing.SystemColors.Menu;
			this.dateNameGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dateNameGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameColumn,
            this.TimeColumn});
			this.dateNameGrid.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dateNameGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.dateNameGrid.Location = new System.Drawing.Point(3, 3);
			this.dateNameGrid.MultiSelect = false;
			this.dateNameGrid.Name = "dateNameGrid";
			this.dateNameGrid.RowHeadersVisible = false;
			this.dateNameGrid.RowHeadersWidth = 51;
			this.dateNameGrid.RowTemplate.Height = 29;
			this.dateNameGrid.Size = new System.Drawing.Size(979, 634);
			this.dateNameGrid.TabIndex = 1;
			// 
			// NameColumn
			// 
			this.NameColumn.HeaderText = "Имя аудиозаписи";
			this.NameColumn.MinimumWidth = 6;
			this.NameColumn.Name = "NameColumn";
			this.NameColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			// 
			// TimeColumn
			// 
			this.TimeColumn.HeaderText = "Дата и время записи";
			this.TimeColumn.MinimumWidth = 6;
			this.TimeColumn.Name = "TimeColumn";
			this.TimeColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			// 
			// categoryColorTabPage
			// 
			this.categoryColorTabPage.Controls.Add(this.categoryColorGrid);
			this.categoryColorTabPage.Location = new System.Drawing.Point(4, 29);
			this.categoryColorTabPage.Name = "categoryColorTabPage";
			this.categoryColorTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.categoryColorTabPage.Size = new System.Drawing.Size(985, 640);
			this.categoryColorTabPage.TabIndex = 3;
			this.categoryColorTabPage.Text = "Категория-цвет";
			this.categoryColorTabPage.UseVisualStyleBackColor = true;
			// 
			// categoryColorGrid
			// 
			this.categoryColorGrid.AllowUserToAddRows = false;
			this.categoryColorGrid.AllowUserToDeleteRows = false;
			this.categoryColorGrid.AllowUserToResizeColumns = false;
			this.categoryColorGrid.AllowUserToResizeRows = false;
			this.categoryColorGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.categoryColorGrid.BackgroundColor = System.Drawing.SystemColors.Menu;
			this.categoryColorGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.categoryColorGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
			this.categoryColorGrid.Dock = System.Windows.Forms.DockStyle.Fill;
			this.categoryColorGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.categoryColorGrid.Location = new System.Drawing.Point(3, 3);
			this.categoryColorGrid.MultiSelect = false;
			this.categoryColorGrid.Name = "categoryColorGrid";
			this.categoryColorGrid.RowHeadersVisible = false;
			this.categoryColorGrid.RowHeadersWidth = 51;
			this.categoryColorGrid.RowTemplate.Height = 29;
			this.categoryColorGrid.Size = new System.Drawing.Size(979, 634);
			this.categoryColorGrid.TabIndex = 3;
			// 
			// dataGridViewTextBoxColumn5
			// 
			this.dataGridViewTextBoxColumn5.HeaderText = "Название категории";
			this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
			this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
			this.dataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			// 
			// dataGridViewTextBoxColumn6
			// 
			this.dataGridViewTextBoxColumn6.HeaderText = "Цвет категории";
			this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
			this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
			this.dataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			// 
			// addRecordButton
			// 
			this.addRecordButton.Location = new System.Drawing.Point(45, 29);
			this.addRecordButton.Name = "addRecordButton";
			this.addRecordButton.Size = new System.Drawing.Size(160, 35);
			this.addRecordButton.TabIndex = 3;
			this.addRecordButton.Text = "Добавить запись...";
			this.addRecordButton.UseVisualStyleBackColor = true;
			this.addRecordButton.Click += new System.EventHandler(this.AddRecordButton_Click);
			// 
			// deleteRecordButton
			// 
			this.deleteRecordButton.Location = new System.Drawing.Point(45, 75);
			this.deleteRecordButton.Name = "deleteRecordButton";
			this.deleteRecordButton.Size = new System.Drawing.Size(160, 35);
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
			this.button2.Location = new System.Drawing.Point(45, 121);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(160, 35);
			this.button2.TabIndex = 3;
			this.button2.Text = "Найти...";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.SearchRecordButton_Click);
			// 
			// saveFileDialog
			// 
			this.saveFileDialog.DefaultExt = "txt";
			this.saveFileDialog.FileName = "CW output";
			this.saveFileDialog.InitialDirectory = "C:\\Users\\fosti\\source\\repos\\Fostiriy\\University\\CW_ThoughtsOutLoud";
			this.saveFileDialog.Title = "Сохранить справочник в файл";
			// 
			// showDebugButton
			// 
			this.showDebugButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.showDebugButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.showDebugButton.Location = new System.Drawing.Point(1000, 606);
			this.showDebugButton.Name = "showDebugButton";
			this.showDebugButton.Size = new System.Drawing.Size(250, 60);
			this.showDebugButton.TabIndex = 3;
			this.showDebugButton.Text = "Показать окно отладки";
			this.showDebugButton.UseVisualStyleBackColor = true;
			this.showDebugButton.Click += new System.EventHandler(this.ShowDebugButton_Click);
			// 
			// openFileButton
			// 
			this.openFileButton.Location = new System.Drawing.Point(45, 26);
			this.openFileButton.Name = "openFileButton";
			this.openFileButton.Size = new System.Drawing.Size(160, 35);
			this.openFileButton.TabIndex = 3;
			this.openFileButton.Text = "Открыть...";
			this.openFileButton.UseVisualStyleBackColor = true;
			this.openFileButton.Click += new System.EventHandler(this.OpenFileButton_Click);
			// 
			// newBookButton
			// 
			this.newBookButton.Location = new System.Drawing.Point(45, 167);
			this.newBookButton.Name = "newBookButton";
			this.newBookButton.Size = new System.Drawing.Size(160, 35);
			this.newBookButton.TabIndex = 3;
			this.newBookButton.Text = "Очистить";
			this.newBookButton.UseVisualStyleBackColor = true;
			this.newBookButton.Click += new System.EventHandler(this.NewBookButton_Click);
			// 
			// saveFileButton
			// 
			this.saveFileButton.Location = new System.Drawing.Point(45, 67);
			this.saveFileButton.Name = "saveFileButton";
			this.saveFileButton.Size = new System.Drawing.Size(160, 35);
			this.saveFileButton.TabIndex = 3;
			this.saveFileButton.Text = "Сохранить как...";
			this.saveFileButton.UseVisualStyleBackColor = true;
			this.saveFileButton.Click += new System.EventHandler(this.SaveFileButton_Click);
			// 
			// fileWorkingBox
			// 
			this.fileWorkingBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.fileWorkingBox.Controls.Add(this.saveFileButton);
			this.fileWorkingBox.Controls.Add(this.openFileButton);
			this.fileWorkingBox.Location = new System.Drawing.Point(1000, 29);
			this.fileWorkingBox.Name = "fileWorkingBox";
			this.fileWorkingBox.Size = new System.Drawing.Size(250, 130);
			this.fileWorkingBox.TabIndex = 4;
			this.fileWorkingBox.TabStop = false;
			this.fileWorkingBox.Text = "Работа с файлом";
			// 
			// bookWorkingBox
			// 
			this.bookWorkingBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.bookWorkingBox.Controls.Add(this.button2);
			this.bookWorkingBox.Controls.Add(this.newBookButton);
			this.bookWorkingBox.Controls.Add(this.deleteRecordButton);
			this.bookWorkingBox.Controls.Add(this.addRecordButton);
			this.bookWorkingBox.Location = new System.Drawing.Point(999, 165);
			this.bookWorkingBox.Name = "bookWorkingBox";
			this.bookWorkingBox.Size = new System.Drawing.Size(250, 230);
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
			this.Controls.Add(this.booksTabControl);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.Text = "Мысли вслух";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.LocationChanged += new System.EventHandler(this.MainForm_LocationChanged);
			this.booksTabControl.ResumeLayout(false);
			this.mainTabPage.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.mainGrid)).EndInit();
			this.dateNameTabPage.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dateNameGrid)).EndInit();
			this.categoryColorTabPage.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.categoryColorGrid)).EndInit();
			this.fileWorkingBox.ResumeLayout(false);
			this.bookWorkingBox.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.TabControl booksTabControl;
		private System.Windows.Forms.TabPage mainTabPage;
		private System.Windows.Forms.TabPage dateNameTabPage;
		private System.Windows.Forms.Button addRecordButton;
		private System.Windows.Forms.Button deleteRecordButton;
		private System.Windows.Forms.OpenFileDialog openFileDialog;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.SaveFileDialog saveFileDialog;
		private System.Windows.Forms.Button openFileButton;
		private System.Windows.Forms.Button newBookButton;
		private System.Windows.Forms.Button saveFileButton;
		private System.Windows.Forms.GroupBox fileWorkingBox;
		private System.Windows.Forms.GroupBox bookWorkingBox;
		private System.Windows.Forms.DataGridView mainGrid;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private System.Windows.Forms.DataGridViewTextBoxColumn CategoryColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColorColumn;
		private System.Windows.Forms.TabPage categoryColorTabPage;
		private System.Windows.Forms.DataGridView categoryColorGrid;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
		private System.Windows.Forms.DataGridView dateNameGrid;
		private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn TimeColumn;
		internal System.Windows.Forms.Button showDebugButton;
	}
}

