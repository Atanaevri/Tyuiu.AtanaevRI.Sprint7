using Tyuiu.AtanaevRI.Sprint7.Task0.V4.Lib.Models;
using Tyuiu.AtanaevRI.Sprint7.Task0.V4.Lib.Services;

namespace Tyuiu.AtanaevRI.Sprint7.Task0.V4.Lib
{
    public class DataService
    {
        private List<Book> _books = new List<Book>();
        private List<Reader> _readers = new List<Reader>();
        private List<BookLoan> _bookLoans = new List<BookLoan>();
        private readonly FileService _fileService = new FileService();

        public DataService()
        {
        }

        // Загрузка данных из файлов
        public void LoadData(string booksPath, string readersPath, string loansPath)
        {
            _books = _fileService.LoadBooks(booksPath);
            _readers = _fileService.LoadReaders(readersPath);
            _bookLoans = _fileService.LoadBookLoans(loansPath);
        }

        // Сохранение данных в файлы
        public void SaveData(string booksPath, string readersPath, string loansPath)
        {
            _fileService.SaveBooks(booksPath, _books);
            _fileService.SaveReaders(readersPath, _readers);
            _fileService.SaveBookLoans(loansPath, _bookLoans);
        }

        // --- Работа с книгами ---
        public void AddBook(Book book)
        {
            if (book.Id == 0)
            {
                book.Id = _books.Count > 0 ? _books.Max(b => b.Id) + 1 : 1;
            }
            _books.Add(book);
        }

        public void UpdateBook(Book book)
        {
            var existingBook = _books.FirstOrDefault(b => b.Id == book.Id);
            if (existingBook != null)
            {
                _books.Remove(existingBook);
                _books.Add(book);
            }
        }

        public void DeleteBook(int id)
        {
            var book = _books.FirstOrDefault(b => b.Id == id);
            if (book != null)
            {
                _books.Remove(book);
            }
        }

        public List<Book> GetBooks() => _books;

        public Book? GetBookById(int id) => _books.FirstOrDefault(b => b.Id == id);

        // --- Работа с читателями ---
        public void AddReader(Reader reader) => _readers.Add(reader);

        public void UpdateReader(Reader reader)
        {
            var existingReader = _readers.FirstOrDefault(r => r.CardNumber == reader.CardNumber);
            if (existingReader != null)
            {
                _readers.Remove(existingReader);
                _readers.Add(reader);
            }
        }

        public void DeleteReader(string cardNumber)
        {
            var reader = _readers.FirstOrDefault(r => r.CardNumber == cardNumber);
            if (reader != null)
            {
                _readers.Remove(reader);
            }
        }

        public List<Reader> GetReaders() => _readers;

        public Reader? GetReaderByCard(string cardNumber) =>
            _readers.FirstOrDefault(r => r.CardNumber == cardNumber);

        // --- Работа с выдачами книг ---
        public void AddBookLoan(BookLoan loan)
        {
            if (loan.Id == 0)
            {
                loan.Id = _bookLoans.Count > 0 ? _bookLoans.Max(l => l.Id) + 1 : 1;
            }
            _bookLoans.Add(loan);
        }

        public void ReturnBook(int loanId)
        {
            var loan = _bookLoans.FirstOrDefault(l => l.Id == loanId);
            if (loan != null)
            {
                loan.ReturnDate = DateTime.Now;
            }
        }

        public List<BookLoan> GetBookLoans() => _bookLoans;

        public List<BookLoan> GetActiveLoans() =>
            _bookLoans.Where(l => l.ReturnDate == null).ToList();

        // --- Поиск ---
        public List<Book> SearchBooks(string keyword)
        {
            if (string.IsNullOrWhiteSpace(keyword))
                return _books;

            keyword = keyword.ToLower();
            return _books.Where(b =>
                b.Author.ToLower().Contains(keyword) ||
                b.Title.ToLower().Contains(keyword) ||
                b.Annotation.ToLower().Contains(keyword)).ToList();
        }

        public List<Reader> SearchReaders(string keyword)
        {
            if (string.IsNullOrWhiteSpace(keyword))
                return _readers;

            keyword = keyword.ToLower();
            return _readers.Where(r =>
                r.FullName.ToLower().Contains(keyword) ||
                r.CardNumber.ToLower().Contains(keyword) ||
                r.Address.ToLower().Contains(keyword) ||
                r.Phone.Contains(keyword)).ToList();
        }

        // --- Сортировка ---
        public List<Book> SortBooksByTitle(bool ascending = true)
        {
            return ascending ?
                _books.OrderBy(b => b.Title).ToList() :
                _books.OrderByDescending(b => b.Title).ToList();
        }

        public List<Book> SortBooksByYear(bool ascending = true)
        {
            return ascending ?
                _books.OrderBy(b => b.Year).ToList() :
                _books.OrderByDescending(b => b.Year).ToList();
        }

        public List<Book> SortBooksByPrice(bool ascending = true)
        {
            return ascending ?
                _books.OrderBy(b => b.Price).ToList() :
                _books.OrderByDescending(b => b.Price).ToList();
        }

        // --- Фильтрация ---
        public List<Book> FilterBooksByAuthor(string author)
        {
            return _books.Where(b => b.Author.Equals(author, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        public List<Book> FilterNewEditions(bool isNewEdition = true)
        {
            return _books.Where(b => b.IsNewEdition == isNewEdition).ToList();
        }

        public List<Book> FilterBooksByYearRange(int minYear, int maxYear)
        {
            return _books.Where(b => b.Year >= minYear && b.Year <= maxYear).ToList();
        }

        // --- Статистика ---
        public (int Count, decimal TotalPrice, decimal AveragePrice, decimal MinPrice, decimal MaxPrice)
            GetBooksStatistics()
        {
            if (_books.Count == 0)
                return (0, 0, 0, 0, 0);

            var prices = _books.Select(b => b.Price).ToList();
            return (
                _books.Count,
                prices.Sum(),
                prices.Average(),
                prices.Min(),
                prices.Max()
            );
        }

        public int GetBooksCount() => _books.Count;

        public int GetReadersCount() => _readers.Count;

        public int GetActiveLoansCount() => GetActiveLoans().Count;

        public int GetBooksByYear(int year) =>
            _books.Count(b => b.Year == year);

        public int GetBooksByAuthor(string author) =>
            _books.Count(b => b.Author.Equals(author, StringComparison.OrdinalIgnoreCase));

        // --- Графики ---
        public Dictionary<string, int> GetBooksCountByAuthor()
        {
            return _books
                .GroupBy(b => b.Author)
                .ToDictionary(g => g.Key, g => g.Count());
        }

        public Dictionary<int, int> GetBooksCountByYear()
        {
            return _books
                .GroupBy(b => b.Year)
                .ToDictionary(g => g.Key, g => g.Count())
                .OrderBy(x => x.Key)
                .ToDictionary(x => x.Key, x => x.Value);
        }

        public Dictionary<string, int> GetLoansByMonth(int year)
        {
            return _bookLoans
                .Where(l => l.IssueDate.Year == year)
                .GroupBy(l => l.IssueDate.ToString("yyyy-MM"))
                .OrderBy(g => g.Key)
                .ToDictionary(g => g.Key, g => g.Count());
        }
    }
}