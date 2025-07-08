namespace FawryChallenge2.Models;

public abstract class Book(string isbn, string title, int publishYear, double price, string author)
{
    public string ISBN { get; set; } = isbn;
    public string Title { get; set; } = title;
    public int PublishYear { get; set; } = publishYear;
    public double Price { get; set; } = price;
    public string Author { get; set; } = author;

    public abstract void Buy(int quantity, string email, string address);
}