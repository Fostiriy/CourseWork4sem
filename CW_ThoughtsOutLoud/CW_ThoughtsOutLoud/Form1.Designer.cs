
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
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.AlexeyTabPage = new System.Windows.Forms.TabPage();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.EgorTabPage = new System.Windows.Forms.TabPage();
			this.dataGridView2 = new System.Windows.Forms.DataGridView();
			this.MainTabPage = new System.Windows.Forms.TabPage();
			this.MainMenuStrip = new System.Windows.Forms.MenuStrip();
			this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.сохранитьКакToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.отладкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.AddRecordButton = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.CommonBookGridView)).BeginInit();
			this.tabControl1.SuspendLayout();
			this.AlexeyTabPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.EgorTabPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
			this.MainTabPage.SuspendLayout();
			this.MainMenuStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// CommonBookGridView
			// 
			this.CommonBookGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.CommonBookGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.CommonBookGridView.Location = new System.Drawing.Point(6, 6);
			this.CommonBookGridView.Name = "CommonBookGridView";
			this.CommonBookGridView.RowHeadersWidth = 51;
			this.CommonBookGridView.RowTemplate.Height = 29;
			this.CommonBookGridView.Size = new System.Drawing.Size(1218, 553);
			this.CommonBookGridView.TabIndex = 0;
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.AlexeyTabPage);
			this.tabControl1.Controls.Add(this.EgorTabPage);
			this.tabControl1.Controls.Add(this.MainTabPage);
			this.tabControl1.Location = new System.Drawing.Point(12, 31);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(1238, 595);
			this.tabControl1.TabIndex = 1;
			// 
			// AlexeyTabPage
			// 
			this.AlexeyTabPage.Controls.Add(this.dataGridView1);
			this.AlexeyTabPage.Location = new System.Drawing.Point(4, 29);
			this.AlexeyTabPage.Name = "AlexeyTabPage";
			this.AlexeyTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.AlexeyTabPage.Size = new System.Drawing.Size(1230, 562);
			this.AlexeyTabPage.TabIndex = 1;
			this.AlexeyTabPage.Text = "Имя-дата-время";
			this.AlexeyTabPage.UseVisualStyleBackColor = true;
			// 
			// dataGridView1
			// 
			this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(6, 6);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 29;
			this.dataGridView1.Size = new System.Drawing.Size(1218, 553);
			this.dataGridView1.TabIndex = 1;
			// 
			// EgorTabPage
			// 
			this.EgorTabPage.Controls.Add(this.dataGridView2);
			this.EgorTabPage.Location = new System.Drawing.Point(4, 29);
			this.EgorTabPage.Name = "EgorTabPage";
			this.EgorTabPage.Size = new System.Drawing.Size(1230, 562);
			this.EgorTabPage.TabIndex = 2;
			this.EgorTabPage.Text = "Категория-цвет";
			this.EgorTabPage.UseVisualStyleBackColor = true;
			// 
			// dataGridView2
			// 
			this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView2.Location = new System.Drawing.Point(6, 6);
			this.dataGridView2.Name = "dataGridView2";
			this.dataGridView2.RowHeadersWidth = 51;
			this.dataGridView2.RowTemplate.Height = 29;
			this.dataGridView2.Size = new System.Drawing.Size(1218, 553);
			this.dataGridView2.TabIndex = 1;
			// 
			// MainTabPage
			// 
			this.MainTabPage.Controls.Add(this.CommonBookGridView);
			this.MainTabPage.Location = new System.Drawing.Point(4, 29);
			this.MainTabPage.Name = "MainTabPage";
			this.MainTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.MainTabPage.Size = new System.Drawing.Size(1230, 562);
			this.MainTabPage.TabIndex = 0;
			this.MainTabPage.Text = "Общая информация";
			this.MainTabPage.UseVisualStyleBackColor = true;
			// 
			// MainMenuStrip
			// 
			this.MainMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.MainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.отладкаToolStripMenuItem});
			this.MainMenuStrip.Location = new System.Drawing.Point(0, 0);
			this.MainMenuStrip.Name = "MainMenuStrip";
			this.MainMenuStrip.Size = new System.Drawing.Size(1262, 28);
			this.MainMenuStrip.TabIndex = 2;
			this.MainMenuStrip.Text = "menuStrip1";
			// 
			// файлToolStripMenuItem
			// 
			this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.toolStripMenuItem1,
            this.сохранитьКакToolStripMenuItem});
			this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
			this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
			this.файлToolStripMenuItem.Text = "Файл";
			// 
			// открытьToolStripMenuItem
			// 
			this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
			this.открытьToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
			this.открытьToolStripMenuItem.Text = "Открыть...";
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(201, 26);
			this.toolStripMenuItem1.Text = "Новый...";
			// 
			// сохранитьКакToolStripMenuItem
			// 
			this.сохранитьКакToolStripMenuItem.Name = "сохранитьКакToolStripMenuItem";
			this.сохранитьКакToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
			this.сохранитьКакToolStripMenuItem.Text = "Сохранить как...";
			// 
			// отладкаToolStripMenuItem
			// 
			this.отладкаToolStripMenuItem.Name = "отладкаToolStripMenuItem";
			this.отладкаToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
			this.отладкаToolStripMenuItem.Text = "Отладка";
			// 
			// AddRecordButton
			// 
			this.AddRecordButton.Location = new System.Drawing.Point(12, 632);
			this.AddRecordButton.Name = "AddRecordButton";
			this.AddRecordButton.Size = new System.Drawing.Size(155, 29);
			this.AddRecordButton.TabIndex = 3;
			this.AddRecordButton.Text = "Добавить запись...";
			this.AddRecordButton.UseVisualStyleBackColor = true;
			this.AddRecordButton.Click += new System.EventHandler(this.button1_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(173, 632);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(155, 29);
			this.button1.TabIndex = 3;
			this.button1.Text = "Удалить запись...";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(334, 632);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(155, 29);
			this.button2.TabIndex = 3;
			this.button2.Text = "Найти...";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button1_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(1262, 673);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.AddRecordButton);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.MainMenuStrip);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.MainMenuStrip;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Мысли вслух";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.CommonBookGridView)).EndInit();
			this.tabControl1.ResumeLayout(false);
			this.AlexeyTabPage.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.EgorTabPage.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
			this.MainTabPage.ResumeLayout(false);
			this.MainMenuStrip.ResumeLayout(false);
			this.MainMenuStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView CommonBookGridView;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage MainTabPage;
		private System.Windows.Forms.TabPage AlexeyTabPage;
		private System.Windows.Forms.TabPage EgorTabPage;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridView dataGridView2;
		private System.Windows.Forms.MenuStrip MainMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem сохранитьКакToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem отладкаToolStripMenuItem;
		private System.Windows.Forms.Button AddRecordButton;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
	}
}

