using Tyuiu.AtanaevRI.Sprint7.Task0.V4.Lib;
using Tyuiu.AtanaevRI.Sprint7.Task0.V4.Lib.Models;
using System.Data;

namespace Tyuiu.AtanaevRI.Sprint7.Task0.V4
{
    public partial class FormReaders_ARI : Form
    {
        private DataService _dataService = null!;
        private List<Reader> _currentReaders = new List<Reader>();

        public FormReaders_ARI(DataService dataService)
        {
            InitializeComponent();
            _dataService = dataService;
            LoadReaders();
            SetupDataGridView();
            SetupToolTips();
        }

        private void LoadReaders()
        {
            _currentReaders = _dataService.GetReaders();
            dataGridViewReaders_ARI.DataSource = null;
            dataGridViewReaders_ARI.DataSource = _currentReaders;
            UpdateReadersCount();
        }

        private void SetupDataGridView()
        {
            dataGridViewReaders_ARI.AutoGenerateColumns = false;
            dataGridViewReaders_ARI.Columns.Clear();

            dataGridViewReaders_ARI.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "CardNumber",
                HeaderText = "Номер билета",
                Width = 100
            });

            dataGridViewReaders_ARI.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "FullName",
                HeaderText = "ФИО",
                Width = 200
            });

            dataGridViewReaders_ARI.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Address",
                HeaderText = "Адрес",
                Width = 200
            });

            dataGridViewReaders_ARI.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Phone",
                HeaderText = "Телефон",
                Width = 120
            });
        }

        private void SetupToolTips()
        {
            var toolTip = new ToolTip();
            toolTip.SetToolTip(buttonAddReader_ARI, "Добавить нового читателя");
            toolTip.SetToolTip(buttonEditReader_ARI, "Редактировать выбранного читателя");
            toolTip.SetToolTip(buttonDeleteReader_ARI, "Удалить выбранного читателя");
            toolTip.SetToolTip(buttonSearchReader_ARI, "Поиск по ФИО или номеру билета");
            toolTip.SetToolTip(buttonRefreshReaders_ARI, "Обновить список");
            toolTip.SetToolTip(buttonExportReaders_ARI, "Экспорт данных в файл");
        }

        private void UpdateReadersCount()
        {
            labelReadersCount_ARI.Text = $"Найдено читателей: {_currentReaders.Count}";
        }

        private void ButtonAddReader_ARI_Click(object sender, EventArgs e)
        {
            try
            {
                var form = new FormEditReader_ARI(null);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    var reader = form.GetReader();
                    _dataService.AddReader(reader);
                    LoadReaders();
                    MessageBox.Show("Читатель успешно добавлен", "Успех",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при добавлении читателя: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonEditReader_ARI_Click(object sender, EventArgs e)
        {
            if (dataGridViewReaders_ARI.SelectedRows.Count > 0)
            {
                try
                {
                    var reader = (Reader)dataGridViewReaders_ARI.SelectedRows[0].DataBoundItem;
                    var form = new FormEditReader_ARI(reader);
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        _dataService.UpdateReader(form.GetReader());
                        LoadReaders();
                        MessageBox.Show("Читатель успешно обновлен", "Успех",
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
                MessageBox.Show("Выберите читателя для редактирования", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ButtonDeleteReader_ARI_Click(object sender, EventArgs e)
        {
            if (dataGridViewReaders_ARI.SelectedRows.Count > 0)
            {
                try
                {
                    var reader = (Reader)dataGridViewReaders_ARI.SelectedRows[0].DataBoundItem;
                    var result = MessageBox.Show($"Удалить читателя '{reader.FullName}'?",
                        "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        _dataService.DeleteReader(reader.CardNumber);
                        LoadReaders();
                        MessageBox.Show("Читатель успешно удален", "Успех",
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
                MessageBox.Show("Выберите читателя для удаления", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void TextBoxSearchReader_ARI_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBoxSearchReader_ARI.Text))
                {
                    LoadReaders();
                }
                else
                {
                    var keyword = textBoxSearchReader_ARI.Text.ToLower();
                    _currentReaders = _dataService.SearchReaders(keyword);
                    dataGridViewReaders_ARI.DataSource = null;
                    dataGridViewReaders_ARI.DataSource = _currentReaders;
                    UpdateReadersCount();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при поиске: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonSearchReader_ARI_Click(object sender, EventArgs e)
        {
            TextBoxSearchReader_ARI_TextChanged(sender, e);
        }

        private void ButtonRefreshReaders_ARI_Click(object sender, EventArgs e)
        {
            textBoxSearchReader_ARI.Clear();
            LoadReaders();
        }

        private void ComboBoxSortReader_ARI_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                switch (comboBoxSortReader_ARI.SelectedIndex)
                {
                    case 0: // По ФИО (А-Я)
                        _currentReaders = _currentReaders.OrderBy(r => r.FullName).ToList();
                        break;
                    case 1: // По ФИО (Я-А)
                        _currentReaders = _currentReaders.OrderByDescending(r => r.FullName).ToList();
                        break;
                    case 2: // По номеру билета (возрастание)
                        _currentReaders = _currentReaders.OrderBy(r => r.CardNumber).ToList();
                        break;
                    case 3: // По номеру билета (убывание)
                        _currentReaders = _currentReaders.OrderByDescending(r => r.CardNumber).ToList();
                        break;
                }
                dataGridViewReaders_ARI.DataSource = null;
                dataGridViewReaders_ARI.DataSource = _currentReaders;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сортировке: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DataGridViewReaders_ARI_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                ButtonEditReader_ARI_Click(sender, e);
            }
        }

        private void ButtonExportReaders_ARI_Click(object sender, EventArgs e)
        {
            try
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "CSV files (*.csv)|*.csv|Text files (*.txt)|*.txt|All files (*.*)|*.*";
                    saveFileDialog.FilterIndex = 1;
                    saveFileDialog.RestoreDirectory = true;
                    saveFileDialog.FileName = $"Readers_Export_{DateTime.Now:yyyyMMdd_HHmmss}.csv";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        var lines = new List<string> { "CardNumber;FullName;Address;Phone" };
                        foreach (var reader in _currentReaders)
                        {
                            lines.Add($"{reader.CardNumber};{reader.FullName};{reader.Address};{reader.Phone}");
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

        private void FormReaders_ARI_Load(object sender, EventArgs e)
        {
            if (comboBoxSortReader_ARI.Items.Count > 0)
                comboBoxSortReader_ARI.SelectedIndex = 0;
        }
    }
}