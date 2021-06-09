
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
			this.CommonBookGridView = new System.Windows.Forms.DataGridView();
			this.BooksTabControl = new System.Windows.Forms.TabControl();
			this.MainTabPage = new System.Windows.Forms.TabPage();
			this.AlexeyTabPage = new System.Windows.Forms.TabPage();
			this.nameDateGrid = new System.Windows.Forms.DataGridView();
			this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TimeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.EgorTabPage = new System.Windows.Forms.TabPage();
			this.dataGridView2 = new System.Windows.Forms.DataGridView();
			this.AddRecordButton = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.button2 = new System.Windows.Forms.Button();
			this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
			this.button3 = new System.Windows.Forms.Button();
			this.openFileButton = new System.Windows.Forms.Button();
			this.newBookButton = new System.Windows.Forms.Button();
			this.saveFileButton = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.CommonBookGridView)).BeginInit();
			this.BooksTabControl.SuspendLayout();
			this.MainTabPage.SuspendLayout();
			this.AlexeyTabPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nameDateGrid)).BeginInit();
			this.EgorTabPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
			this.SuspendLayout();
			// 
			// CommonBookGridView
			// 
			this.CommonBookGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.CommonBookGridView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.CommonBookGridView.Location = new System.Drawing.Point(3, 3);
			this.CommonBookGridView.Name = "CommonBookGridView";
			this.CommonBookGridView.RowHeadersWidth = 51;
			this.CommonBookGridView.RowTemplate.Height = 29;
			this.CommonBookGridView.Size = new System.Drawing.Size(979, 610);
			this.CommonBookGridView.TabIndex = 0;
			// 
			// BooksTabControl
			// 
			this.BooksTabControl.Controls.Add(this.MainTabPage);
			this.BooksTabControl.Controls.Add(this.AlexeyTabPage);
			this.BooksTabControl.Controls.Add(this.EgorTabPage);
			this.BooksTabControl.Location = new System.Drawing.Point(12, 12);
			this.BooksTabControl.Name = "BooksTabControl";
			this.BooksTabControl.SelectedIndex = 0;
			this.BooksTabControl.Size = new System.Drawing.Size(993, 649);
			this.BooksTabControl.TabIndex = 1;
			// 
			// MainTabPage
			// 
			this.MainTabPage.Controls.Add(this.CommonBookGridView);
			this.MainTabPage.Location = new System.Drawing.Point(4, 29);
			this.MainTabPage.Name = "MainTabPage";
			this.MainTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.MainTabPage.Size = new System.Drawing.Size(985, 616);
			this.MainTabPage.TabIndex = 0;
			this.MainTabPage.Text = "Общая информация";
			this.MainTabPage.UseVisualStyleBackColor = true;
			// 
			// AlexeyTabPage
			// 
			this.AlexeyTabPage.Controls.Add(this.nameDateGrid);
			this.AlexeyTabPage.Location = new System.Drawing.Point(4, 29);
			this.AlexeyTabPage.Name = "AlexeyTabPage";
			this.AlexeyTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.AlexeyTabPage.Size = new System.Drawing.Size(985, 616);
			this.AlexeyTabPage.TabIndex = 1;
			this.AlexeyTabPage.Text = "Имя-дата-время";
			this.AlexeyTabPage.UseVisualStyleBackColor = true;
			// 
			// nameDateGrid
			// 
			this.nameDateGrid.AllowUserToAddRows = false;
			this.nameDateGrid.AllowUserToDeleteRows = false;
			this.nameDateGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.nameDateGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameColumn,
            this.TimeColumn});
			this.nameDateGrid.Dock = System.Windows.Forms.DockStyle.Fill;
			this.nameDateGrid.Location = new System.Drawing.Point(3, 3);
			this.nameDateGrid.Name = "nameDateGrid";
			this.nameDateGrid.RowHeadersWidth = 51;
			this.nameDateGrid.RowTemplate.Height = 29;
			this.nameDateGrid.Size = new System.Drawing.Size(979, 610);
			this.nameDateGrid.TabIndex = 1;
			this.nameDateGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.nameDataGrid_CellContentClick);
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
			this.EgorTabPage.Controls.Add(this.dataGridView2);
			this.EgorTabPage.Location = new System.Drawing.Point(4, 29);
			this.EgorTabPage.Name = "EgorTabPage";
			this.EgorTabPage.Size = new System.Drawing.Size(985, 616);
			this.EgorTabPage.TabIndex = 2;
			this.EgorTabPage.Text = "Категория-цвет";
			this.EgorTabPage.UseVisualStyleBackColor = true;
			// 
			// dataGridView2
			// 
			this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView2.Location = new System.Drawing.Point(0, 0);
			this.dataGridView2.Name = "dataGridView2";
			this.dataGridView2.RowHeadersWidth = 51;
			this.dataGridView2.RowTemplate.Height = 29;
			this.dataGridView2.Size = new System.Drawing.Size(985, 616);
			this.dataGridView2.TabIndex = 1;
			// 
			// AddRecordButton
			// 
			this.AddRecordButton.Location = new System.Drawing.Point(1057, 307);
			this.AddRecordButton.Name = "AddRecordButton";
			this.AddRecordButton.Size = new System.Drawing.Size(155, 29);
			this.AddRecordButton.TabIndex = 3;
			this.AddRecordButton.Text = "Добавить запись...";
			this.AddRecordButton.UseVisualStyleBackColor = true;
			this.AddRecordButton.Click += new System.EventHandler(this.button1_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(1057, 342);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(155, 29);
			this.button1.TabIndex = 3;
			this.button1.Text = "Удалить запись...";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// openFileDialog
			// 
			this.openFileDialog.DefaultExt = "txt";
			this.openFileDialog.InitialDirectory = "C:\\Users\\fosti\\source\\repos\\Fostiriy\\University\\CW_ThoughtsOutLoud";
			this.openFileDialog.Title = "Открыть файл-справочник";
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(1057, 377);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(155, 29);
			this.button2.TabIndex = 3;
			this.button2.Text = "Найти...";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button1_Click);
			// 
			// saveFileDialog
			// 
			this.saveFileDialog.DefaultExt = "txt";
			this.saveFileDialog.FileName = "saveFileName";
			this.saveFileDialog.InitialDirectory = "C:\\Users\\fosti\\source\\repos\\Fostiriy\\University\\CW_ThoughtsOutLoud";
			this.saveFileDialog.Title = "Сохранить справочник в файл";
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(1057, 461);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(155, 58);
			this.button3.TabIndex = 3;
			this.button3.Text = "Показать окно отладки";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button1_Click);
			// 
			// openFileButton
			// 
			this.openFileButton.Location = new System.Drawing.Point(1057, 153);
			this.openFileButton.Name = "openFileButton";
			this.openFileButton.Size = new System.Drawing.Size(155, 29);
			this.openFileButton.TabIndex = 3;
			this.openFileButton.Text = "Открыть...";
			this.openFileButton.UseVisualStyleBackColor = true;
			this.openFileButton.Click += new System.EventHandler(this.button1_Click);
			// 
			// newBookButton
			// 
			this.newBookButton.Location = new System.Drawing.Point(1057, 188);
			this.newBookButton.Name = "newBookButton";
			this.newBookButton.Size = new System.Drawing.Size(155, 29);
			this.newBookButton.TabIndex = 3;
			this.newBookButton.Text = "Новый...";
			this.newBookButton.UseVisualStyleBackColor = true;
			this.newBookButton.Click += new System.EventHandler(this.button1_Click);
			// 
			// saveFileButton
			// 
			this.saveFileButton.Location = new System.Drawing.Point(1057, 223);
			this.saveFileButton.Name = "saveFileButton";
			this.saveFileButton.Size = new System.Drawing.Size(155, 29);
			this.saveFileButton.TabIndex = 3;
			this.saveFileButton.Text = "Сохранить как...";
			this.saveFileButton.UseVisualStyleBackColor = true;
			this.saveFileButton.Click += new System.EventHandler(this.saveFileButton_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(1262, 673);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.saveFileButton);
			this.Controls.Add(this.newBookButton);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.openFileButton);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.AddRecordButton);
			this.Controls.Add(this.BooksTabControl);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Мысли вслух";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.CommonBookGridView)).EndInit();
			this.BooksTabControl.ResumeLayout(false);
			this.MainTabPage.ResumeLayout(false);
			this.AlexeyTabPage.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.nameDateGrid)).EndInit();
			this.EgorTabPage.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView CommonBookGridView;
		private System.Windows.Forms.TabControl BooksTabControl;
		private System.Windows.Forms.TabPage MainTabPage;
		private System.Windows.Forms.TabPage AlexeyTabPage;
		private System.Windows.Forms.TabPage EgorTabPage;
		private System.Windows.Forms.DataGridView nameDateGrid;
		private System.Windows.Forms.DataGridView dataGridView2;
		private System.Windows.Forms.Button AddRecordButton;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.OpenFileDialog openFileDialog;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.SaveFileDialog saveFileDialog;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button openFileButton;
		private System.Windows.Forms.Button newBookButton;
		private System.Windows.Forms.Button saveFileButton;
		private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn TimeColumn;
	}
}

