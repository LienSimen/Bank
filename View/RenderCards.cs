namespace Bank.View;

public class RenderCards
{
    public void DisplayCards(List<string> cards)
    {
        Console.WriteLine("Available Cards:");
        cards.ForEach(card => Console.WriteLine($"- {card}"));
    }

    public void DisplayAvailability(string input, bool availability)
    {
        Console.WriteLine($"{input} available? {availability}");
    }
}