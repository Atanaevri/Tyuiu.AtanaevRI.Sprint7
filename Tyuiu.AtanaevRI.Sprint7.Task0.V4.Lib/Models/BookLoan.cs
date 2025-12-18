namespace Tyuiu.AtanaevRI.Sprint7.Task0.V4.Lib.Models
{
    public class BookLoan
    {
        public int Id { get; set; }
        public string BookTitle { get; set; } = string.Empty;
        public string ReaderCardNumber { get; set; } = string.Empty;
        public DateTime IssueDate { get; set; }
        public DateTime? ReturnDate { get; set; }
    }
}