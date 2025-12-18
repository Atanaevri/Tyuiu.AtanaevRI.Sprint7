using Tyuiu.AtanaevRI.Sprint7.Task0.V4.Lib;
using Tyuiu.AtanaevRI.Sprint7.Task0.V4.Lib.Models;

namespace Tyuiu.AtanaevRI.Sprint7.Task0.V4
{
    public partial class FormBooks_ARI : Form
    {
        private DataService _dataService;
        private List<Book> _currentBooks = new List<Book>(); // Инициализируем здесь

        public FormBooks_ARI(DataService dataService)
        {
            InitializeComponent();
            _dataService = dataService;
            LoadBooks();
            SetupDataGridView();
            SetupToolTips();
        }

        private void LoadBooks()
        {
            _currentBooks = _dataService.GetBooks();
            dataGridViewBooks_ARI.DataSource = null; // Сначала очищаем
            dataGridViewBooks_ARI.DataSource = _currentBooks;
            UpdateBooksCount();
        }

        private void SetupDataGridView()
        {
            dataGridViewBooks_ARI.AutoGenerateColumns = false;
            dataGridViewBooks_ARI.Columns.Clear();

            // Настройка колонок
            dataGridViewBooks_ARI.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Id",
                HeaderText = "ID",
                Width = 50
            });

            dataGridViewBooks_ARI.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Author",
                HeaderText = "Автор",
                Width = 150
            });

            dataGridViewBooks_ARI.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Title",
                HeaderText = "Название",
                Width = 200
            });

            dataGridViewBooks_ARI.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Year",
                HeaderText = "Год",
                Width = 60
            });

            dataGridViewBooks_ARI.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Price",
                HeaderText = "Цена",
                Width = 80,
                DefaultCellStyle = new DataGridViewCellStyle() { Format = "C2" }
            });

            dataGridViewBooks_ARI.Columns.Add(new DataGridViewCheckBoxColumn()
            {
                DataPropertyName = "IsNewEdition",
                HeaderText = "Новое издание",
                Width = 100
            });

            // Колонка для аннотации
            dataGridViewBooks_ARI.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Annotation",
                HeaderText = "Аннотация",
                Width = 250,
                DefaultCellStyle = new DataGridViewCellStyle() { WrapMode = DataGridViewTriState.True }
            });
        }

        private void SetupToolTips()
        {
            var toolTip = new ToolTip();
            toolTip.SetToolTip(buttonAddBook_ARI, "Добавить новую книгу");
            toolTip.SetToolTip(buttonEditBook_ARI, "Редактировать выбранную книгу");
            toolTip.SetToolTip(buttonDeleteBook_ARI, "Удалить выбранную книгу");
            toolTip.SetToolTip(buttonSearchBook_ARI, "Поиск по автору или названию");
            toolTip.SetToolTip(buttonRefreshBooks_ARI, "Обновить список");
            toolTip.SetToolTip(buttonExportBooks_ARI, "Экспорт данных в файл");
        }

        private void UpdateBooksCount()
        {
            labelBooksCount_ARI.Text = $"Найдено книг: {_currentBooks.Count}";
        }

        private void ButtonAddBook_ARI_Click(object sender, EventArgs e)
        {
            try
            {
                var form = new FormEditBook_ARI(null);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    var book = form.GetBook();
                    // Автоматически генерируем ID
                    book.Id = _currentBooks.Count > 0 ? _currentBooks.Max(b => b.Id) + 1 : 1;
                    _dataService.AddBook(book);
                    LoadBooks();
                    MessageBox.Show("Книга успешно добавлена", "Успех",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при добавлении книги: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonEditBook_ARI_Click(object sender, EventArgs e)
        {
            if (dataGridViewBooks_ARI.SelectedRows.Count > 0)
            {
                try
                {
                    var book = (Book)dataGridViewBooks_ARI.SelectedRows[0].DataBoundItem;
                    var form = new FormEditBook_ARI(book);
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        _dataService.UpdateBook(form.GetBook());
                        LoadBooks();
                        MessageBox.Show("Книга успешно обновлена", "Успех",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при редактировании: {ex.Message}", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Выберите книгу для редактирования", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ButtonDeleteBook_ARI_Click(object sender, EventArgs e)
        {
            if (dataGridViewBooks_ARI.SelectedRows.Count > 0)
            {
                try
                {
                    var book = (Book)dataGridViewBooks_ARI.SelectedRows[0].DataBoundItem;
                    var result = MessageBox.Show($"Вы действительно хотите удалить книгу '{book.Title}'?",
                        "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        _dataService.DeleteBook(book.Id);
                        LoadBooks();
                        MessageBox.Show("Книга успешно удалена", "Успех",
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
                MessageBox.Show("Выберите книгу для удаления", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void TextBoxSearchBook_ARI_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBoxSearchBook_ARI.Text))
                {
                    LoadBooks();
                }
                else
                {
                    _currentBooks = _dataService.SearchBooks(textBoxSearchBook_ARI.Text);
                    dataGridViewBooks_ARI.DataSource = null;
                    dataGridViewBooks_ARI.DataSource = _currentBooks;
                    UpdateBooksCount();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при поиске: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonSearchBook_ARI_Click(object sender, EventArgs e)
        {
            TextBoxSearchBook_ARI_TextChanged(sender, e);
        }

        private void ButtonRefreshBooks_ARI_Click(object sender, EventArgs e)
        {
            textBoxSearchBook_ARI.Clear();
            LoadBooks();
        }

        private void ComboBoxSortBook_ARI_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                switch (comboBoxSortBook_ARI.SelectedIndex)
                {
                    case 0: // По названию (А-Я)
                        _currentBooks = _dataService.SortBooksByTitle(true);
                        break;
                    case 1: // По названию (Я-А)
                        _currentBooks = _dataService.SortBooksByTitle(false);
                        break;
                    case 2: // По году (возрастание)
                        _currentBooks = _dataService.SortBooksByYear(true);
                        break;
                    case 3: // По году (убывание)
                        _currentBooks = _dataService.SortBooksByYear(false);
                        break;
                    case 4: // По цене (возрастание)
                        _currentBooks = _dataService.SortBooksByPrice(true);
                        break;
                    case 5: // По цене (убывание)
                        _currentBooks = _dataService.SortBooksByPrice(false);
                        break;
                }
                dataGridViewBooks_ARI.DataSource = null;
                dataGridViewBooks_ARI.DataSource = _currentBooks;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сортировке: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DataGridViewBooks_ARI_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                ButtonEditBook_ARI_Click(sender, e);
            }
        }

        private void ButtonExportBooks_ARI_Click(object sender, EventArgs e)
        {
            try
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "CSV files (*.csv)|*.csv|Text files (*.txt)|*.txt|All files (*.*)|*.*";
                    saveFileDialog.FilterIndex = 1;
                    saveFileDialog.RestoreDirectory = true;
                    saveFileDialog.FileName = $"Books_Export_{DateTime.Now:yyyyMMdd_HHmmss}.csv";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        var lines = new List<string> { "Id;Author;Title;Year;Price;IsNewEdition;Annotation" };
                        foreach (var book in _currentBooks)
                        {
                            lines.Add($"{book.Id};{book.Author};{book.Title};{book.Year};{book.Price};{book.IsNewEdition};{book.Annotation}");
                        }
                        File.WriteAllLines(saveFileDialog.FileName, lines, System.Text.Encoding.UTF8);
                        MessageBox.Show($"Данные успешно экспортированы в файл:\n{saveFileDialog.FileName}",
                            "Экспорт данных", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка экспорта: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormBooks_ARI_Load(object sender, EventArgs e)
        {
            // Установим первую сортировку по умолчанию
            if (comboBoxSortBook_ARI.Items.Count > 0)
                comboBoxSortBook_ARI.SelectedIndex = 0;
        }
    }
}