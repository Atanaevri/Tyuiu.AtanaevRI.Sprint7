using Tyuiu.AtanaevRI.Sprint7.Task0.V4.Lib;

namespace Tyuiu.AtanaevRI.Sprint7.Task0.V4
{
    public partial class FormLoans_ARI : Form
    {
        private DataService _dataService;

        public FormLoans_ARI(DataService dataService)
        {
            InitializeComponent();
            _dataService = dataService;
            this.Text = "Выдача и возврат книг - ARI";
        }

        private void FormLoans_ARI_Load(object sender, EventArgs e)
        {

        }
    }
}