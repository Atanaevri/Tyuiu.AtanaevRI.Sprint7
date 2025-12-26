using System;
using System.Windows.Forms;
using Tyuiu.AtanaevRI.Sprint7.Task0.V4.Lib.Models;

namespace Tyuiu.AtanaevRI.Sprint7.Task0.V4
{
    public partial class FormEditReader_ARI : Form
    {
        private Reader _reader;

        public FormEditReader_ARI(Reader reader)
        {
            InitializeComponent();
            _reader = reader;

            if (reader != null)
            {
                
                textBoxCardNumber.Text = reader.CardNumber;
                textBoxFullName.Text = reader.FullName;
                textBoxAddress.Text = reader.Address;
                textBoxPhone.Text = reader.Phone;

               
                textBoxCardNumber.ReadOnly = true;
            }
            else
            {
               
                Text = "Добавление нового читателя";
            }
        }

        public Reader GetReader()
        {
            return new Reader
            {
                CardNumber = textBoxCardNumber.Text,
                FullName = textBoxFullName.Text,
                Address = textBoxAddress.Text,
                Phone = textBoxPhone.Text
            };
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
           
            if (string.IsNullOrWhiteSpace(textBoxCardNumber.Text))
            {
                MessageBox.Show("Введите номер билета!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxCardNumber.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxFullName.Text))
            {
                MessageBox.Show("Введите ФИО читателя!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxFullName.Focus();
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void FormEditReader_ARI_Load(object sender, EventArgs e)
        {

        }
    }
}