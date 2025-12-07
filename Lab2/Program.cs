using System;

struct Prices
{
    public int Drink;
    public int First;
    public int Second;
}

struct Choices
{
    public int DrinkQty;
    public int FirstQty;
    public int SecondQty;
}

class Program
{
    static int CustomerTotal(Prices prices, Choices choices)
    {
        return prices.Drink * choices.DrinkQty
             + prices.First * choices.FirstQty
             + prices.Second * choices.SecondQty;
    }

    static void Main()
    {
        Prices prices = new Prices { Drink = 10, First = 20, Second = 30 };

        Choices client1 = new Choices { DrinkQty = 100, FirstQty = 0, SecondQty = 250 };
        int total1 = CustomerTotal(prices, client1);
        Console.WriteLine("Client 1 total: " + total1);

        Choices client2 = new Choices { DrinkQty = 0, FirstQty = 300, SecondQty = 0 };
        int total2 = CustomerTotal(prices, client2);
        Console.WriteLine("Client 2 total: " + total2);
    }
}
