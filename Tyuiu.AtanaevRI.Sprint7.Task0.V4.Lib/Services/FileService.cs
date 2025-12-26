using System.Globalization;
using Tyuiu.AtanaevRI.Sprint7.Task0.V4.Lib.Models;

namespace Tyuiu.AtanaevRI.Sprint7.Task0.V4.Lib.Services
{
    public class FileService
    {
        public List<Book> LoadBooks(string filePath)
        {
            var books = new List<Book>();

            if (!File.Exists(filePath))
            {
           
                File.WriteAllLines(filePath, new[] { "Id;Author;Title;Year;Price;IsNewEdition;Annotation" });
                return books;
            }

            var lines = File.ReadAllLines(filePath);
            for (int i = 1; i < lines.Length; i++) 
            {
                var values = lines[i].Split(';');
                if (values.Length >= 7)
                {
                    books.Add(new Book
                    {
                        Id = int.TryParse(values[0], out int id) ? id : 0,
                        Author = values[1],
                        Title = values[2],
                        Year = int.TryParse(values[3], out int year) ? year : 0,
                        Price = decimal.TryParse(values[4], NumberStyles.Any, CultureInfo.InvariantCulture, out decimal price) ? price : 0,
                        IsNewEdition = bool.TryParse(values[5], out bool isNew) ? isNew : false,
                        Annotation = values.Length > 6 ? values[6] : string.Empty
                    });
                }
            }
            return books;
        }

        public void SaveBooks(string filePath, List<Book> books)
        {
            var lines = new List<string> { "Id;Author;Title;Year;Price;IsNewEdition;Annotation" };
            foreach (var book in books)
            {
                lines.Add($"{book.Id};{book.Author};{book.Title};{book.Year};{book.Price.ToString(CultureInfo.InvariantCulture)};{book.IsNewEdition};{book.Annotation}");
            }
            File.WriteAllLines(filePath, lines);
        }

        public List<Reader> LoadReaders(string filePath)
        {
            var readers = new List<Reader>();

            if (!File.Exists(filePath))
            {
                File.WriteAllLines(filePath, new[] { "CardNumber;FullName;Address;Phone" });
                return readers;
            }

            var lines = File.ReadAllLines(filePath);
            for (int i = 1; i < lines.Length; i++)
            {
                var values = lines[i].Split(';');
                if (values.Length >= 4)
                {
                    readers.Add(new Reader
                    {
                        CardNumber = values[0],
                        FullName = values[1],
                        Address = values[2],
                        Phone = values[3]
                    });
                }
            }
            return readers;
        }

        public void SaveReaders(string filePath, List<Reader> readers)
        {
            var lines = new List<string> { "CardNumber;FullName;Address;Phone" };
            foreach (var reader in readers)
            {
                lines.Add($"{reader.CardNumber};{reader.FullName};{reader.Address};{reader.Phone}");
            }
            File.WriteAllLines(filePath, lines);
        }

        public List<BookLoan> LoadBookLoans(string filePath)
        {
            var loans = new List<BookLoan>();

            if (!File.Exists(filePath))
            {
                File.WriteAllLines(filePath, new[] { "Id;BookTitle;ReaderCardNumber;IssueDate;ReturnDate" });
                return loans;
            }

            var lines = File.ReadAllLines(filePath);
            for (int i = 1; i < lines.Length; i++)
            {
                var values = lines[i].Split(';');
                if (values.Length >= 4)
                {
                    var loan = new BookLoan
                    {
                        Id = int.TryParse(values[0], out int id) ? id : 0,
                        BookTitle = values[1],
                        ReaderCardNumber = values[2],
                        IssueDate = DateTime.TryParse(values[3], out DateTime issueDate) ? issueDate : DateTime.Now
                    };

                    if (values.Length > 4 && DateTime.TryParse(values[4], out DateTime returnDate))
                    {
                        loan.ReturnDate = returnDate;
                    }

                    loans.Add(loan);
                }
            }
            return loans;
        }

        public void SaveBookLoans(string filePath, List<BookLoan> loans)
        {
            var lines = new List<string> { "Id;BookTitle;ReaderCardNumber;IssueDate;ReturnDate" };
            foreach (var loan in loans)
            {
                string returnDate = loan.ReturnDate?.ToString("yyyy-MM-dd") ?? string.Empty;
                lines.Add($"{loan.Id};{loan.BookTitle};{loan.ReaderCardNumber};{loan.IssueDate:yyyy-MM-dd};{returnDate}");
            }
            File.WriteAllLines(filePath, lines);
        }
    }
}