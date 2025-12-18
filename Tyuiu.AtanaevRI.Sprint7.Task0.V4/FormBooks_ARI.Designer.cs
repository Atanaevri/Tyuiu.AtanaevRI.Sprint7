namespace Tyuiu.AtanaevRI.Sprint7.Task0.V4
{
    partial class FormBooks_ARI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBooks_ARI));
            panelBooksTop_ARI = new Panel();
            buttonExportBooks_ARI = new Button();
            buttonRefreshBooks_ARI = new Button();
            comboBoxSortBook_ARI = new ComboBox();
            labelSortBy_ARI = new Label();
            buttonSearchBook_ARI = new Button();
            textBoxSearchBook_ARI = new TextBox();
            labelSearchBook_ARI = new Label();
            labelBooksCount_ARI = new Label();
            panelBooksButtons_ARI = new Panel();
            buttonAddBook_ARI = new Button();
            buttonEditBook_ARI = new Button();
            buttonDeleteBook_ARI = new Button();
            dataGridViewBooks_ARI = new DataGridView();
            panelBooksTop_ARI.SuspendLayout();
            panelBooksButtons_ARI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBooks_ARI).BeginInit();
            SuspendLayout();
            // 
            // panelBooksTop_ARI
            // 
            panelBooksTop_ARI.Controls.Add(buttonExportBooks_ARI);
            panelBooksTop_ARI.Controls.Add(buttonRefreshBooks_ARI);
            panelBooksTop_ARI.Controls.Add(comboBoxSortBook_ARI);
            panelBooksTop_ARI.Controls.Add(labelSortBy_ARI);
            panelBooksTop_ARI.Controls.Add(buttonSearchBook_ARI);
            panelBooksTop_ARI.Controls.Add(textBoxSearchBook_ARI);
            panelBooksTop_ARI.Controls.Add(labelSearchBook_ARI);
            panelBooksTop_ARI.Controls.Add(labelBooksCount_ARI);
            panelBooksTop_ARI.Dock = DockStyle.Top;
            panelBooksTop_ARI.Location = new Point(0, 0);
            panelBooksTop_ARI.Name = "panelBooksTop_ARI";
            panelBooksTop_ARI.Size = new Size(900, 100);
            panelBooksTop_ARI.TabIndex = 0;
            // 
            // buttonExportBooks_ARI
            // 
            buttonExportBooks_ARI.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonExportBooks_ARI.Image = (Image)resources.GetObject("buttonExportBooks_ARI.Image");
            buttonExportBooks_ARI.Location = new Point(755, 55);
            buttonExportBooks_ARI.Name = "buttonExportBooks_ARI";
            buttonExportBooks_ARI.Size = new Size(130, 35);
            buttonExportBooks_ARI.TabIndex = 7;
            buttonExportBooks_ARI.Text = "Экспорт";
            buttonExportBooks_ARI.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonExportBooks_ARI.UseVisualStyleBackColor = true;
            buttonExportBooks_ARI.Click += ButtonExportBooks_ARI_Click;
            // 
            // buttonRefreshBooks_ARI
            // 
            buttonRefreshBooks_ARI.Image = (Image)resources.GetObject("buttonRefreshBooks_ARI.Image");
            buttonRefreshBooks_ARI.Location = new Point(12, 55);
            buttonRefreshBooks_ARI.Name = "buttonRefreshBooks_ARI";
            buttonRefreshBooks_ARI.Size = new Size(130, 35);
            buttonRefreshBooks_ARI.TabIndex = 6;
            buttonRefreshBooks_ARI.Text = "Обновить";
            buttonRefreshBooks_ARI.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonRefreshBooks_ARI.UseVisualStyleBackColor = true;
            buttonRefreshBooks_ARI.Click += ButtonRefreshBooks_ARI_Click;
            // 
            // comboBoxSortBook_ARI
            // 
            comboBoxSortBook_ARI.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboBoxSortBook_ARI.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSortBook_ARI.FormattingEnabled = true;
            comboBoxSortBook_ARI.Items.AddRange(new object[] { "По названию (А-Я)", "По названию (Я-А)", "По году (возрастание)", "По году (убывание)", "По цене (возрастание)", "По цене (убывание)" });
            comboBoxSortBook_ARI.Location = new Point(755, 25);
            comboBoxSortBook_ARI.Name = "comboBoxSortBook_ARI";
            comboBoxSortBook_ARI.Size = new Size(130, 23);
            comboBoxSortBook_ARI.TabIndex = 5;
            comboBoxSortBook_ARI.SelectedIndexChanged += ComboBoxSortBook_ARI_SelectedIndexChanged;
            // 
            // labelSortBy_ARI
            // 
            labelSortBy_ARI.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelSortBy_ARI.AutoSize = true;
            labelSortBy_ARI.Location = new Point(755, 7);
            labelSortBy_ARI.Name = "labelSortBy_ARI";
            labelSortBy_ARI.Size = new Size(88, 15);
            labelSortBy_ARI.TabIndex = 4;
            labelSortBy_ARI.Text = "Сортировка по:";
            // 
            // buttonSearchBook_ARI
            // 
            buttonSearchBook_ARI.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonSearchBook_ARI.Image = (Image)resources.GetObject("buttonSearchBook_ARI.Image");
            buttonSearchBook_ARI.Location = new Point(619, 25);
            buttonSearchBook_ARI.Name = "buttonSearchBook_ARI";
            buttonSearchBook_ARI.Size = new Size(30, 23);
            buttonSearchBook_ARI.TabIndex = 3;
            buttonSearchBook_ARI.UseVisualStyleBackColor = true;
            buttonSearchBook_ARI.Click += ButtonSearchBook_ARI_Click;
            // 
            // textBoxSearchBook_ARI
            // 
            textBoxSearchBook_ARI.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBoxSearchBook_ARI.Location = new Point(445, 25);
            textBoxSearchBook_ARI.Name = "textBoxSearchBook_ARI";
            textBoxSearchBook_ARI.PlaceholderText = "Введите текст для поиска...";
            textBoxSearchBook_ARI.Size = new Size(168, 23);
            textBoxSearchBook_ARI.TabIndex = 2;
            textBoxSearchBook_ARI.TextChanged += TextBoxSearchBook_ARI_TextChanged;
            // 
            // labelSearchBook_ARI
            // 
            labelSearchBook_ARI.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelSearchBook_ARI.AutoSize = true;
            labelSearchBook_ARI.Location = new Point(445, 7);
            labelSearchBook_ARI.Name = "labelSearchBook_ARI";
            labelSearchBook_ARI.Size = new Size(45, 15);
            labelSearchBook_ARI.TabIndex = 1;
            labelSearchBook_ARI.Text = "Поиск:";
            // 
            // labelBooksCount_ARI
            // 
            labelBooksCount_ARI.AutoSize = true;
            labelBooksCount_ARI.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelBooksCount_ARI.Location = new Point(12, 7);
            labelBooksCount_ARI.Name = "labelBooksCount_ARI";
            labelBooksCount_ARI.Size = new Size(111, 17);
            labelBooksCount_ARI.TabIndex = 0;
            labelBooksCount_ARI.Text = "Найдено книг: 0";
            // 
            // panelBooksButtons_ARI
            // 
            panelBooksButtons_ARI.Controls.Add(buttonAddBook_ARI);
            panelBooksButtons_ARI.Controls.Add(buttonEditBook_ARI);
            panelBooksButtons_ARI.Controls.Add(buttonDeleteBook_ARI);
            panelBooksButtons_ARI.Dock = DockStyle.Bottom;
            panelBooksButtons_ARI.Location = new Point(0, 511);
            panelBooksButtons_ARI.Name = "panelBooksButtons_ARI";
            panelBooksButtons_ARI.Size = new Size(900, 50);
            panelBooksButtons_ARI.TabIndex = 1;
            // 
            // buttonAddBook_ARI
            // 
            buttonAddBook_ARI.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonAddBook_ARI.Image = (Image)resources.GetObject("buttonAddBook_ARI.Image");
            buttonAddBook_ARI.Location = new Point(12, 8);
            buttonAddBook_ARI.Name = "buttonAddBook_ARI";
            buttonAddBook_ARI.Size = new Size(150, 35);
            buttonAddBook_ARI.TabIndex = 0;
            buttonAddBook_ARI.Text = "Добавить книгу";
            buttonAddBook_ARI.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonAddBook_ARI.UseVisualStyleBackColor = true;
            buttonAddBook_ARI.Click += ButtonAddBook_ARI_Click;
            // 
            // buttonEditBook_ARI
            // 
            buttonEditBook_ARI.Anchor = AnchorStyles.Bottom;
            buttonEditBook_ARI.Image = (Image)resources.GetObject("buttonEditBook_ARI.Image");
            buttonEditBook_ARI.Location = new Point(375, 8);
            buttonEditBook_ARI.Name = "buttonEditBook_ARI";
            buttonEditBook_ARI.Size = new Size(150, 35);
            buttonEditBook_ARI.TabIndex = 1;
            buttonEditBook_ARI.Text = "Редактировать";
            buttonEditBook_ARI.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonEditBook_ARI.UseVisualStyleBackColor = true;
            buttonEditBook_ARI.Click += ButtonEditBook_ARI_Click;
            // 
            // buttonDeleteBook_ARI
            // 
            buttonDeleteBook_ARI.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonDeleteBook_ARI.Image = (Image)resources.GetObject("buttonDeleteBook_ARI.Image");
            buttonDeleteBook_ARI.Location = new Point(738, 8);
            buttonDeleteBook_ARI.Name = "buttonDeleteBook_ARI";
            buttonDeleteBook_ARI.Size = new Size(150, 35);
            buttonDeleteBook_ARI.TabIndex = 2;
            buttonDeleteBook_ARI.Text = "Удалить";
            buttonDeleteBook_ARI.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonDeleteBook_ARI.UseVisualStyleBackColor = true;
            buttonDeleteBook_ARI.Click += ButtonDeleteBook_ARI_Click;
            // 
            // dataGridViewBooks_ARI
            // 
            dataGridViewBooks_ARI.AllowUserToAddRows = false;
            dataGridViewBooks_ARI.AllowUserToDeleteRows = false;
            dataGridViewBooks_ARI.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewBooks_ARI.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBooks_ARI.Dock = DockStyle.Fill;
            dataGridViewBooks_ARI.Location = new Point(0, 100);
            dataGridViewBooks_ARI.MultiSelect = false;
            dataGridViewBooks_ARI.Name = "dataGridViewBooks_ARI";
            dataGridViewBooks_ARI.ReadOnly = true;
            dataGridViewBooks_ARI.RowHeadersVisible = false;
            dataGridViewBooks_ARI.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewBooks_ARI.Size = new Size(900, 411);
            dataGridViewBooks_ARI.TabIndex = 2;
            dataGridViewBooks_ARI.CellDoubleClick += DataGridViewBooks_ARI_CellDoubleClick;
            // 
            // FormBooks_ARI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 561);
            Controls.Add(dataGridViewBooks_ARI);
            Controls.Add(panelBooksButtons_ARI);
            Controls.Add(panelBooksTop_ARI);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(916, 600);
            Name = "FormBooks_ARI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Управление книгами - ARI";
            Load += FormBooks_ARI_Load;
            panelBooksTop_ARI.ResumeLayout(false);
            panelBooksTop_ARI.PerformLayout();
            panelBooksButtons_ARI.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewBooks_ARI).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelBooksTop_ARI;
        private Label labelBooksCount_ARI;
        private Panel panelBooksButtons_ARI;
        private Button buttonAddBook_ARI;
        private Button buttonEditBook_ARI;
        private Button buttonDeleteBook_ARI;
        private DataGridView dataGridViewBooks_ARI;
        private TextBox textBoxSearchBook_ARI;
        private Label labelSearchBook_ARI;
        private Button buttonSearchBook_ARI;
        private ComboBox comboBoxSortBook_ARI;
        private Label labelSortBy_ARI;
        private Button buttonRefreshBooks_ARI;
        private Button buttonExportBooks_ARI;
    }
}