using Tyuiu.AtanaevRI.Sprint7.Task0.V4.Lib;
using System.Windows.Forms.DataVisualization.Charting;

namespace Tyuiu.AtanaevRI.Sprint7.Task0.V4
{
    public partial class FormStatistics_ARI : Form
    {
        private DataService _dataService = null!;

        public FormStatistics_ARI(DataService dataService)
        {
            InitializeComponent();
            _dataService = dataService;
            LoadStatistics();
        }

        private void LoadStatistics()
        {
            try
            {
               
                var booksStats = _dataService.GetBooksStatistics();
                var booksCount = _dataService.GetBooksCount();
                var readersCount = _dataService.GetReadersCount();
                var activeLoansCount = _dataService.GetActiveLoansCount();
                var totalLoans = _dataService.GetBookLoans().Count;

                
                labelTotalBooks_ARI.Text = $"Всего книг: {booksStats.Count}";
                labelTotalReaders_ARI.Text = $"Всего читателей: {readersCount}";
                labelActiveLoansStat_ARI.Text = $"Активных выдач: {activeLoansCount}";
                labelTotalLoans_ARI.Text = $"Всего выдач: {totalLoans}";
                labelAvgBookPrice_ARI.Text = $"Средняя цена книги: {booksStats.AveragePrice:C}";
                labelTotalBooksValue_ARI.Text = $"Общая стоимость фонда: {booksStats.TotalPrice:C}";

               
                var booksByYear = _dataService.GetBooksCountByYear();
                chartBooksByYear_ARI.Series["Книги"].Points.Clear();
                foreach (var item in booksByYear)
                {
                    chartBooksByYear_ARI.Series["Книги"].Points.AddXY(item.Key, item.Value);
                }

                
                var booksByAuthor = _dataService.GetBooksCountByAuthor();
                chartBooksByAuthor_ARI.Series["Книги"].Points.Clear();
                foreach (var item in booksByAuthor.Take(10)) 
                {
                    chartBooksByAuthor_ARI.Series["Книги"].Points.AddXY(item.Key, item.Value);
                }

               
                var loansByMonth = _dataService.GetLoansByMonth(DateTime.Now.Year);
                chartLoansByMonth_ARI.Series["Выдачи"].Points.Clear();
                foreach (var item in loansByMonth)
                {
                    chartLoansByMonth_ARI.Series["Выдачи"].Points.AddXY(item.Key, item.Value);
                }

              
                ApplyChartType();

          
                FillTopBooksTable();

                FillActiveReadersTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки статистики: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ApplyChartType()
        {
            try
            {
                if (comboBoxChartType_ARI.SelectedIndex == 0) 
                {
               
                    chartBooksByYear_ARI.Series["Книги"].ChartType = SeriesChartType.Column;
                    chartBooksByYear_ARI.Visible = true;

              
                    chartBooksByAuthor_ARI.Visible = false;
                    chartLoansByMonth_ARI.Visible = false;
                }
                else if (comboBoxChartType_ARI.SelectedIndex == 1)   
                {
                  
                    chartBooksByYear_ARI.Series["Книги"].ChartType = SeriesChartType.Pie;
                    chartBooksByAuthor_ARI.Series["Книги"].ChartType = SeriesChartType.Pie;
                    chartLoansByMonth_ARI.Series["Выдачи"].ChartType = SeriesChartType.Pie;

                    chartBooksByYear_ARI.Visible = true;
                    chartBooksByAuthor_ARI.Visible = true;
                    chartLoansByMonth_ARI.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка применения типа графика: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FillTopBooksTable()
        {
            try
            {
                var allLoans = _dataService.GetBookLoans();
                var bookPopularity = allLoans
                    .GroupBy(l => l.BookTitle)
                    .Select(g => new
                    {
                        BookTitle = g.Key,
                        LoanCount = g.Count(),
                        LastLoan = g.Max(l => l.IssueDate)
                    })
                    .OrderByDescending(b => b.LoanCount)
                    .Take(10)
                    .ToList();

                dataGridViewTopBooks_ARI.Rows.Clear();
                foreach (var book in bookPopularity)
                {
                    dataGridViewTopBooks_ARI.Rows.Add(
                        book.BookTitle,
                        book.LoanCount,
                        book.LastLoan.ToString("dd.MM.yyyy")
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки топ книг: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FillActiveReadersTable()
        {
            try
            {
                var activeLoans = _dataService.GetActiveLoans();
                var activeReaders = activeLoans
                    .GroupBy(l => l.ReaderCardNumber)
                    .Select(g => new
                    {
                        CardNumber = g.Key,
                        BooksCount = g.Count(),
                        IssueDate = g.Min(l => l.IssueDate)
                    })
                    .OrderByDescending(r => r.BooksCount)
                    .ToList();

                dataGridViewActiveReaders_ARI.Rows.Clear();
                foreach (var reader in activeReaders)
                {
                    dataGridViewActiveReaders_ARI.Rows.Add(
                        reader.CardNumber,
                        reader.BooksCount,
                        reader.IssueDate.ToString("dd.MM.yyyy")
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки активных читателей: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonExportStats_ARI_Click(object sender, EventArgs e)
        {
            try
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf|Image files (*.png)|*.png|All files (*.*)|*.*";
                    saveFileDialog.FilterIndex = 1;
                    saveFileDialog.RestoreDirectory = true;
                    saveFileDialog.FileName = $"Library_Statistics_{DateTime.Now:yyyyMMdd_HHmmss}.pdf";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                       
                        var lines = new List<string>
                        {
                            "СТАТИСТИКА БИБЛИОТЕКИ",
                            $"Отчет сгенерирован: {DateTime.Now:dd.MM.yyyy HH:mm}",
                            "",
                            "ОСНОВНЫЕ ПОКАЗАТЕЛИ:",
                            $"Всего книг: {_dataService.GetBooksCount()}",
                            $"Всего читателей: {_dataService.GetReadersCount()}",
                            $"Активных выдач: {_dataService.GetActiveLoansCount()}",
                            "",
                            "ТОП-10 САМЫХ ПОПУЛЯРНЫХ КНИГ:"
                        };

                        var allLoans = _dataService.GetBookLoans();
                        var topBooks = allLoans
                            .GroupBy(l => l.BookTitle)
                            .Select(g => new { Title = g.Key, Count = g.Count() })
                            .OrderByDescending(b => b.Count)
                            .Take(10)
                            .ToList();

                        for (int i = 0; i < topBooks.Count; i++)
                        {
                            lines.Add($"{i + 1}. {topBooks[i].Title} - {topBooks[i].Count} выдач");
                        }

                        File.WriteAllLines(saveFileDialog.FileName.Replace(".pdf", ".txt"), lines, System.Text.Encoding.UTF8);
                        MessageBox.Show($"Отчет сохранен в файл:\n{saveFileDialog.FileName.Replace(".pdf", ".txt")}",
                            "Экспорт отчета", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка экспорта: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonRefreshStats_ARI_Click(object sender, EventArgs e)
        {
            LoadStatistics();
        }

        private void ComboBoxChartType_ARI_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyChartType();
        }

        private void FormStatistics_ARI_Load(object sender, EventArgs e)
        {

        }

        private void chartBooksByYear_ARI_Click(object sender, EventArgs e)
        {

        }
    }
}