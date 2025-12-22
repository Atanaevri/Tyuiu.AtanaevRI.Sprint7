using Tyuiu.AtanaevRI.Sprint7.Task0.V4.Lib;
using Tyuiu.AtanaevRI.Sprint7.Task0.V4.Lib.Models;
using System.Drawing;
namespace Tyuiu.AtanaevRI.Sprint7.Task0.V4
{
    public partial class FormLoans_ARI : Form
    {
        private DataService _dataService = null!;
        private List<BookLoan> _currentLoans = new List<BookLoan>();
        private List<Book> _allBooks = new List<Book>();
        private List<Reader> _allReaders = new List<Reader>();

        public FormLoans_ARI(DataService dataService)
        {
            InitializeComponent();
            _dataService = dataService;
            LoadData();
            SetupDataGridView();
            SetupToolTips();
        }

        private void LoadData()
        {
            _allBooks = _dataService.GetBooks();
            _allReaders = _dataService.GetReaders();
            _currentLoans = _dataService.GetBookLoans();

            dataGridViewLoans_ARI.DataSource = null;
            dataGridViewLoans_ARI.DataSource = _currentLoans;

            LoadComboBoxes();
            UpdateLoansCount();
        }

        private void LoadComboBoxes()
        {
            comboBoxBook_ARI.Items.Clear();
            comboBoxReader_ARI.Items.Clear();

            foreach (var book in _allBooks)
            {
                comboBoxBook_ARI.Items.Add($"{book.Id}. {book.Title} ({book.Author})");
            }

            foreach (var reader in _allReaders)
            {
                comboBoxReader_ARI.Items.Add($"{reader.CardNumber}. {reader.FullName}");
            }

            if (comboBoxBook_ARI.Items.Count > 0)
                comboBoxBook_ARI.SelectedIndex = 0;
            if (comboBoxReader_ARI.Items.Count > 0)
                comboBoxReader_ARI.SelectedIndex = 0;
        }

        private void SetupDataGridView()
        {
            dataGridViewLoans_ARI.AutoGenerateColumns = false;
            dataGridViewLoans_ARI.Columns.Clear();

            dataGridViewLoans_ARI.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Id",
                HeaderText = "ID",
                Width = 50
            });

            dataGridViewLoans_ARI.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "BookTitle",
                HeaderText = "Книга",
                Width = 200
            });

            dataGridViewLoans_ARI.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "ReaderCardNumber",
                HeaderText = "Номер билета",
                Width = 100
            });

            dataGridViewLoans_ARI.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "IssueDate",
                HeaderText = "Дата выдачи",
                Width = 100,
                DefaultCellStyle = new DataGridViewCellStyle() { Format = "dd.MM.yyyy" }
            });

            dataGridViewLoans_ARI.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "ReturnDate",
                HeaderText = "Дата возврата",
                Width = 100,
                DefaultCellStyle = new DataGridViewCellStyle() { Format = "dd.MM.yyyy", NullValue = "Не возвращена" }
            });
        }

        private void SetupToolTips()
        {
            var toolTip = new ToolTip();
            toolTip.SetToolTip(buttonIssueBook_ARI, "Выдать книгу читателю");
            toolTip.SetToolTip(buttonReturnBook_ARI, "Отметить возврат книги");
            toolTip.SetToolTip(buttonDeleteLoan_ARI, "Удалить запись о выдаче");
            toolTip.SetToolTip(buttonSearchLoan_ARI, "Поиск по названию книги или номеру билета");
            toolTip.SetToolTip(buttonRefreshLoans_ARI, "Обновить список");
            toolTip.SetToolTip(comboBoxFilterStatus_ARI, "Фильтр по статусу выдачи");
        }

        private void UpdateLoansCount()
        {
            labelLoansCount_ARI.Text = $"Всего выдач: {_currentLoans.Count}";
            labelActiveLoansCount_ARI.Text = $"Активных: {_currentLoans.Count(l => l.ReturnDate == null)}";
        }

        private void ButtonIssueBook_ARI_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxBook_ARI.SelectedIndex == -1 || comboBoxReader_ARI.SelectedIndex == -1)
                {
                    MessageBox.Show("Выберите книгу и читателя", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var selectedBook = _allBooks[comboBoxBook_ARI.SelectedIndex];
                var selectedReader = _allReaders[comboBoxReader_ARI.SelectedIndex];

                // Проверяем, не выдана ли уже эта книга
                var activeLoan = _currentLoans.FirstOrDefault(l =>
                    l.BookTitle == selectedBook.Title && l.ReturnDate == null);

                if (activeLoan != null)
                {
                    MessageBox.Show("Эта книга уже выдана другому читателю", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var newLoan = new BookLoan
                {
                    Id = _currentLoans.Count > 0 ? _currentLoans.Max(l => l.Id) + 1 : 1,
                    BookTitle = selectedBook.Title,
                    ReaderCardNumber = selectedReader.CardNumber,
                    IssueDate = dateTimePickerIssueDate_ARI.Value,
                    ReturnDate = null
                };

                _dataService.AddBookLoan(newLoan);
                LoadData();

                MessageBox.Show($"Книга '{selectedBook.Title}' выдана читателю {selectedReader.FullName}",
                    "Книга выдана", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при выдаче книги: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonReturnBook_ARI_Click(object sender, EventArgs e)
        {
            if (dataGridViewLoans_ARI.SelectedRows.Count > 0)
            {
                try
                {
                    var loan = (BookLoan)dataGridViewLoans_ARI.SelectedRows[0].DataBoundItem;

                    if (loan.ReturnDate != null)
                    {
                        MessageBox.Show("Эта книга уже возвращена", "Информация",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    var result = MessageBox.Show($"Отметить возврат книги '{loan.BookTitle}'?",
                        "Подтверждение возврата", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        _dataService.ReturnBook(loan.Id);
                        LoadData();
                        MessageBox.Show("Книга отмечена как возвращенная", "Успех",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при возврате книги: {ex.Message}", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Выберите запись о выдаче для возврата", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ButtonDeleteLoan_ARI_Click(object sender, EventArgs e)
        {
            if (dataGridViewLoans_ARI.SelectedRows.Count > 0)
            {
                try
                {
                    var loan = (BookLoan)dataGridViewLoans_ARI.SelectedRows[0].DataBoundItem;

                    var result = MessageBox.Show($"Удалить запись о выдаче книги '{loan.BookTitle}'?",
                        "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        _currentLoans.RemoveAll(l => l.Id == loan.Id);
                        dataGridViewLoans_ARI.DataSource = null;
                        dataGridViewLoans_ARI.DataSource = _currentLoans;
                        UpdateLoansCount();

                        MessageBox.Show("Запись о выдаче удалена", "Успех",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при удалении: {ex.Message}", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Выберите запись для удаления", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void TextBoxSearchLoan_ARI_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBoxSearchLoan_ARI.Text))
                {
                    dataGridViewLoans_ARI.DataSource = null;
                    dataGridViewLoans_ARI.DataSource = _currentLoans;
                }
                else
                {
                    var keyword = textBoxSearchLoan_ARI.Text.ToLower();
                    var filtered = _currentLoans.Where(l =>
                        l.BookTitle.ToLower().Contains(keyword) ||
                        l.ReaderCardNumber.ToLower().Contains(keyword)).ToList();

                    dataGridViewLoans_ARI.DataSource = null;
                    dataGridViewLoans_ARI.DataSource = filtered;
                }
                UpdateLoansCount();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при поиске: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonSearchLoan_ARI_Click(object sender, EventArgs e)
        {
            TextBoxSearchLoan_ARI_TextChanged(sender, e);
        }

        private void ButtonRefreshLoans_ARI_Click(object sender, EventArgs e)
        {
            textBoxSearchLoan_ARI.Clear();
            comboBoxFilterStatus_ARI.SelectedIndex = -1;
            LoadData();
        }

        private void ComboBoxFilterStatus_ARI_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                switch (comboBoxFilterStatus_ARI.SelectedIndex)
                {
                    case 0: // Все
                        dataGridViewLoans_ARI.DataSource = null;
                        dataGridViewLoans_ARI.DataSource = _currentLoans;
                        break;
                    case 1: // Активные (не возвращенные)
                        var active = _currentLoans.Where(l => l.ReturnDate == null).ToList();
                        dataGridViewLoans_ARI.DataSource = null;
                        dataGridViewLoans_ARI.DataSource = active;
                        break;
                    case 2: // Возвращенные
                        var returned = _currentLoans.Where(l => l.ReturnDate != null).ToList();
                        dataGridViewLoans_ARI.DataSource = null;
                        dataGridViewLoans_ARI.DataSource = returned;
                        break;
                }
                UpdateLoansCount();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при фильтрации: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DataGridViewLoans_ARI_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var loan = (BookLoan)dataGridViewLoans_ARI.Rows[e.RowIndex].DataBoundItem;
                if (loan.ReturnDate == null)
                {
                    ButtonReturnBook_ARI_Click(sender, e);
                }
            }
        }

        private void FormLoans_ARI_Load(object sender, EventArgs e)
        {
            dateTimePickerIssueDate_ARI.Value = DateTime.Now;
            if (comboBoxFilterStatus_ARI.Items.Count > 0)
                comboBoxFilterStatus_ARI.SelectedIndex = 0;
        }
    }
}