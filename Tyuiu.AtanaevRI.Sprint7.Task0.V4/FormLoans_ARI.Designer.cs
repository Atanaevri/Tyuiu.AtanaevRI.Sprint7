using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
namespace Tyuiu.AtanaevRI.Sprint7.Task0.V4
{
    partial class FormLoans_ARI
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
            panelLoansTop_ARI = new Panel();
            panelIssueBook_ARI = new Panel();
            dateTimePickerIssueDate_ARI = new DateTimePicker();
            labelIssueDate_ARI = new Label();
            buttonIssueBook_ARI = new Button();
            comboBoxReader_ARI = new ComboBox();
            labelReader_ARI = new Label();
            comboBoxBook_ARI = new ComboBox();
            labelBook_ARI = new Label();
            buttonRefreshLoans_ARI = new Button();
            comboBoxFilterStatus_ARI = new ComboBox();
            labelFilterStatus_ARI = new Label();
            buttonSearchLoan_ARI = new Button();
            textBoxSearchLoan_ARI = new TextBox();
            labelSearchLoan_ARI = new Label();
            labelActiveLoansCount_ARI = new Label();
            labelLoansCount_ARI = new Label();
            panelLoansButtons_ARI = new Panel();
            buttonReturnBook_ARI = new Button();
            buttonDeleteLoan_ARI = new Button();
            dataGridViewLoans_ARI = new DataGridView();
            panelLoansTop_ARI.SuspendLayout();
            panelIssueBook_ARI.SuspendLayout();
            panelLoansButtons_ARI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLoans_ARI).BeginInit();
            SuspendLayout();
            // 
            // panelLoansTop_ARI
            // 
            panelLoansTop_ARI.Controls.Add(panelIssueBook_ARI);
            panelLoansTop_ARI.Controls.Add(buttonRefreshLoans_ARI);
            panelLoansTop_ARI.Controls.Add(comboBoxFilterStatus_ARI);
            panelLoansTop_ARI.Controls.Add(labelFilterStatus_ARI);
            panelLoansTop_ARI.Controls.Add(buttonSearchLoan_ARI);
            panelLoansTop_ARI.Controls.Add(textBoxSearchLoan_ARI);
            panelLoansTop_ARI.Controls.Add(labelSearchLoan_ARI);
            panelLoansTop_ARI.Controls.Add(labelActiveLoansCount_ARI);
            panelLoansTop_ARI.Controls.Add(labelLoansCount_ARI);
            panelLoansTop_ARI.Dock = DockStyle.Top;
            panelLoansTop_ARI.Location = new Point(0, 0);
            panelLoansTop_ARI.Name = "panelLoansTop_ARI";
            panelLoansTop_ARI.Size = new Size(1000, 150);
            panelLoansTop_ARI.TabIndex = 0;
            // 
            // panelIssueBook_ARI
            // 
            panelIssueBook_ARI.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panelIssueBook_ARI.Controls.Add(dateTimePickerIssueDate_ARI);
            panelIssueBook_ARI.Controls.Add(labelIssueDate_ARI);
            panelIssueBook_ARI.Controls.Add(buttonIssueBook_ARI);
            panelIssueBook_ARI.Controls.Add(comboBoxReader_ARI);
            panelIssueBook_ARI.Controls.Add(labelReader_ARI);
            panelIssueBook_ARI.Controls.Add(comboBoxBook_ARI);
            panelIssueBook_ARI.Controls.Add(labelBook_ARI);
            panelIssueBook_ARI.Location = new Point(500, 10);
            panelIssueBook_ARI.Name = "panelIssueBook_ARI";
            panelIssueBook_ARI.Size = new Size(480, 130);
            panelIssueBook_ARI.TabIndex = 8;
            // 
            // dateTimePickerIssueDate_ARI
            // 
            dateTimePickerIssueDate_ARI.Location = new Point(330, 70);
            dateTimePickerIssueDate_ARI.Name = "dateTimePickerIssueDate_ARI";
            dateTimePickerIssueDate_ARI.Size = new Size(140, 23);
            dateTimePickerIssueDate_ARI.TabIndex = 6;
            // 
            // labelIssueDate_ARI
            // 
            labelIssueDate_ARI.AutoSize = true;
            labelIssueDate_ARI.Location = new Point(330, 50);
            labelIssueDate_ARI.Name = "labelIssueDate_ARI";
            labelIssueDate_ARI.Size = new Size(74, 15);
            labelIssueDate_ARI.TabIndex = 5;
            labelIssueDate_ARI.Text = "Дата выдачи:";
            // 
            // buttonIssueBook_ARI
            // 
            buttonIssueBook_ARI.Location = new Point(330, 100);
            buttonIssueBook_ARI.Name = "buttonIssueBook_ARI";
            buttonIssueBook_ARI.Size = new Size(140, 25);
            buttonIssueBook_ARI.TabIndex = 4;
            buttonIssueBook_ARI.Text = "Выдать книгу";
            buttonIssueBook_ARI.UseVisualStyleBackColor = true;
            buttonIssueBook_ARI.Click += ButtonIssueBook_ARI_Click;
            // 
            // comboBoxReader_ARI
            // 
            comboBoxReader_ARI.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxReader_ARI.FormattingEnabled = true;
            comboBoxReader_ARI.Location = new Point(10, 70);
            comboBoxReader_ARI.Name = "comboBoxReader_ARI";
            comboBoxReader_ARI.Size = new Size(310, 23);
            comboBoxReader_ARI.TabIndex = 3;
            // 
            // labelReader_ARI
            // 
            labelReader_ARI.AutoSize = true;
            labelReader_ARI.Location = new Point(10, 50);
            labelReader_ARI.Name = "labelReader_ARI";
            labelReader_ARI.Size = new Size(58, 15);
            labelReader_ARI.TabIndex = 2;
            labelReader_ARI.Text = "Читатель:";
            // 
            // comboBoxBook_ARI
            // 
            comboBoxBook_ARI.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxBook_ARI.FormattingEnabled = true;
            comboBoxBook_ARI.Location = new Point(10, 20);
            comboBoxBook_ARI.Name = "comboBoxBook_ARI";
            comboBoxBook_ARI.Size = new Size(460, 23);
            comboBoxBook_ARI.TabIndex = 1;
            // 
            // labelBook_ARI
            // 
            labelBook_ARI.AutoSize = true;
            labelBook_ARI.Location = new Point(10, 0);
            labelBook_ARI.Name = "labelBook_ARI";
            labelBook_ARI.Size = new Size(43, 15);
            labelBook_ARI.TabIndex = 0;
            labelBook_ARI.Text = "Книга:";
            // 
            // buttonRefreshLoans_ARI
            // 
            buttonRefreshLoans_ARI.Location = new Point(12, 115);
            buttonRefreshLoans_ARI.Name = "buttonRefreshLoans_ARI";
            buttonRefreshLoans_ARI.Size = new Size(130, 25);
            buttonRefreshLoans_ARI.TabIndex = 7;
            buttonRefreshLoans_ARI.Text = "Обновить";
            buttonRefreshLoans_ARI.UseVisualStyleBackColor = true;
            buttonRefreshLoans_ARI.Click += ButtonRefreshLoans_ARI_Click;
            // 
            // comboBoxFilterStatus_ARI
            // 
            comboBoxFilterStatus_ARI.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxFilterStatus_ARI.FormattingEnabled = true;
            comboBoxFilterStatus_ARI.Items.AddRange(new object[] { "Все", "Активные", "Возвращенные" });
            comboBoxFilterStatus_ARI.Location = new Point(12, 85);
            comboBoxFilterStatus_ARI.Name = "comboBoxFilterStatus_ARI";
            comboBoxFilterStatus_ARI.Size = new Size(130, 23);
            comboBoxFilterStatus_ARI.TabIndex = 6;
            comboBoxFilterStatus_ARI.SelectedIndexChanged += ComboBoxFilterStatus_ARI_SelectedIndexChanged;
            // 
            // labelFilterStatus_ARI
            // 
            labelFilterStatus_ARI.AutoSize = true;
            labelFilterStatus_ARI.Location = new Point(12, 65);
            labelFilterStatus_ARI.Name = "labelFilterStatus_ARI";
            labelFilterStatus_ARI.Size = new Size(54, 15);
            labelFilterStatus_ARI.TabIndex = 5;
            labelFilterStatus_ARI.Text = "Фильтр:";
            // 
            // buttonSearchLoan_ARI
            // 
            buttonSearchLoan_ARI.Location = new Point(300, 85);
            buttonSearchLoan_ARI.Name = "buttonSearchLoan_ARI";
            buttonSearchLoan_ARI.Size = new Size(30, 23);
            buttonSearchLoan_ARI.TabIndex = 4;
            buttonSearchLoan_ARI.Text = "🔍";
            buttonSearchLoan_ARI.UseVisualStyleBackColor = true;
            buttonSearchLoan_ARI.Click += ButtonSearchLoan_ARI_Click;
            // 
            // textBoxSearchLoan_ARI
            // 
            textBoxSearchLoan_ARI.Location = new Point(160, 85);
            textBoxSearchLoan_ARI.Name = "textBoxSearchLoan_ARI";
            textBoxSearchLoan_ARI.PlaceholderText = "Название книги или номер билета...";
            textBoxSearchLoan_ARI.Size = new Size(134, 23);
            textBoxSearchLoan_ARI.TabIndex = 3;
            textBoxSearchLoan_ARI.TextChanged += TextBoxSearchLoan_ARI_TextChanged;
            // 
            // labelSearchLoan_ARI
            // 
            labelSearchLoan_ARI.AutoSize = true;
            labelSearchLoan_ARI.Location = new Point(160, 65);
            labelSearchLoan_ARI.Name = "labelSearchLoan_ARI";
            labelSearchLoan_ARI.Size = new Size(45, 15);
            labelSearchLoan_ARI.TabIndex = 2;
            labelSearchLoan_ARI.Text = "Поиск:";
            // 
            // labelActiveLoansCount_ARI
            // 
            labelActiveLoansCount_ARI.AutoSize = true;
            labelActiveLoansCount_ARI.Font = new System.Drawing.Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelActiveLoansCount_ARI.Location = new Point(12, 35);
            labelActiveLoansCount_ARI.Name = "labelActiveLoansCount_ARI";
            labelActiveLoansCount_ARI.Size = new Size(80, 17);
            labelActiveLoansCount_ARI.TabIndex = 1;
            labelActiveLoansCount_ARI.Text = "Активных: 0";
            // 
            // labelLoansCount_ARI
            // 
            labelLoansCount_ARI.AutoSize = true;
            labelLoansCount_ARI.Font = new System.Drawing.Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelLoansCount_ARI.Location = new Point(12, 10);
            labelLoansCount_ARI.Name = "labelLoansCount_ARI";
            labelLoansCount_ARI.Size = new Size(103, 17);
            labelLoansCount_ARI.TabIndex = 0;
            labelLoansCount_ARI.Text = "Всего выдач: 0";
            // 
            // panelLoansButtons_ARI
            // 
            panelLoansButtons_ARI.Controls.Add(buttonReturnBook_ARI);
            panelLoansButtons_ARI.Controls.Add(buttonDeleteLoan_ARI);
            panelLoansButtons_ARI.Dock = DockStyle.Bottom;
            panelLoansButtons_ARI.Location = new Point(0, 511);
            panelLoansButtons_ARI.Name = "panelLoansButtons_ARI";
            panelLoansButtons_ARI.Size = new Size(1000, 50);
            panelLoansButtons_ARI.TabIndex = 1;
            // 
            // buttonReturnBook_ARI
            // 
            buttonReturnBook_ARI.Anchor = AnchorStyles.Bottom;
            buttonReturnBook_ARI.Location = new Point(300, 8);
            buttonReturnBook_ARI.Name = "buttonReturnBook_ARI";
            buttonReturnBook_ARI.Size = new Size(200, 35);
            buttonReturnBook_ARI.TabIndex = 1;
            buttonReturnBook_ARI.Text = "Отметить возврат";
            buttonReturnBook_ARI.UseVisualStyleBackColor = true;
            buttonReturnBook_ARI.Click += ButtonReturnBook_ARI_Click;
            // 
            // buttonDeleteLoan_ARI
            // 
            buttonDeleteLoan_ARI.Anchor = AnchorStyles.Bottom;
            buttonDeleteLoan_ARI.Location = new Point(550, 8);
            buttonDeleteLoan_ARI.Name = "buttonDeleteLoan_ARI";
            buttonDeleteLoan_ARI.Size = new Size(150, 35);
            buttonDeleteLoan_ARI.TabIndex = 2;
            buttonDeleteLoan_ARI.Text = "Удалить запись";
            buttonDeleteLoan_ARI.UseVisualStyleBackColor = true;
            buttonDeleteLoan_ARI.Click += ButtonDeleteLoan_ARI_Click;
            // 
            // dataGridViewLoans_ARI
            // 
            dataGridViewLoans_ARI.AllowUserToAddRows = false;
            dataGridViewLoans_ARI.AllowUserToDeleteRows = false;
            dataGridViewLoans_ARI.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewLoans_ARI.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewLoans_ARI.Dock = DockStyle.Fill;
            dataGridViewLoans_ARI.Location = new Point(0, 150);
            dataGridViewLoans_ARI.MultiSelect = false;
            dataGridViewLoans_ARI.Name = "dataGridViewLoans_ARI";
            dataGridViewLoans_ARI.ReadOnly = true;
            dataGridViewLoans_ARI.RowHeadersVisible = false;
            dataGridViewLoans_ARI.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewLoans_ARI.Size = new Size(1000, 361);
            dataGridViewLoans_ARI.TabIndex = 2;
            dataGridViewLoans_ARI.CellDoubleClick += DataGridViewLoans_ARI_CellDoubleClick;
            // 
            // FormLoans_ARI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 561);
            Controls.Add(dataGridViewLoans_ARI);
            Controls.Add(panelLoansButtons_ARI);
            Controls.Add(panelLoansTop_ARI);
            MinimumSize = new Size(1016, 600);
            Name = "FormLoans_ARI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Выдача и возврат книг - ARI";
            Load += FormLoans_ARI_Load;
            panelLoansTop_ARI.ResumeLayout(false);
            panelLoansTop_ARI.PerformLayout();
            panelIssueBook_ARI.ResumeLayout(false);
            panelIssueBook_ARI.PerformLayout();
            panelLoansButtons_ARI.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewLoans_ARI).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelLoansTop_ARI;
        private Label labelLoansCount_ARI;
        private Panel panelLoansButtons_ARI;
        private DataGridView dataGridViewLoans_ARI;
        private Label labelActiveLoansCount_ARI;
        private Button buttonSearchLoan_ARI;
        private TextBox textBoxSearchLoan_ARI;
        private Label labelSearchLoan_ARI;
        private ComboBox comboBoxFilterStatus_ARI;
        private Label labelFilterStatus_ARI;
        private Button buttonRefreshLoans_ARI;
        private Panel panelIssueBook_ARI;
        private ComboBox comboBoxBook_ARI;
        private Label labelBook_ARI;
        private Button buttonIssueBook_ARI;
        private ComboBox comboBoxReader_ARI;
        private Label labelReader_ARI;
        private DateTimePicker dateTimePickerIssueDate_ARI;
        private Label labelIssueDate_ARI;
        private Button buttonReturnBook_ARI;
        private Button buttonDeleteLoan_ARI;
    }
}