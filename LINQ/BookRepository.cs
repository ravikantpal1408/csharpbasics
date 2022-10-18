namespace LINQ;

public partial class BookRepository
{
    public IEnumerable<Book> GetBooks()
    {
        return new List<Book>
        {
            new Book() { Title = "ADO.Net Step by step", Price = 10 },
            new Book() { Title = "ASP.NET MVC", Price = 3.4f },
            new Book() { Title = "React Hyperloop", Price = 45 },
            new Book() { Title = "C# Advanced", Price = 6.34f },
            new Book() { Title = "GIT FOR EVERY DEV", Price = 99.55 },
        };
    }
}