using FawryChallenge2.Services;

namespace FawryChallenge2.Models;

public class PaperBook(string isbn, string title, int year, double price, string author, int stock) 
    :Book(isbn, title, year, price, author)
{
    public int Stock { get; set; } = stock;

    public override void Buy(int quantity, string email, string address)
    {
        if (Stock < quantity)
            throw new Exception("Not enough stock available.");

        Stock -= quantity;
        Console.WriteLine($"Book '{Title}' purchased. Amount paid: ${Price * quantity}. Quantity: {quantity}");
        ShippingService.Send(address);
    }
}