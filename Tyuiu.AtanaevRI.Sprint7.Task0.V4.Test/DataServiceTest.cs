//using static Tyuiu.AtanaevRI.Sprint7.Task0.V4.Lib.DataService;

//[TestClass]
//public class DataServiceTests
//{
//    [TestMethod]
//    public void TestBookStatistics()
//    {
//        var service = new DataService();
//        var books = new List<Book>
//        {
//            new Book { Id = 1, Price = 100 },
//            new Book { Id = 2, Price = 200 },
//            new Book { Id = 3, Price = 300 }
//        };

//        var stats = service.GetBooksStatistics();
//        Assert.AreEqual(3, stats.count);
//        Assert.AreEqual(600, stats.total);
//        Assert.AreEqual(200, stats.avg);
//        Assert.AreEqual(100, stats.min);
//        Assert.AreEqual(300, stats.max);
//    }

//    [TestMethod]
//    public void TestSearchBooks()
//    {
//        var service = new DataService();
//        var books = new List<Book>
//        {
//            new Book { Id = 1, Author = "Толстой", Title = "Война и мир" },
//            new Book { Id = 2, Author = "Достоевский", Title = "Преступление и наказание" }
//        };

//        var result = service.SearchBooks("Толстой");
//        Assert.AreEqual(1, result.Count);
//        Assert.AreEqual("Война и мир", result[0].Title);
//    }
//}