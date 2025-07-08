using FawryChallenge2.Models;

namespace FawryChallenge2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Inventory inventory = new();

            List<Book> books = [
                new PaperBook("1", "C# Fundamentals", 2018, 29.99, "Abdallah", 10),
                new EBook("2", "Mastering .NET", 2020, 19.99, "Omar", "PDF"),
                new ShowcaseBook("3", "Java Basics", 2018, 0.0, "Historical Author")
            ];


            foreach (Book book in books)
                inventory.AddBook(book);

            Console.WriteLine('\n');
            try
            {
                inventory.BuyBook("1", 3, "", "123 Street, Cairo");
                inventory.BuyBook("2", 1, "user@example.com", "");
                inventory.BuyBook("3", 1, "", "");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.Message}\n");
            }
            inventory.RemoveOutdatedBooks(10);
        }
    }
}
