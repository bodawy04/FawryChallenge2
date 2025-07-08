namespace FawryChallenge2.Services;
public static class ShippingService
{
    public static void Send(string address) 
        => Console.WriteLine($"Book is being shipped to {address}.\n");
}