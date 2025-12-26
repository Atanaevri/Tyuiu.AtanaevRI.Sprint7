namespace Tyuiu.AtanaevRI.Sprint7.Task0.V4
{
    partial class FormReaders_ARI
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            panelReadersTop_ARI = new Panel();
            buttonExportReaders_ARI = new Button();
            buttonRefreshReaders_ARI = new Button();
            comboBoxSortReader_ARI = new ComboBox();
            labelSortBy_ARI = new Label();
            buttonSearchReader_ARI = new Button();
            textBoxSearchReader_ARI = new TextBox();
            labelSearchReader_ARI = new Label();
            labelReadersCount_ARI = new Label();
            panelReadersButtons_ARI = new Panel();
            buttonAddReader_ARI = new Button();
            buttonEditReader_ARI = new Button();
            buttonDeleteReader_ARI = new Button();
            dataGridViewReaders_ARI = new DataGridView();
            panelReadersTop_ARI.SuspendLayout();
            panelReadersButtons_ARI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewReaders_ARI).BeginInit();
            SuspendLayout();
            // 
            // panelReadersTop_ARI
            // 
            panelReadersTop_ARI.Controls.Add(buttonExportReaders_ARI);
            panelReadersTop_ARI.Controls.Add(buttonRefreshReaders_ARI);
            panelReadersTop_ARI.Controls.Add(comboBoxSortReader_ARI);
            panelReadersTop_ARI.Controls.Add(labelSortBy_ARI);
            panelReadersTop_ARI.Controls.Add(buttonSearchReader_ARI);
            panelReadersTop_ARI.Controls.Add(textBoxSearchReader_ARI);
            panelReadersTop_ARI.Controls.Add(labelSearchReader_ARI);
            panelReadersTop_ARI.Controls.Add(labelReadersCount_ARI);
            panelReadersTop_ARI.Dock = DockStyle.Top;
            panelReadersTop_ARI.Location = new Point(0, 0);
            panelReadersTop_ARI.Margin = new Padding(3, 4, 3, 4);
            panelReadersTop_ARI.Name = "panelReadersTop_ARI";
            panelReadersTop_ARI.Size = new Size(1029, 133);
            panelReadersTop_ARI.TabIndex = 0;
            // 
            // buttonExportReaders_ARI
            // 
            buttonExportReaders_ARI.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonExportReaders_ARI.Location = new Point(863, 73);
            buttonExportReaders_ARI.Margin = new Padding(3, 4, 3, 4);
            buttonExportReaders_ARI.Name = "buttonExportReaders_ARI";
            buttonExportReaders_ARI.Size = new Size(149, 47);
            buttonExportReaders_ARI.TabIndex = 7;
            buttonExportReaders_ARI.Text = "Экспорт";
            buttonExportReaders_ARI.UseVisualStyleBackColor = true;
            buttonExportReaders_ARI.Click += ButtonExportReaders_ARI_Click;
            // 
            // buttonRefreshReaders_ARI
            // 
            buttonRefreshReaders_ARI.Location = new Point(14, 73);
            buttonRefreshReaders_ARI.Margin = new Padding(3, 4, 3, 4);
            buttonRefreshReaders_ARI.Name = "buttonRefreshReaders_ARI";
            buttonRefreshReaders_ARI.Size = new Size(149, 47);
            buttonRefreshReaders_ARI.TabIndex = 6;
            buttonRefreshReaders_ARI.Text = "Обновить";
            buttonRefreshReaders_ARI.UseVisualStyleBackColor = true;
            buttonRefreshReaders_ARI.Click += ButtonRefreshReaders_ARI_Click;
            // 
            // comboBoxSortReader_ARI
            // 
            comboBoxSortReader_ARI.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboBoxSortReader_ARI.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSortReader_ARI.FormattingEnabled = true;
            comboBoxSortReader_ARI.Items.AddRange(new object[] { "По ФИО (А-Я)", "По ФИО (Я-А)", "По номеру билета (возрастание)", "По номеру билета (убывание)" });
            comboBoxSortReader_ARI.Location = new Point(863, 33);
            comboBoxSortReader_ARI.Margin = new Padding(3, 4, 3, 4);
            comboBoxSortReader_ARI.Name = "comboBoxSortReader_ARI";
            comboBoxSortReader_ARI.Size = new Size(148, 28);
            comboBoxSortReader_ARI.TabIndex = 5;
            comboBoxSortReader_ARI.SelectedIndexChanged += ComboBoxSortReader_ARI_SelectedIndexChanged;
            // 
            // labelSortBy_ARI
            // 
            labelSortBy_ARI.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelSortBy_ARI.AutoSize = true;
            labelSortBy_ARI.Location = new Point(863, 9);
            labelSortBy_ARI.Name = "labelSortBy_ARI";
            labelSortBy_ARI.Size = new Size(117, 20);
            labelSortBy_ARI.TabIndex = 4;
            labelSortBy_ARI.Text = "Сортировка по:";
            // 
            // buttonSearchReader_ARI
            // 
            buttonSearchReader_ARI.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonSearchReader_ARI.Location = new Point(707, 33);
            buttonSearchReader_ARI.Margin = new Padding(3, 4, 3, 4);
            buttonSearchReader_ARI.Name = "buttonSearchReader_ARI";
            buttonSearchReader_ARI.Size = new Size(34, 31);
            buttonSearchReader_ARI.TabIndex = 3;
            buttonSearchReader_ARI.Text = "🔍";
            buttonSearchReader_ARI.UseVisualStyleBackColor = true;
            buttonSearchReader_ARI.Click += ButtonSearchReader_ARI_Click;
            // 
            // textBoxSearchReader_ARI
            // 
            textBoxSearchReader_ARI.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBoxSearchReader_ARI.Location = new Point(509, 33);
            textBoxSearchReader_ARI.Margin = new Padding(3, 4, 3, 4);
            textBoxSearchReader_ARI.Name = "textBoxSearchReader_ARI";
            textBoxSearchReader_ARI.PlaceholderText = "Введите текст для поиска...";
            textBoxSearchReader_ARI.Size = new Size(191, 27);
            textBoxSearchReader_ARI.TabIndex = 2;
            textBoxSearchReader_ARI.TextChanged += TextBoxSearchReader_ARI_TextChanged;
            // 
            // labelSearchReader_ARI
            // 
            labelSearchReader_ARI.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelSearchReader_ARI.AutoSize = true;
            labelSearchReader_ARI.Location = new Point(509, 9);
            labelSearchReader_ARI.Name = "labelSearchReader_ARI";
            labelSearchReader_ARI.Size = new Size(55, 20);
            labelSearchReader_ARI.TabIndex = 1;
            labelSearchReader_ARI.Text = "Поиск:";
            // 
            // labelReadersCount_ARI
            // 
            labelReadersCount_ARI.AutoSize = true;
            labelReadersCount_ARI.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            labelReadersCount_ARI.Location = new Point(14, 9);
            labelReadersCount_ARI.Name = "labelReadersCount_ARI";
            labelReadersCount_ARI.Size = new Size(193, 23);
            labelReadersCount_ARI.TabIndex = 0;
            labelReadersCount_ARI.Text = "Найдено читателей: 0";
            // 
            // panelReadersButtons_ARI
            // 
            panelReadersButtons_ARI.Controls.Add(buttonAddReader_ARI);
            panelReadersButtons_ARI.Controls.Add(buttonEditReader_ARI);
            panelReadersButtons_ARI.Controls.Add(buttonDeleteReader_ARI);
            panelReadersButtons_ARI.Dock = DockStyle.Bottom;
            panelReadersButtons_ARI.Location = new Point(0, 681);
            panelReadersButtons_ARI.Margin = new Padding(3, 4, 3, 4);
            panelReadersButtons_ARI.Name = "panelReadersButtons_ARI";
            panelReadersButtons_ARI.Size = new Size(1029, 67);
            panelReadersButtons_ARI.TabIndex = 1;
            // 
            // buttonAddReader_ARI
            // 
            buttonAddReader_ARI.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonAddReader_ARI.Location = new Point(14, 11);
            buttonAddReader_ARI.Margin = new Padding(3, 4, 3, 4);
            buttonAddReader_ARI.Name = "buttonAddReader_ARI";
            buttonAddReader_ARI.Size = new Size(171, 47);
            buttonAddReader_ARI.TabIndex = 0;
            buttonAddReader_ARI.Text = "Добавить читателя";
            buttonAddReader_ARI.UseVisualStyleBackColor = true;
            buttonAddReader_ARI.Click += ButtonAddReader_ARI_Click;
            // 
            // buttonEditReader_ARI
            // 
            buttonEditReader_ARI.Anchor = AnchorStyles.Bottom;
            buttonEditReader_ARI.Location = new Point(429, 11);
            buttonEditReader_ARI.Margin = new Padding(3, 4, 3, 4);
            buttonEditReader_ARI.Name = "buttonEditReader_ARI";
            buttonEditReader_ARI.Size = new Size(171, 47);
            buttonEditReader_ARI.TabIndex = 1;
            buttonEditReader_ARI.Text = "Редактировать";
            buttonEditReader_ARI.UseVisualStyleBackColor = true;
            buttonEditReader_ARI.Click += ButtonEditReader_ARI_Click;
            // 
            // buttonDeleteReader_ARI
            // 
            buttonDeleteReader_ARI.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonDeleteReader_ARI.Location = new Point(843, 11);
            buttonDeleteReader_ARI.Margin = new Padding(3, 4, 3, 4);
            buttonDeleteReader_ARI.Name = "buttonDeleteReader_ARI";
            buttonDeleteReader_ARI.Size = new Size(171, 47);
            buttonDeleteReader_ARI.TabIndex = 2;
            buttonDeleteReader_ARI.Text = "Удалить";
            buttonDeleteReader_ARI.UseVisualStyleBackColor = true;
            buttonDeleteReader_ARI.Click += ButtonDeleteReader_ARI_Click;
            // 
            // dataGridViewReaders_ARI
            // 
            dataGridViewReaders_ARI.AllowUserToAddRows = false;
            dataGridViewReaders_ARI.AllowUserToDeleteRows = false;
            dataGridViewReaders_ARI.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewReaders_ARI.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewReaders_ARI.Dock = DockStyle.Fill;
            dataGridViewReaders_ARI.Location = new Point(0, 133);
            dataGridViewReaders_ARI.Margin = new Padding(3, 4, 3, 4);
            dataGridViewReaders_ARI.MultiSelect = false;
            dataGridViewReaders_ARI.Name = "dataGridViewReaders_ARI";
            dataGridViewReaders_ARI.ReadOnly = true;
            dataGridViewReaders_ARI.RowHeadersVisible = false;
            dataGridViewReaders_ARI.RowHeadersWidth = 51;
            dataGridViewReaders_ARI.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewReaders_ARI.Size = new Size(1029, 548);
            dataGridViewReaders_ARI.TabIndex = 2;
            dataGridViewReaders_ARI.CellDoubleClick += DataGridViewReaders_ARI_CellDoubleClick;
            // 
            // FormReaders_ARI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 748);
            Controls.Add(dataGridViewReaders_ARI);
            Controls.Add(panelReadersButtons_ARI);
            Controls.Add(panelReadersTop_ARI);
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(1044, 784);
            Name = "FormReaders_ARI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Управление читателями - ARI";
            Load += FormReaders_ARI_Load;
            panelReadersTop_ARI.ResumeLayout(false);
            panelReadersTop_ARI.PerformLayout();
            panelReadersButtons_ARI.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewReaders_ARI).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelReadersTop_ARI;
        private Label labelReadersCount_ARI;
        private Panel panelReadersButtons_ARI;
        private Button buttonAddReader_ARI;
        private Button buttonEditReader_ARI;
        private Button buttonDeleteReader_ARI;
        private DataGridView dataGridViewReaders_ARI;
        private TextBox textBoxSearchReader_ARI;
        private Label labelSearchReader_ARI;
        private Button buttonSearchReader_ARI;
        private ComboBox comboBoxSortReader_ARI;
        private Label labelSortBy_ARI;
        private Button buttonRefreshReaders_ARI;
        private Button buttonExportReaders_ARI;
    }
}