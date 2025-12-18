using Tyuiu.AtanaevRI.Sprint7.Task0.V4.Lib.Models;

namespace Tyuiu.AtanaevRI.Sprint7.Task0.V4
{
    public partial class FormEditBook_ARI : Form
    {
        private Book _book;
        private bool _isEditMode;

        public FormEditBook_ARI(Book book)
        {
            InitializeComponent();

            if (book == null)
            {
                _book = new Book();
                _isEditMode = false;
                Text = "Добавление новой книги - ARI";
            }
            else
            {
                _book = book;
                _isEditMode = true;
                Text = "Редактирование книги - ARI";
                LoadBookData();
            }
        }

        private void LoadBookData()
        {
            numericUpDownId_ARI.Value = _book.Id;
            textBoxAuthor_ARI.Text = _book.Author;
            textBoxTitle_ARI.Text = _book.Title;
            numericUpDownYear_ARI.Value = _book.Year;
            numericUpDownPrice_ARI.Value = _book.Price;
            checkBoxIsNewEdition_ARI.Checked = _book.IsNewEdition;
            textBoxAnnotation_ARI.Text = _book.Annotation;
        }

        public Book GetBook()
        {
            return _book;
        }

        private bool ValidateForm()
        {
            if (string.IsNullOrWhiteSpace(textBoxAuthor_ARI.Text))
            {
                MessageBox.Show("Введите автора книги", "Ошибка валидации",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxAuthor_ARI.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(textBoxTitle_ARI.Text))
            {
                MessageBox.Show("Введите название книги", "Ошибка валидации",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxTitle_ARI.Focus();
                return false;
            }

            if (numericUpDownYear_ARI.Value < 1000 || numericUpDownYear_ARI.Value > DateTime.Now.Year + 1)
            {
                MessageBox.Show("Год издания должен быть между 1000 и текущим годом + 1", "Ошибка валидации",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                numericUpDownYear_ARI.Focus();
                return false;
            }

            if (numericUpDownPrice_ARI.Value <= 0)
            {
                MessageBox.Show("Цена должна быть больше 0", "Ошибка валидации",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                numericUpDownPrice_ARI.Focus();
                return false;
            }

            return true;
        }

        private void ButtonSave_ARI_Click(object sender, EventArgs e)
        {
            if (!ValidateForm())
                return;

            _book.Id = (int)numericUpDownId_ARI.Value;
            _book.Author = textBoxAuthor_ARI.Text.Trim();
            _book.Title = textBoxTitle_ARI.Text.Trim();
            _book.Year = (int)numericUpDownYear_ARI.Value;
            _book.Price = numericUpDownPrice_ARI.Value;
            _book.IsNewEdition = checkBoxIsNewEdition_ARI.Checked;
            _book.Annotation = textBoxAnnotation_ARI.Text.Trim();

            DialogResult = DialogResult.OK;
            Close();
        }

        private void ButtonCancel_ARI_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void FormEditBook_ARI_Load(object sender, EventArgs e)
        {
            if (!_isEditMode)
            {
                numericUpDownId_ARI.Value = 0;
                numericUpDownId_ARI.Enabled = false;
            }
        }
    }
}