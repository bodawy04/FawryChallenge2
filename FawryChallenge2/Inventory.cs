using FawryChallenge2.Models;

namespace FawryChallenge2;

public class Inventory
{
    private Dictionary<string, Book> _books = [];

    public void AddBook(Book book)
    {
        _books[book.ISBN] = book;
        Console.WriteLine($"Book '{book.Title}' added to inventory.");
    }

    public void RemoveOutdatedBooks(int maxYears)
    {
        int currentYear = DateTime.Now.Year;
        IEnumerable<Book> toRemove = _books.Values.Where(b => (currentYear - b.PublishYear) > maxYears).ToList();

        foreach (var book in toRemove)
        {
            _books.Remove(book.ISBN);
            Console.WriteLine($"Removed outdated book '{book.Title}'.");
        }

        if(!toRemove.Any())
            Console.WriteLine("No Outdated Books");
    }

    public void BuyBook(string isbn, int quantity, string email, string address)
    {
        if (!_books.ContainsKey(isbn))
            throw new Exception("Book not found.");

        Book book = _books[isbn];
        book.Buy(quantity, email, address);
    }
}