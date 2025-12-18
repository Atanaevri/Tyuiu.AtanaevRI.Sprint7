namespace Tyuiu.AtanaevRI.Sprint7.Task0.V4.Lib.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Author { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public int Year { get; set; }
        public decimal Price { get; set; }
        public bool IsNewEdition { get; set; }
        public string Annotation { get; set; } = string.Empty;
    }
}