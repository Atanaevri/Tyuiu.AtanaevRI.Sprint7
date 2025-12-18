
namespace Tyuiu.AtanaevRI.Sprint7.Task0.V4
{
    partial class FormMain_ARI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain_ARI));
            menuStripMain_ARI = new MenuStrip();
            menuItemFile_ARI = new ToolStripMenuItem();
            menuItemSave_ARI = new ToolStripMenuItem();
            toolStripSeparator1_ARI = new ToolStripSeparator();
            menuItemExit_ARI = new ToolStripMenuItem();
            menuItemHelp_ARI = new ToolStripMenuItem();
            menuItemAbout_ARI = new ToolStripMenuItem();
            toolStripMain_ARI = new ToolStrip();
            buttonBooks_ARI = new ToolStripButton();
            buttonReaders_ARI = new ToolStripButton();
            buttonLoans_ARI = new ToolStripButton();
            buttonStatistics_ARI = new ToolStripButton();
            toolStripSeparator2_ARI = new ToolStripSeparator();
            buttonSave_ARI = new ToolStripButton();
            buttonExit_ARI = new ToolStripButton();
            statusStripMain_ARI = new StatusStrip();
            toolStripStatusLabelMessage_ARI = new ToolStripStatusLabel();
            panelMain_ARI = new Panel();
            groupBoxStats_ARI = new GroupBox();
            tableLayoutPanelStats_ARI = new TableLayoutPanel();
            labelBooksCount_ARI = new Label();
            labelBooksTotal_ARI = new Label();
            labelBooksAvg_ARI = new Label();
            labelActiveLoans_ARI = new Label();
            labelReadersCount_ARI = new Label();
            pictureBoxLogo_ARI = new PictureBox();
            labelWelcome_ARI = new Label();
            menuStripMain_ARI.SuspendLayout();
            toolStripMain_ARI.SuspendLayout();
            statusStripMain_ARI.SuspendLayout();
            panelMain_ARI.SuspendLayout();
            groupBoxStats_ARI.SuspendLayout();
            tableLayoutPanelStats_ARI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo_ARI).BeginInit();
            SuspendLayout();
            // 
            // menuStripMain_ARI
            // 
            menuStripMain_ARI.Items.AddRange(new ToolStripItem[] { menuItemFile_ARI, menuItemHelp_ARI });
            menuStripMain_ARI.Location = new Point(0, 0);
            menuStripMain_ARI.Name = "menuStripMain_ARI";
            menuStripMain_ARI.Size = new Size(984, 24);
            menuStripMain_ARI.TabIndex = 0;
            menuStripMain_ARI.Text = "menuStripMain_ARI";
            // 
            // menuItemFile_ARI
            // 
            menuItemFile_ARI.DropDownItems.AddRange(new ToolStripItem[] { menuItemSave_ARI, toolStripSeparator1_ARI, menuItemExit_ARI });
            menuItemFile_ARI.Name = "menuItemFile_ARI";
            menuItemFile_ARI.Size = new Size(48, 20);
            menuItemFile_ARI.Text = "Файл";
            // 
            // menuItemSave_ARI
            // 
            menuItemSave_ARI.Image = null;
            menuItemSave_ARI.Name = "menuItemSave_ARI";
            menuItemSave_ARI.ShortcutKeys = Keys.Control | Keys.S;
            menuItemSave_ARI.Size = new Size(162, 22);
            menuItemSave_ARI.Text = "Сохранить";
            menuItemSave_ARI.Click += ButtonSave_ARI_Click;
            // 
            // toolStripSeparator1_ARI
            // 
            toolStripSeparator1_ARI.Name = "toolStripSeparator1_ARI";
            toolStripSeparator1_ARI.Size = new Size(159, 6);
            // 
            // menuItemExit_ARI
            // 
            menuItemExit_ARI.Image = null;
            menuItemExit_ARI.Name = "menuItemExit_ARI";
            menuItemExit_ARI.ShortcutKeys = Keys.Alt | Keys.F4;
            menuItemExit_ARI.Size = new Size(162, 22);
            menuItemExit_ARI.Text = "Выход";
            menuItemExit_ARI.Click += MenuItemExit_ARI_Click;
            // 
            // menuItemHelp_ARI
            // 
            menuItemHelp_ARI.DropDownItems.AddRange(new ToolStripItem[] { menuItemAbout_ARI });
            menuItemHelp_ARI.Name = "menuItemHelp_ARI";
            menuItemHelp_ARI.Size = new Size(65, 20);
            menuItemHelp_ARI.Text = "Справка";
            // 
            // menuItemAbout_ARI
            // 
            menuItemAbout_ARI.Image = null;
            menuItemAbout_ARI.Name = "menuItemAbout_ARI";
            menuItemAbout_ARI.Size = new Size(149, 22);
            menuItemAbout_ARI.Text = "О программе";
            menuItemAbout_ARI.Click += MenuItemAbout_ARI_Click;
            // 
            // toolStripMain_ARI
            // 
            toolStripMain_ARI.Items.AddRange(new ToolStripItem[] { buttonBooks_ARI, buttonReaders_ARI, buttonLoans_ARI, buttonStatistics_ARI, toolStripSeparator2_ARI, buttonSave_ARI, buttonExit_ARI });
            toolStripMain_ARI.Location = new Point(0, 24);
            toolStripMain_ARI.Name = "toolStripMain_ARI";
            toolStripMain_ARI.Size = new Size(984, 25);
            toolStripMain_ARI.TabIndex = 1;
            toolStripMain_ARI.Text = "toolStripMain_ARI";
            // 
            // buttonBooks_ARI
            // 
            buttonBooks_ARI.Image = null;
            buttonBooks_ARI.ImageTransparentColor = Color.Magenta;
            buttonBooks_ARI.Name = "buttonBooks_ARI";
            buttonBooks_ARI.Size = new Size(66, 22);
            buttonBooks_ARI.Text = "Книги";
            buttonBooks_ARI.Click += ButtonBooks_ARI_Click;
            // 
            // buttonReaders_ARI
            // 
            buttonReaders_ARI.Image = null;
            buttonReaders_ARI.ImageTransparentColor = Color.Magenta;
            buttonReaders_ARI.Name = "buttonReaders_ARI";
            buttonReaders_ARI.Size = new Size(84, 22);
            buttonReaders_ARI.Text = "Читатели";
            buttonReaders_ARI.Click += ButtonReaders_ARI_Click;
            // 
            // buttonLoans_ARI
            // 
            buttonLoans_ARI.Image = null;
            buttonLoans_ARI.ImageTransparentColor = Color.Magenta;
            buttonLoans_ARI.Name = "buttonLoans_ARI";
            buttonLoans_ARI.Size = new Size(64, 22);
            buttonLoans_ARI.Text = "Выдача";
            buttonLoans_ARI.Click += ButtonLoans_ARI_Click;
            // 
            // buttonStatistics_ARI
            // 
            buttonStatistics_ARI.Image = null;
            buttonStatistics_ARI.ImageTransparentColor = Color.Magenta;
            buttonStatistics_ARI.Name = "buttonStatistics_ARI";
            buttonStatistics_ARI.Size = new Size(90, 22);
            buttonStatistics_ARI.Text = "Статистика";
            buttonStatistics_ARI.Click += ButtonStatistics_ARI_Click;
            // 
            // toolStripSeparator2_ARI
            // 
            toolStripSeparator2_ARI.Name = "toolStripSeparator2_ARI";
            toolStripSeparator2_ARI.Size = new Size(6, 25);
            // 
            // buttonSave_ARI
            // 
            buttonSave_ARI.Image = null;
            buttonSave_ARI.ImageTransparentColor = Color.Magenta;
            buttonSave_ARI.Name = "buttonSave_ARI";
            buttonSave_ARI.Size = new Size(77, 22);
            buttonSave_ARI.Text = "Сохранить";
            buttonSave_ARI.Click += ButtonSave_ARI_Click;
            // 
            // buttonExit_ARI
            // 
            buttonExit_ARI.Image = null;
            buttonExit_ARI.ImageTransparentColor = Color.Magenta;
            buttonExit_ARI.Name = "buttonExit_ARI";
            buttonExit_ARI.Size = new Size(53, 22);
            buttonExit_ARI.Text = "Выход";
            buttonExit_ARI.Click += ButtonExit_ARI_Click;
            // 
            // statusStripMain_ARI
            // 
            statusStripMain_ARI.Items.AddRange(new ToolStripItem[] { toolStripStatusLabelMessage_ARI });
            statusStripMain_ARI.Location = new Point(0, 639);
            statusStripMain_ARI.Name = "statusStripMain_ARI";
            statusStripMain_ARI.Size = new Size(984, 22);
            statusStripMain_ARI.TabIndex = 2;
            statusStripMain_ARI.Text = "statusStripMain_ARI";
            // 
            // toolStripStatusLabelMessage_ARI
            // 
            toolStripStatusLabelMessage_ARI.Name = "toolStripStatusLabelMessage_ARI";
            toolStripStatusLabelMessage_ARI.Size = new Size(147, 17);
            toolStripStatusLabelMessage_ARI.Text = "Добро пожаловать в систему";
            // 
            // panelMain_ARI
            // 
            panelMain_ARI.Controls.Add(groupBoxStats_ARI);
            panelMain_ARI.Controls.Add(pictureBoxLogo_ARI);
            panelMain_ARI.Controls.Add(labelWelcome_ARI);
            panelMain_ARI.Dock = DockStyle.Fill;
            panelMain_ARI.Location = new Point(0, 49);
            panelMain_ARI.Name = "panelMain_ARI";
            panelMain_ARI.Size = new Size(984, 590);
            panelMain_ARI.TabIndex = 3;
            // 
            // groupBoxStats_ARI
            // 
            groupBoxStats_ARI.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxStats_ARI.Controls.Add(tableLayoutPanelStats_ARI);
            groupBoxStats_ARI.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            groupBoxStats_ARI.Location = new Point(12, 100);
            groupBoxStats_ARI.Name = "groupBoxStats_ARI";
            groupBoxStats_ARI.Size = new Size(960, 150);
            groupBoxStats_ARI.TabIndex = 2;
            groupBoxStats_ARI.TabStop = false;
            groupBoxStats_ARI.Text = "Статистика системы";
            // 
            // tableLayoutPanelStats_ARI
            // 
            tableLayoutPanelStats_ARI.ColumnCount = 2;
            tableLayoutPanelStats_ARI.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelStats_ARI.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelStats_ARI.Controls.Add(labelBooksCount_ARI, 0, 0);
            tableLayoutPanelStats_ARI.Controls.Add(labelBooksTotal_ARI, 1, 0);
            tableLayoutPanelStats_ARI.Controls.Add(labelBooksAvg_ARI, 0, 1);
            tableLayoutPanelStats_ARI.Controls.Add(labelActiveLoans_ARI, 1, 1);
            tableLayoutPanelStats_ARI.Controls.Add(labelReadersCount_ARI, 0, 2);
            tableLayoutPanelStats_ARI.Dock = DockStyle.Fill;
            tableLayoutPanelStats_ARI.Location = new Point(3, 19);
            tableLayoutPanelStats_ARI.Name = "tableLayoutPanelStats_ARI";
            tableLayoutPanelStats_ARI.RowCount = 3;
            tableLayoutPanelStats_ARI.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanelStats_ARI.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanelStats_ARI.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanelStats_ARI.Size = new Size(954, 128);
            tableLayoutPanelStats_ARI.TabIndex = 0;
            // 
            // labelBooksCount_ARI
            // 
            labelBooksCount_ARI.AutoSize = true;
            labelBooksCount_ARI.Dock = DockStyle.Fill;
            labelBooksCount_ARI.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelBooksCount_ARI.Location = new Point(3, 0);
            labelBooksCount_ARI.Name = "labelBooksCount_ARI";
            labelBooksCount_ARI.Padding = new Padding(10);
            labelBooksCount_ARI.Size = new Size(471, 42);
            labelBooksCount_ARI.TabIndex = 0;
            labelBooksCount_ARI.Text = "Книг: 0";
            labelBooksCount_ARI.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelBooksTotal_ARI
            // 
            labelBooksTotal_ARI.AutoSize = true;
            labelBooksTotal_ARI.Dock = DockStyle.Fill;
            labelBooksTotal_ARI.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelBooksTotal_ARI.Location = new Point(480, 0);
            labelBooksTotal_ARI.Name = "labelBooksTotal_ARI";
            labelBooksTotal_ARI.Padding = new Padding(10);
            labelBooksTotal_ARI.Size = new Size(471, 42);
            labelBooksTotal_ARI.TabIndex = 1;
            labelBooksTotal_ARI.Text = "Общая стоимость: 0 ₽";
            labelBooksTotal_ARI.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelBooksAvg_ARI
            // 
            labelBooksAvg_ARI.AutoSize = true;
            labelBooksAvg_ARI.Dock = DockStyle.Fill;
            labelBooksAvg_ARI.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelBooksAvg_ARI.Location = new Point(3, 42);
            labelBooksAvg_ARI.Name = "labelBooksAvg_ARI";
            labelBooksAvg_ARI.Padding = new Padding(10);
            labelBooksAvg_ARI.Size = new Size(471, 42);
            labelBooksAvg_ARI.TabIndex = 2;
            labelBooksAvg_ARI.Text = "Средняя цена: 0 ₽";
            labelBooksAvg_ARI.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelActiveLoans_ARI
            // 
            labelActiveLoans_ARI.AutoSize = true;
            labelActiveLoans_ARI.Dock = DockStyle.Fill;
            labelActiveLoans_ARI.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelActiveLoans_ARI.Location = new Point(480, 42);
            labelActiveLoans_ARI.Name = "labelActiveLoans_ARI";
            labelActiveLoans_ARI.Padding = new Padding(10);
            labelActiveLoans_ARI.Size = new Size(471, 42);
            labelActiveLoans_ARI.TabIndex = 3;
            labelActiveLoans_ARI.Text = "Активных выдач: 0";
            labelActiveLoans_ARI.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelReadersCount_ARI
            // 
            labelReadersCount_ARI.AutoSize = true;
            labelReadersCount_ARI.Dock = DockStyle.Fill;
            labelReadersCount_ARI.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelReadersCount_ARI.Location = new Point(3, 84);
            labelReadersCount_ARI.Name = "labelReadersCount_ARI";
            labelReadersCount_ARI.Padding = new Padding(10);
            labelReadersCount_ARI.Size = new Size(471, 44);
            labelReadersCount_ARI.TabIndex = 4;
            labelReadersCount_ARI.Text = "Читателей: 0";
            labelReadersCount_ARI.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBoxLogo_ARI
            // 
            pictureBoxLogo_ARI.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBoxLogo_ARI.Image = null;
            pictureBoxLogo_ARI.Location = new Point(804, 12);
            pictureBoxLogo_ARI.Name = "pictureBoxLogo_ARI";
            pictureBoxLogo_ARI.Size = new Size(168, 82);
            pictureBoxLogo_ARI.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLogo_ARI.TabIndex = 1;
            pictureBoxLogo_ARI.TabStop = false;
            // 
            // labelWelcome_ARI
            // 
            labelWelcome_ARI.AutoSize = true;
            labelWelcome_ARI.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelWelcome_ARI.Location = new Point(12, 30);
            labelWelcome_ARI.Name = "labelWelcome_ARI";
            labelWelcome_ARI.Size = new Size(400, 37);
            labelWelcome_ARI.TabIndex = 0;
            labelWelcome_ARI.Text = "Библиотечная система v4.0";
            // 
            // FormMain_ARI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(984, 661);
            Controls.Add(panelMain_ARI);
            Controls.Add(statusStripMain_ARI);
            Controls.Add(toolStripMain_ARI);
            Controls.Add(menuStripMain_ARI);
            Icon = null;
            MainMenuStrip = menuStripMain_ARI;
            MinimumSize = new Size(1000, 700);
            Name = "FormMain_ARI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Библиотечная система - ARI";
            FormClosing += FormMain_ARI_FormClosing;
            menuStripMain_ARI.ResumeLayout(false);
            menuStripMain_ARI.PerformLayout();
            toolStripMain_ARI.ResumeLayout(false);
            toolStripMain_ARI.PerformLayout();
            statusStripMain_ARI.ResumeLayout(false);
            statusStripMain_ARI.PerformLayout();
            panelMain_ARI.ResumeLayout(false);
            panelMain_ARI.PerformLayout();
            groupBoxStats_ARI.ResumeLayout(false);
            tableLayoutPanelStats_ARI.ResumeLayout(false);
            tableLayoutPanelStats_ARI.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo_ARI).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStripMain_ARI;
        private ToolStripMenuItem menuItemFile_ARI;
        private ToolStripMenuItem menuItemSave_ARI;
        private ToolStripSeparator toolStripSeparator1_ARI;
        private ToolStripMenuItem menuItemExit_ARI;
        private ToolStripMenuItem menuItemHelp_ARI;
        private ToolStripMenuItem menuItemAbout_ARI;
        private ToolStrip toolStripMain_ARI;
        private ToolStripButton buttonBooks_ARI;
        private ToolStripButton buttonReaders_ARI;
        private ToolStripButton buttonLoans_ARI;
        private ToolStripButton buttonStatistics_ARI;
        private ToolStripSeparator toolStripSeparator2_ARI;
        private ToolStripButton buttonSave_ARI;
        private ToolStripButton buttonExit_ARI;
        private StatusStrip statusStripMain_ARI;
        private ToolStripStatusLabel toolStripStatusLabelMessage_ARI;
        private Panel panelMain_ARI;
        private GroupBox groupBoxStats_ARI;
        private TableLayoutPanel tableLayoutPanelStats_ARI;
        private Label labelBooksCount_ARI;
        private Label labelBooksTotal_ARI;
        private Label labelBooksAvg_ARI;
        private Label labelActiveLoans_ARI;
        private Label labelReadersCount_ARI;
        private PictureBox pictureBoxLogo_ARI;
        private Label labelWelcome_ARI;
    }
}