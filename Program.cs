using Bank.App;
using Bank.Controller;
using Bank.View;
using Bank.Models;

namespace Bank;

class Program
{
    static void Main(string[] args)
    {
        var customers = new Customers();
        var cards = new CardItems();

        var customerDisplayer = new RenderCustomers();
        var cardDisplayer = new RenderCards();

        var customerController = new CustomerController(customers, customerDisplayer);
        var cardController = new CardController(cards, cardDisplayer);

        var app = new BankApp(customerController, cardController);

        app.Run();
    }
}
