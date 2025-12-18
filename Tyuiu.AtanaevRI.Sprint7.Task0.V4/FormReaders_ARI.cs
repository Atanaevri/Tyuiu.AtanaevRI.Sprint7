using Tyuiu.AtanaevRI.Sprint7.Task0.V4.Lib;

namespace Tyuiu.AtanaevRI.Sprint7.Task0.V4
{
    public partial class FormReaders_ARI : Form
    {
        private DataService _dataService;

        public FormReaders_ARI(DataService dataService)
        {
            InitializeComponent();
            _dataService = dataService;
            this.Text = "Управление читателями - ARI";
        }

        private void FormReaders_ARI_Load(object sender, EventArgs e)
        {

        }
    }
}