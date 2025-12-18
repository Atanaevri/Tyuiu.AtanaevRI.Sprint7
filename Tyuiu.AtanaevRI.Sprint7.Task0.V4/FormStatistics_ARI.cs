using Tyuiu.AtanaevRI.Sprint7.Task0.V4.Lib;

namespace Tyuiu.AtanaevRI.Sprint7.Task0.V4
{
    public partial class FormStatistics_ARI : Form
    {
        private DataService _dataService;

        public FormStatistics_ARI(DataService dataService)
        {
            InitializeComponent();
            _dataService = dataService;
            this.Text = "Статистика библиотеки - ARI";
        }
    }
}