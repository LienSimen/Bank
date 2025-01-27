using System;
using Bank.Models;
using Bank.View;

namespace Bank.Controller;

/* Denne controlleren styrer hvordan vår app skal interacte med vår kortmodell. */
public class CardController (CardItems card, RenderCards view)
{
    private readonly RenderCards _view = view;
    private readonly List<string> _card = card.GetCards();

    public void GetAllCards()
    {
        _view.DisplayCards(_card);
    }

    public void IsCardAvailable()
    {
        Console.Write("Enter the card name to check availability: ");
        var input = Console.ReadLine();
        _view.DisplayAvailability(input, _card.Contains(input));
    }
}
