using Tyuiu.AtanaevRI.Sprint7.Task0.V4;

namespace Tyuiu.AtanaevRI.Sprint7.Task0.V4
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            // Устанавливаем текущую культуру для корректного отображения валюты
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("ru-RU");
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("ru-RU");

            Application.Run(new FormMain_ARI());
        }
    }
}