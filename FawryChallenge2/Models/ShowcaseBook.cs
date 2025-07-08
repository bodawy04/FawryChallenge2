namespace FawryChallenge2.Models;
public class ShowcaseBook(string isbn, string title, int year, double price, string author) 
    : Book(isbn, title, year, price, author)
{
    public override void Buy(int quantity, string email, string address) 
        => throw new Exception("Showcase books are not for sale.\n");
}

