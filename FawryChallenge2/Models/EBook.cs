using FawryChallenge2.Services;

namespace FawryChallenge2.Models;
public class EBook(string isbn, string title, int year, double price, string author, string fileType)
    : Book(isbn, title, year, price, author)
{
    public string FileType { get; set; } = fileType;

    public override void Buy(int quantity, string email, string address)
    {
        if (quantity > 1)
            throw new Exception("Only one EBook can be bought at a time.");

        Console.WriteLine($"EBook '{Title}' purchased. Amount paid: ${Price}");
        MailService.Send(email);
    }
}