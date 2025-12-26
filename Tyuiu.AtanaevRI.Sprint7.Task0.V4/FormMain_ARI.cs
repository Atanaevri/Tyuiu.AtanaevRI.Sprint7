using Tyuiu.AtanaevRI.Sprint7.Task0.V4.Lib;
using System.Drawing;

namespace Tyuiu.AtanaevRI.Sprint7.Task0.V4
{
    public partial class FormMain_ARI : Form
    {
        private DataService _dataService = null!;
        private readonly string _dataPath = Path.Combine(Application.StartupPath, "Data");

        public FormMain_ARI()
        {
            InitializeComponent();
            
            buttonExit_ARI.Image = SystemIcons.Error.ToBitmap();

           
            menuItemAbout_ARI.Image = SystemIcons.Information.ToBitmap();

           
            InitializeApplication();
        }

        private void InitializeApplication()
        {
            _dataService = new DataService();
            LoadData();
            SetupToolTips();
        }

        private void LoadData()
        {
            try
            {
                string booksPath = Path.Combine(_dataPath, "Books.csv");
                string readersPath = Path.Combine(_dataPath, "Readers.csv");
                string loansPath = Path.Combine(_dataPath, "BookLoans.csv");

                _dataService.LoadData(booksPath, readersPath, loansPath);
                UpdateStatistics();

                toolStripStatusLabelMessage_ARI.Text = "Данные загружены успешно";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки данных: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetupToolTips()
        {

        
            buttonBooks_ARI.ToolTipText = "Управление книгами";
            buttonReaders_ARI.ToolTipText = "Управление читателями";
            buttonLoans_ARI.ToolTipText = "Выдача/возврат книг";
            buttonStatistics_ARI.ToolTipText = "Просмотр статистики";
            buttonSave_ARI.ToolTipText = "Сохранить все данные";
            buttonExit_ARI.ToolTipText = "Выход из программы";

          
        }


        private void UpdateStatistics()
        {
            try
            {
                var stats = _dataService.GetBooksStatistics();
                labelBooksCount_ARI.Text = $"Книг: {stats.Count}";
                labelBooksTotal_ARI.Text = $"Общая стоимость: {stats.TotalPrice:C}";
                labelBooksAvg_ARI.Text = $"Средняя цена: {stats.AveragePrice:C}";
                labelActiveLoans_ARI.Text = $"Активных выдач: {_dataService.GetActiveLoansCount()}";
                labelReadersCount_ARI.Text = $"Читателей: {_dataService.GetReadersCount()}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка обновления статистики: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonBooks_ARI_Click(object sender, EventArgs e)
        {
            var form = new FormBooks_ARI(_dataService);
            form.ShowDialog();
            UpdateStatistics();
        }

        private void ButtonReaders_ARI_Click(object sender, EventArgs e)
        {
            var form = new FormReaders_ARI(_dataService);
            form.ShowDialog();
            UpdateStatistics();
        }

        private void ButtonLoans_ARI_Click(object sender, EventArgs e)
        {
            var form = new FormLoans_ARI(_dataService);
            form.ShowDialog();
            UpdateStatistics();
        }

        private void ButtonStatistics_ARI_Click(object sender, EventArgs e)
        {
            var form = new FormStatistics_ARI(_dataService);
            form.ShowDialog();
        }

        private void ButtonSave_ARI_Click(object sender, EventArgs e)
        {
            try
            {
                string booksPath = Path.Combine(_dataPath, "Books.csv");
                string readersPath = Path.Combine(_dataPath, "Readers.csv");
                string loansPath = Path.Combine(_dataPath, "BookLoans.csv");

                _dataService.SaveData(booksPath, readersPath, loansPath);
                toolStripStatusLabelMessage_ARI.Text = "Данные успешно сохранены";
                MessageBox.Show("Данные успешно сохранены", "Сохранение",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка сохранения: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MenuItemAbout_ARI_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Библиотечная система \nРазработчик: Атанаев Р.И.\n© 2025",
                "О программе", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MenuItemHelp_ARI_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Краткое руководство:\n\n" +
                "1. Используйте кнопки на панели инструментов для навигации\n" +
                "2. Книги - управление книгами библиотеки\n" +
                "3. Читатели - управление читателями\n" +
                "4. Выдача - регистрация выдачи и возврата книг\n" +
                "5. Статистика - просмотр статистики и графиков\n" +
                "6. Не забывайте сохранять данные!",
                "Руководство пользователя", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MenuItemExit_ARI_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Сохранить изменения перед выходом?", "Выход",
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ButtonSave_ARI_Click(sender, e);
            }

            if (MessageBox.Show("Вы действительно хотите выйти?", "Подтверждение выхода",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void ButtonExit_ARI_Click(object sender, EventArgs e)
        {
            MenuItemExit_ARI_Click(sender, e);
        }

        private void FormMain_ARI_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Сохранить изменения перед выходом?", "Выход",
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ButtonSave_ARI_Click(sender, e);
            }
        }

        private void FormMain_ARI_Load(object sender, EventArgs e)
        {

        }

        private void labelWelcome_ARI_Click(object sender, EventArgs e)
        {

        }
    }

}
