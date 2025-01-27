using System;
using Bank.Controller;

namespace Bank.App;

public class BankApp(CustomerController customerController, CardController cardController)
{
    /* Appen må ha en referanse til hver av controllerene den skal styre. */
    private readonly CustomerController _customerController = customerController;
    private readonly CardController _cardController = cardController;

    /* Den har et eget felt som ser om appen skal kjøre */
    private bool isRunning = true;

    /* Her er metoden som kjører vår app. */
    public void Run()
    {
        while (isRunning)
        {
            Console.WriteLine("Welcome to the bank");
            Console.WriteLine("What do you want to do?");
            Console.WriteLine("press 1 for registering a new customer");
            Console.WriteLine("press 2 for unregistering a new customer");
            Console.WriteLine("press 3 to display customers");
            Console.WriteLine("press 4 to display cards");
            Console.WriteLine("press 5 to check if card is available");
            Console.WriteLine("press 6 to exit.");

            /* Her tar appen imot brukerinput, og sier til kontrolleren vår hva som skal kjøres. */
            var input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    _customerController.AddCustomer();
                    break;
                case "2":
                    _customerController.RemoveCustomer();
                    break;
                case "3":
                    _customerController.DisplayCustomers();
                    break;
                case "4":
                    _cardController.GetAllCards();
                    break;
                case "5":
                    _cardController.IsCardAvailable();
                    break;
                case "6":
                    Console.WriteLine("Exiting...");
                    isRunning = false;
                    break;
                default:
                    Console.WriteLine("Not supported");
                    break;
            }
        }
    }

}
