using System;

namespace Bank.Models;


public class CardItems
{
    public List<string> GetCards()
    {
        return ["Master Card", "Debit Card", "Prepaid Card", "Credit Card", "Travel Card"];
    }

}