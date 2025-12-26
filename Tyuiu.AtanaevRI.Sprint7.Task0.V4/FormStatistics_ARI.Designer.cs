using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.Windows.Forms.DataVisualization.Charting;
namespace Tyuiu.AtanaevRI.Sprint7.Task0.V4
{
    partial class FormStatistics_ARI : Form
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
            ChartArea chartArea1 = new ChartArea();
            Legend legend1 = new Legend();
            Series series1 = new Series();
            ChartArea chartArea2 = new ChartArea();
            Legend legend2 = new Legend();
            Series series2 = new Series();
            ChartArea chartArea3 = new ChartArea();
            Legend legend3 = new Legend();
            Series series3 = new Series();
            tabControlStats_ARI = new TabControl();
            tabPageGeneral_ARI = new TabPage();
            tableLayoutPanelGeneral_ARI = new TableLayoutPanel();
            panelGeneralStats_ARI = new Panel();
            groupBoxGeneralStats_ARI = new GroupBox();
            tableLayoutPanelNumbers_ARI = new TableLayoutPanel();
            labelTotalBooks_ARI = new Label();
            labelTotalReaders_ARI = new Label();
            labelActiveLoansStat_ARI = new Label();
            labelTotalLoans_ARI = new Label();
            labelAvgBookPrice_ARI = new Label();
            labelTotalBooksValue_ARI = new Label();
            panelCharts_ARI = new Panel();
            groupBoxCharts_ARI = new GroupBox();
            tableLayoutPanelCharts_ARI = new TableLayoutPanel();
            chartBooksByYear_ARI = new Chart();
            chartBooksByAuthor_ARI = new Chart();
            chartLoansByMonth_ARI = new Chart();
            tabPageBooks_ARI = new TabPage();
            groupBoxTopBooks_ARI = new GroupBox();
            dataGridViewTopBooks_ARI = new DataGridView();
            ColumnBookTitle = new DataGridViewTextBoxColumn();
            ColumnLoanCount = new DataGridViewTextBoxColumn();
            ColumnLastLoan = new DataGridViewTextBoxColumn();
            tabPageReaders_ARI = new TabPage();
            groupBoxActiveReaders_ARI = new GroupBox();
            dataGridViewActiveReaders_ARI = new DataGridView();
            ColumnCardNumber = new DataGridViewTextBoxColumn();
            ColumnBooksCount = new DataGridViewTextBoxColumn();
            ColumnIssueDate = new DataGridViewTextBoxColumn();
            panelStatsTop_ARI = new Panel();
            comboBoxChartType_ARI = new ComboBox();
            labelChartType_ARI = new Label();
            buttonExportStats_ARI = new Button();
            buttonRefreshStats_ARI = new Button();
            tabControlStats_ARI.SuspendLayout();
            tabPageGeneral_ARI.SuspendLayout();
            tableLayoutPanelGeneral_ARI.SuspendLayout();
            panelGeneralStats_ARI.SuspendLayout();
            groupBoxGeneralStats_ARI.SuspendLayout();
            tableLayoutPanelNumbers_ARI.SuspendLayout();
            panelCharts_ARI.SuspendLayout();
            groupBoxCharts_ARI.SuspendLayout();
            tableLayoutPanelCharts_ARI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartBooksByYear_ARI).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartBooksByAuthor_ARI).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartLoansByMonth_ARI).BeginInit();
            tabPageBooks_ARI.SuspendLayout();
            groupBoxTopBooks_ARI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTopBooks_ARI).BeginInit();
            tabPageReaders_ARI.SuspendLayout();
            groupBoxActiveReaders_ARI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewActiveReaders_ARI).BeginInit();
            panelStatsTop_ARI.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlStats_ARI
            // 
            tabControlStats_ARI.Controls.Add(tabPageGeneral_ARI);
            tabControlStats_ARI.Controls.Add(tabPageBooks_ARI);
            tabControlStats_ARI.Controls.Add(tabPageReaders_ARI);
            tabControlStats_ARI.Dock = DockStyle.Fill;
            tabControlStats_ARI.Location = new Point(0, 67);
            tabControlStats_ARI.Margin = new Padding(3, 4, 3, 4);
            tabControlStats_ARI.Name = "tabControlStats_ARI";
            tabControlStats_ARI.SelectedIndex = 0;
            tabControlStats_ARI.Size = new Size(1371, 881);
            tabControlStats_ARI.TabIndex = 0;
            // 
            // tabPageGeneral_ARI
            // 
            tabPageGeneral_ARI.Controls.Add(tableLayoutPanelGeneral_ARI);
            tabPageGeneral_ARI.Location = new Point(4, 29);
            tabPageGeneral_ARI.Margin = new Padding(3, 4, 3, 4);
            tabPageGeneral_ARI.Name = "tabPageGeneral_ARI";
            tabPageGeneral_ARI.Padding = new Padding(3, 4, 3, 4);
            tabPageGeneral_ARI.Size = new Size(1363, 848);
            tabPageGeneral_ARI.TabIndex = 0;
            tabPageGeneral_ARI.Text = "Общая статистика";
            tabPageGeneral_ARI.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanelGeneral_ARI
            // 
            tableLayoutPanelGeneral_ARI.ColumnCount = 2;
            tableLayoutPanelGeneral_ARI.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanelGeneral_ARI.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanelGeneral_ARI.Controls.Add(panelGeneralStats_ARI, 0, 0);
            tableLayoutPanelGeneral_ARI.Controls.Add(panelCharts_ARI, 1, 0);
            tableLayoutPanelGeneral_ARI.Dock = DockStyle.Fill;
            tableLayoutPanelGeneral_ARI.Location = new Point(3, 4);
            tableLayoutPanelGeneral_ARI.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanelGeneral_ARI.Name = "tableLayoutPanelGeneral_ARI";
            tableLayoutPanelGeneral_ARI.RowCount = 1;
            tableLayoutPanelGeneral_ARI.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelGeneral_ARI.Size = new Size(1357, 840);
            tableLayoutPanelGeneral_ARI.TabIndex = 0;
            // 
            // panelGeneralStats_ARI
            // 
            panelGeneralStats_ARI.Controls.Add(groupBoxGeneralStats_ARI);
            panelGeneralStats_ARI.Dock = DockStyle.Fill;
            panelGeneralStats_ARI.Location = new Point(3, 4);
            panelGeneralStats_ARI.Margin = new Padding(3, 4, 3, 4);
            panelGeneralStats_ARI.Name = "panelGeneralStats_ARI";
            panelGeneralStats_ARI.Size = new Size(401, 832);
            panelGeneralStats_ARI.TabIndex = 0;
            // 
            // groupBoxGeneralStats_ARI
            // 
            groupBoxGeneralStats_ARI.Controls.Add(tableLayoutPanelNumbers_ARI);
            groupBoxGeneralStats_ARI.Dock = DockStyle.Fill;
            groupBoxGeneralStats_ARI.Font = new System.Drawing.Font("Segoe UI", 9.75F, FontStyle.Bold);
            groupBoxGeneralStats_ARI.Location = new Point(0, 0);
            groupBoxGeneralStats_ARI.Margin = new Padding(3, 4, 3, 4);
            groupBoxGeneralStats_ARI.Name = "groupBoxGeneralStats_ARI";
            groupBoxGeneralStats_ARI.Padding = new Padding(3, 4, 3, 4);
            groupBoxGeneralStats_ARI.Size = new Size(401, 832);
            groupBoxGeneralStats_ARI.TabIndex = 0;
            groupBoxGeneralStats_ARI.TabStop = false;
            groupBoxGeneralStats_ARI.Text = "Основные показатели";
            // 
            // tableLayoutPanelNumbers_ARI
            // 
            tableLayoutPanelNumbers_ARI.ColumnCount = 1;
            tableLayoutPanelNumbers_ARI.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelNumbers_ARI.Controls.Add(labelTotalBooks_ARI, 0, 0);
            tableLayoutPanelNumbers_ARI.Controls.Add(labelTotalReaders_ARI, 0, 1);
            tableLayoutPanelNumbers_ARI.Controls.Add(labelActiveLoansStat_ARI, 0, 2);
            tableLayoutPanelNumbers_ARI.Controls.Add(labelTotalLoans_ARI, 0, 3);
            tableLayoutPanelNumbers_ARI.Controls.Add(labelAvgBookPrice_ARI, 0, 4);
            tableLayoutPanelNumbers_ARI.Controls.Add(labelTotalBooksValue_ARI, 0, 5);
            tableLayoutPanelNumbers_ARI.Dock = DockStyle.Fill;
            tableLayoutPanelNumbers_ARI.Location = new Point(3, 26);
            tableLayoutPanelNumbers_ARI.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanelNumbers_ARI.Name = "tableLayoutPanelNumbers_ARI";
            tableLayoutPanelNumbers_ARI.RowCount = 6;
            tableLayoutPanelNumbers_ARI.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanelNumbers_ARI.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanelNumbers_ARI.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanelNumbers_ARI.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanelNumbers_ARI.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanelNumbers_ARI.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanelNumbers_ARI.Size = new Size(395, 802);
            tableLayoutPanelNumbers_ARI.TabIndex = 0;
            // 
            // labelTotalBooks_ARI
            // 
            labelTotalBooks_ARI.AutoSize = true;
            labelTotalBooks_ARI.Dock = DockStyle.Fill;
            labelTotalBooks_ARI.Font = new System.Drawing.Font("Segoe UI", 12F);
            labelTotalBooks_ARI.Location = new Point(3, 0);
            labelTotalBooks_ARI.Name = "labelTotalBooks_ARI";
            labelTotalBooks_ARI.Padding = new Padding(11, 13, 11, 13);
            labelTotalBooks_ARI.Size = new Size(389, 133);
            labelTotalBooks_ARI.TabIndex = 0;
            labelTotalBooks_ARI.Text = "Всего книг: 0";
            labelTotalBooks_ARI.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelTotalReaders_ARI
            // 
            labelTotalReaders_ARI.AutoSize = true;
            labelTotalReaders_ARI.Dock = DockStyle.Fill;
            labelTotalReaders_ARI.Font = new System.Drawing.Font("Segoe UI", 12F);
            labelTotalReaders_ARI.Location = new Point(3, 133);
            labelTotalReaders_ARI.Name = "labelTotalReaders_ARI";
            labelTotalReaders_ARI.Padding = new Padding(11, 13, 11, 13);
            labelTotalReaders_ARI.Size = new Size(389, 133);
            labelTotalReaders_ARI.TabIndex = 1;
            labelTotalReaders_ARI.Text = "Всего читателей: 0";
            labelTotalReaders_ARI.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelActiveLoansStat_ARI
            // 
            labelActiveLoansStat_ARI.AutoSize = true;
            labelActiveLoansStat_ARI.Dock = DockStyle.Fill;
            labelActiveLoansStat_ARI.Font = new System.Drawing.Font("Segoe UI", 12F);
            labelActiveLoansStat_ARI.Location = new Point(3, 266);
            labelActiveLoansStat_ARI.Name = "labelActiveLoansStat_ARI";
            labelActiveLoansStat_ARI.Padding = new Padding(11, 13, 11, 13);
            labelActiveLoansStat_ARI.Size = new Size(389, 133);
            labelActiveLoansStat_ARI.TabIndex = 2;
            labelActiveLoansStat_ARI.Text = "Активных выдач: 0";
            labelActiveLoansStat_ARI.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelTotalLoans_ARI
            // 
            labelTotalLoans_ARI.AutoSize = true;
            labelTotalLoans_ARI.Dock = DockStyle.Fill;
            labelTotalLoans_ARI.Font = new System.Drawing.Font("Segoe UI", 12F);
            labelTotalLoans_ARI.Location = new Point(3, 399);
            labelTotalLoans_ARI.Name = "labelTotalLoans_ARI";
            labelTotalLoans_ARI.Padding = new Padding(11, 13, 11, 13);
            labelTotalLoans_ARI.Size = new Size(389, 133);
            labelTotalLoans_ARI.TabIndex = 3;
            labelTotalLoans_ARI.Text = "Всего выдач: 0";
            labelTotalLoans_ARI.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelAvgBookPrice_ARI
            // 
            labelAvgBookPrice_ARI.AutoSize = true;
            labelAvgBookPrice_ARI.Dock = DockStyle.Fill;
            labelAvgBookPrice_ARI.Font = new System.Drawing.Font("Segoe UI", 12F);
            labelAvgBookPrice_ARI.Location = new Point(3, 532);
            labelAvgBookPrice_ARI.Name = "labelAvgBookPrice_ARI";
            labelAvgBookPrice_ARI.Padding = new Padding(11, 13, 11, 13);
            labelAvgBookPrice_ARI.Size = new Size(389, 133);
            labelAvgBookPrice_ARI.TabIndex = 4;
            labelAvgBookPrice_ARI.Text = "Средняя цена книги: 0 ₽";
            labelAvgBookPrice_ARI.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelTotalBooksValue_ARI
            // 
            labelTotalBooksValue_ARI.AutoSize = true;
            labelTotalBooksValue_ARI.Dock = DockStyle.Fill;
            labelTotalBooksValue_ARI.Font = new System.Drawing.Font("Segoe UI", 12F);
            labelTotalBooksValue_ARI.Location = new Point(3, 665);
            labelTotalBooksValue_ARI.Name = "labelTotalBooksValue_ARI";
            labelTotalBooksValue_ARI.Padding = new Padding(11, 13, 11, 13);
            labelTotalBooksValue_ARI.Size = new Size(389, 137);
            labelTotalBooksValue_ARI.TabIndex = 5;
            labelTotalBooksValue_ARI.Text = "Общая стоимость фонда: 0 ₽";
            labelTotalBooksValue_ARI.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panelCharts_ARI
            // 
            panelCharts_ARI.Controls.Add(groupBoxCharts_ARI);
            panelCharts_ARI.Dock = DockStyle.Fill;
            panelCharts_ARI.Location = new Point(410, 4);
            panelCharts_ARI.Margin = new Padding(3, 4, 3, 4);
            panelCharts_ARI.Name = "panelCharts_ARI";
            panelCharts_ARI.Size = new Size(944, 832);
            panelCharts_ARI.TabIndex = 1;
            // 
            // groupBoxCharts_ARI
            // 
            groupBoxCharts_ARI.Controls.Add(tableLayoutPanelCharts_ARI);
            groupBoxCharts_ARI.Dock = DockStyle.Fill;
            groupBoxCharts_ARI.Font = new System.Drawing.Font("Segoe UI", 9.75F, FontStyle.Bold);
            groupBoxCharts_ARI.Location = new Point(0, 0);
            groupBoxCharts_ARI.Margin = new Padding(3, 4, 3, 4);
            groupBoxCharts_ARI.Name = "groupBoxCharts_ARI";
            groupBoxCharts_ARI.Padding = new Padding(3, 4, 3, 4);
            groupBoxCharts_ARI.Size = new Size(944, 832);
            groupBoxCharts_ARI.TabIndex = 0;
            groupBoxCharts_ARI.TabStop = false;
            groupBoxCharts_ARI.Text = "Графики и диаграммы";
            // 
            // tableLayoutPanelCharts_ARI
            // 
            tableLayoutPanelCharts_ARI.ColumnCount = 1;
            tableLayoutPanelCharts_ARI.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelCharts_ARI.Controls.Add(chartBooksByYear_ARI, 0, 0);
            tableLayoutPanelCharts_ARI.Controls.Add(chartBooksByAuthor_ARI, 0, 1);
            tableLayoutPanelCharts_ARI.Controls.Add(chartLoansByMonth_ARI, 0, 2);
            tableLayoutPanelCharts_ARI.Dock = DockStyle.Fill;
            tableLayoutPanelCharts_ARI.Location = new Point(3, 26);
            tableLayoutPanelCharts_ARI.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanelCharts_ARI.Name = "tableLayoutPanelCharts_ARI";
            tableLayoutPanelCharts_ARI.RowCount = 3;
            tableLayoutPanelCharts_ARI.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanelCharts_ARI.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanelCharts_ARI.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanelCharts_ARI.Size = new Size(938, 802);
            tableLayoutPanelCharts_ARI.TabIndex = 0;
            // 
            // chartBooksByYear_ARI
            // 
            chartArea1.Name = "ChartArea1";
            chartBooksByYear_ARI.ChartAreas.Add(chartArea1);
            chartBooksByYear_ARI.Dock = DockStyle.Fill;
            legend1.Name = "Legend1";
            chartBooksByYear_ARI.Legends.Add(legend1);
            chartBooksByYear_ARI.Location = new Point(3, 4);
            chartBooksByYear_ARI.Margin = new Padding(3, 4, 3, 4);
            chartBooksByYear_ARI.Name = "chartBooksByYear_ARI";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Книги";
            chartBooksByYear_ARI.Series.Add(series1);
            chartBooksByYear_ARI.Size = new Size(932, 259);
            chartBooksByYear_ARI.TabIndex = 0;
            chartBooksByYear_ARI.Text = "Книги по годам издания";
            chartBooksByYear_ARI.Click += chartBooksByYear_ARI_Click;
            // 
            // chartBooksByAuthor_ARI
            // 
            chartArea2.Name = "ChartArea1";
            chartBooksByAuthor_ARI.ChartAreas.Add(chartArea2);
            chartBooksByAuthor_ARI.Dock = DockStyle.Fill;
            legend2.Name = "Legend1";
            chartBooksByAuthor_ARI.Legends.Add(legend2);
            chartBooksByAuthor_ARI.Location = new Point(3, 271);
            chartBooksByAuthor_ARI.Margin = new Padding(3, 4, 3, 4);
            chartBooksByAuthor_ARI.Name = "chartBooksByAuthor_ARI";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Книги";
            chartBooksByAuthor_ARI.Series.Add(series2);
            chartBooksByAuthor_ARI.Size = new Size(932, 259);
            chartBooksByAuthor_ARI.TabIndex = 1;
            chartBooksByAuthor_ARI.Text = "Книги по авторам";
            // 
            // chartLoansByMonth_ARI
            // 
            chartArea3.Name = "ChartArea1";
            chartLoansByMonth_ARI.ChartAreas.Add(chartArea3);
            chartLoansByMonth_ARI.Dock = DockStyle.Fill;
            legend3.Name = "Legend1";
            chartLoansByMonth_ARI.Legends.Add(legend3);
            chartLoansByMonth_ARI.Location = new Point(3, 538);
            chartLoansByMonth_ARI.Margin = new Padding(3, 4, 3, 4);
            chartLoansByMonth_ARI.Name = "chartLoansByMonth_ARI";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Выдачи";
            chartLoansByMonth_ARI.Series.Add(series3);
            chartLoansByMonth_ARI.Size = new Size(932, 260);
            chartLoansByMonth_ARI.TabIndex = 2;
            chartLoansByMonth_ARI.Text = "Выдачи по месяцам";
            // 
            // tabPageBooks_ARI
            // 
            tabPageBooks_ARI.Controls.Add(groupBoxTopBooks_ARI);
            tabPageBooks_ARI.Location = new Point(4, 29);
            tabPageBooks_ARI.Margin = new Padding(3, 4, 3, 4);
            tabPageBooks_ARI.Name = "tabPageBooks_ARI";
            tabPageBooks_ARI.Padding = new Padding(3, 4, 3, 4);
            tabPageBooks_ARI.Size = new Size(1363, 848);
            tabPageBooks_ARI.TabIndex = 1;
            tabPageBooks_ARI.Text = "Топ книг";
            tabPageBooks_ARI.UseVisualStyleBackColor = true;
            // 
            // groupBoxTopBooks_ARI
            // 
            groupBoxTopBooks_ARI.Controls.Add(dataGridViewTopBooks_ARI);
            groupBoxTopBooks_ARI.Dock = DockStyle.Fill;
            groupBoxTopBooks_ARI.Font = new System.Drawing.Font("Segoe UI", 9.75F, FontStyle.Bold);
            groupBoxTopBooks_ARI.Location = new Point(3, 4);
            groupBoxTopBooks_ARI.Margin = new Padding(3, 4, 3, 4);
            groupBoxTopBooks_ARI.Name = "groupBoxTopBooks_ARI";
            groupBoxTopBooks_ARI.Padding = new Padding(3, 4, 3, 4);
            groupBoxTopBooks_ARI.Size = new Size(1357, 840);
            groupBoxTopBooks_ARI.TabIndex = 0;
            groupBoxTopBooks_ARI.TabStop = false;
            groupBoxTopBooks_ARI.Text = "10 самых популярных книг";
            // 
            // dataGridViewTopBooks_ARI
            // 
            dataGridViewTopBooks_ARI.AllowUserToAddRows = false;
            dataGridViewTopBooks_ARI.AllowUserToDeleteRows = false;
            dataGridViewTopBooks_ARI.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewTopBooks_ARI.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTopBooks_ARI.Columns.AddRange(new DataGridViewColumn[] { ColumnBookTitle, ColumnLoanCount, ColumnLastLoan });
            dataGridViewTopBooks_ARI.Dock = DockStyle.Fill;
            dataGridViewTopBooks_ARI.Location = new Point(3, 26);
            dataGridViewTopBooks_ARI.Margin = new Padding(3, 4, 3, 4);
            dataGridViewTopBooks_ARI.Name = "dataGridViewTopBooks_ARI";
            dataGridViewTopBooks_ARI.ReadOnly = true;
            dataGridViewTopBooks_ARI.RowHeadersVisible = false;
            dataGridViewTopBooks_ARI.RowHeadersWidth = 51;
            dataGridViewTopBooks_ARI.Size = new Size(1351, 810);
            dataGridViewTopBooks_ARI.TabIndex = 0;
            // 
            // ColumnBookTitle
            // 
            ColumnBookTitle.HeaderText = "Название книги";
            ColumnBookTitle.MinimumWidth = 6;
            ColumnBookTitle.Name = "ColumnBookTitle";
            ColumnBookTitle.ReadOnly = true;
            // 
            // ColumnLoanCount
            // 
            ColumnLoanCount.HeaderText = "Количество выдач";
            ColumnLoanCount.MinimumWidth = 6;
            ColumnLoanCount.Name = "ColumnLoanCount";
            ColumnLoanCount.ReadOnly = true;
            // 
            // ColumnLastLoan
            // 
            ColumnLastLoan.HeaderText = "Последняя выдача";
            ColumnLastLoan.MinimumWidth = 6;
            ColumnLastLoan.Name = "ColumnLastLoan";
            ColumnLastLoan.ReadOnly = true;
            // 
            // tabPageReaders_ARI
            // 
            tabPageReaders_ARI.Controls.Add(groupBoxActiveReaders_ARI);
            tabPageReaders_ARI.Location = new Point(4, 29);
            tabPageReaders_ARI.Margin = new Padding(3, 4, 3, 4);
            tabPageReaders_ARI.Name = "tabPageReaders_ARI";
            tabPageReaders_ARI.Padding = new Padding(3, 4, 3, 4);
            tabPageReaders_ARI.Size = new Size(1363, 848);
            tabPageReaders_ARI.TabIndex = 2;
            tabPageReaders_ARI.Text = "Активные читатели";
            tabPageReaders_ARI.UseVisualStyleBackColor = true;
            // 
            // groupBoxActiveReaders_ARI
            // 
            groupBoxActiveReaders_ARI.Controls.Add(dataGridViewActiveReaders_ARI);
            groupBoxActiveReaders_ARI.Dock = DockStyle.Fill;
            groupBoxActiveReaders_ARI.Font = new System.Drawing.Font("Segoe UI", 9.75F, FontStyle.Bold);
            groupBoxActiveReaders_ARI.Location = new Point(3, 4);
            groupBoxActiveReaders_ARI.Margin = new Padding(3, 4, 3, 4);
            groupBoxActiveReaders_ARI.Name = "groupBoxActiveReaders_ARI";
            groupBoxActiveReaders_ARI.Padding = new Padding(3, 4, 3, 4);
            groupBoxActiveReaders_ARI.Size = new Size(1357, 840);
            groupBoxActiveReaders_ARI.TabIndex = 0;
            groupBoxActiveReaders_ARI.TabStop = false;
            groupBoxActiveReaders_ARI.Text = "Читатели с активными выдачами";
            // 
            // dataGridViewActiveReaders_ARI
            // 
            dataGridViewActiveReaders_ARI.AllowUserToAddRows = false;
            dataGridViewActiveReaders_ARI.AllowUserToDeleteRows = false;
            dataGridViewActiveReaders_ARI.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewActiveReaders_ARI.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewActiveReaders_ARI.Columns.AddRange(new DataGridViewColumn[] { ColumnCardNumber, ColumnBooksCount, ColumnIssueDate });
            dataGridViewActiveReaders_ARI.Dock = DockStyle.Fill;
            dataGridViewActiveReaders_ARI.Location = new Point(3, 26);
            dataGridViewActiveReaders_ARI.Margin = new Padding(3, 4, 3, 4);
            dataGridViewActiveReaders_ARI.Name = "dataGridViewActiveReaders_ARI";
            dataGridViewActiveReaders_ARI.ReadOnly = true;
            dataGridViewActiveReaders_ARI.RowHeadersVisible = false;
            dataGridViewActiveReaders_ARI.RowHeadersWidth = 51;
            dataGridViewActiveReaders_ARI.Size = new Size(1351, 810);
            dataGridViewActiveReaders_ARI.TabIndex = 0;
            // 
            // ColumnCardNumber
            // 
            ColumnCardNumber.HeaderText = "Номер билета";
            ColumnCardNumber.MinimumWidth = 6;
            ColumnCardNumber.Name = "ColumnCardNumber";
            ColumnCardNumber.ReadOnly = true;
            // 
            // ColumnBooksCount
            // 
            ColumnBooksCount.HeaderText = "Количество книг";
            ColumnBooksCount.MinimumWidth = 6;
            ColumnBooksCount.Name = "ColumnBooksCount";
            ColumnBooksCount.ReadOnly = true;
            // 
            // ColumnIssueDate
            // 
            ColumnIssueDate.HeaderText = "Дата первой выдачи";
            ColumnIssueDate.MinimumWidth = 6;
            ColumnIssueDate.Name = "ColumnIssueDate";
            ColumnIssueDate.ReadOnly = true;
            // 
            // panelStatsTop_ARI
            // 
            panelStatsTop_ARI.Controls.Add(comboBoxChartType_ARI);
            panelStatsTop_ARI.Controls.Add(labelChartType_ARI);
            panelStatsTop_ARI.Controls.Add(buttonExportStats_ARI);
            panelStatsTop_ARI.Controls.Add(buttonRefreshStats_ARI);
            panelStatsTop_ARI.Dock = DockStyle.Top;
            panelStatsTop_ARI.Location = new Point(0, 0);
            panelStatsTop_ARI.Margin = new Padding(3, 4, 3, 4);
            panelStatsTop_ARI.Name = "panelStatsTop_ARI";
            panelStatsTop_ARI.Size = new Size(1371, 67);
            panelStatsTop_ARI.TabIndex = 1;
            // 
            // comboBoxChartType_ARI
            // 
            comboBoxChartType_ARI.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxChartType_ARI.FormattingEnabled = true;
            comboBoxChartType_ARI.Items.AddRange(new object[] { "Столбчатая диаграмма", "Круговая диаграмма" });
            comboBoxChartType_ARI.Location = new Point(800, 16);
            comboBoxChartType_ARI.Margin = new Padding(3, 4, 3, 4);
            comboBoxChartType_ARI.Name = "comboBoxChartType_ARI";
            comboBoxChartType_ARI.Size = new Size(171, 28);
            comboBoxChartType_ARI.TabIndex = 3;
            comboBoxChartType_ARI.SelectedIndexChanged += ComboBoxChartType_ARI_SelectedIndexChanged;
            // 
            // labelChartType_ARI
            // 
            labelChartType_ARI.AutoSize = true;
            labelChartType_ARI.Location = new Point(686, 20);
            labelChartType_ARI.Name = "labelChartType_ARI";
            labelChartType_ARI.Size = new Size(123, 20);
            labelChartType_ARI.TabIndex = 2;
            labelChartType_ARI.Text = "Тип диаграммы:";
            // 
            // buttonExportStats_ARI
            // 
            buttonExportStats_ARI.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonExportStats_ARI.Location = new Point(1209, 16);
            buttonExportStats_ARI.Margin = new Padding(3, 4, 3, 4);
            buttonExportStats_ARI.Name = "buttonExportStats_ARI";
            buttonExportStats_ARI.Size = new Size(149, 33);
            buttonExportStats_ARI.TabIndex = 1;
            buttonExportStats_ARI.Text = "Экспорт отчета";
            buttonExportStats_ARI.UseVisualStyleBackColor = true;
            buttonExportStats_ARI.Click += ButtonExportStats_ARI_Click;
            // 
            // buttonRefreshStats_ARI
            // 
            buttonRefreshStats_ARI.Location = new Point(14, 16);
            buttonRefreshStats_ARI.Margin = new Padding(3, 4, 3, 4);
            buttonRefreshStats_ARI.Name = "buttonRefreshStats_ARI";
            buttonRefreshStats_ARI.Size = new Size(149, 33);
            buttonRefreshStats_ARI.TabIndex = 0;
            buttonRefreshStats_ARI.Text = "Обновить";
            buttonRefreshStats_ARI.UseVisualStyleBackColor = true;
            buttonRefreshStats_ARI.Click += ButtonRefreshStats_ARI_Click;
            // 
            // FormStatistics_ARI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1371, 948);
            Controls.Add(tabControlStats_ARI);
            Controls.Add(panelStatsTop_ARI);
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(1387, 984);
            Name = "FormStatistics_ARI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Статистика библиотеки - ARI";
            Load += FormStatistics_ARI_Load;
            tabControlStats_ARI.ResumeLayout(false);
            tabPageGeneral_ARI.ResumeLayout(false);
            tableLayoutPanelGeneral_ARI.ResumeLayout(false);
            panelGeneralStats_ARI.ResumeLayout(false);
            groupBoxGeneralStats_ARI.ResumeLayout(false);
            tableLayoutPanelNumbers_ARI.ResumeLayout(false);
            tableLayoutPanelNumbers_ARI.PerformLayout();
            panelCharts_ARI.ResumeLayout(false);
            groupBoxCharts_ARI.ResumeLayout(false);
            tableLayoutPanelCharts_ARI.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartBooksByYear_ARI).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartBooksByAuthor_ARI).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartLoansByMonth_ARI).EndInit();
            tabPageBooks_ARI.ResumeLayout(false);
            groupBoxTopBooks_ARI.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewTopBooks_ARI).EndInit();
            tabPageReaders_ARI.ResumeLayout(false);
            groupBoxActiveReaders_ARI.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewActiveReaders_ARI).EndInit();
            panelStatsTop_ARI.ResumeLayout(false);
            panelStatsTop_ARI.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlStats_ARI;
        private TabPage tabPageGeneral_ARI;
        private TabPage tabPageBooks_ARI;
        private TabPage tabPageReaders_ARI;
        private Panel panelStatsTop_ARI;
        private Button buttonRefreshStats_ARI;
        private Button buttonExportStats_ARI;
        private TableLayoutPanel tableLayoutPanelGeneral_ARI;
        private Panel panelGeneralStats_ARI;
        private GroupBox groupBoxGeneralStats_ARI;
        private TableLayoutPanel tableLayoutPanelNumbers_ARI;
        private Label labelTotalBooks_ARI;
        private Label labelTotalReaders_ARI;
        private Label labelActiveLoansStat_ARI;
        private Label labelTotalLoans_ARI;
        private Label labelAvgBookPrice_ARI;
        private Label labelTotalBooksValue_ARI;
        private Panel panelCharts_ARI;
        private GroupBox groupBoxCharts_ARI;
        private TableLayoutPanel tableLayoutPanelCharts_ARI;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartBooksByYear_ARI;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartBooksByAuthor_ARI;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartLoansByMonth_ARI;
        private GroupBox groupBoxTopBooks_ARI;
        private DataGridView dataGridViewTopBooks_ARI;
        private DataGridViewTextBoxColumn ColumnBookTitle;
        private DataGridViewTextBoxColumn ColumnLoanCount;
        private DataGridViewTextBoxColumn ColumnLastLoan;
        private GroupBox groupBoxActiveReaders_ARI;
        private DataGridView dataGridViewActiveReaders_ARI;
        private DataGridViewTextBoxColumn ColumnCardNumber;
        private DataGridViewTextBoxColumn ColumnBooksCount;
        private DataGridViewTextBoxColumn ColumnIssueDate;
        private ComboBox comboBoxChartType_ARI;
        private Label labelChartType_ARI;
    }
}