namespace Fauna;

public class Toyota : Car
{
    public Toyota()
    {
        Console.WriteLine("toyota is a japan car");
    }

    public void BuyToyota(string model)
    {
        Console.WriteLine($"Congratulations! You bought the brand new Toyota {model}");
    }
}