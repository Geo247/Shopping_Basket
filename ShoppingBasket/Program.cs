using System;

namespace ShoppingBasket
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome!");
            Console.WriteLine();
            Console.WriteLine("Items available");
            Console.WriteLine("=========================");
            Basket.ReturnAvailableFood();
            Console.WriteLine("=========================");
            Console.WriteLine();
            Console.WriteLine("=========================");
            Basket.GetOffers();
            Console.WriteLine("=========================");
            Console.WriteLine();

            Basket basket = new Basket();
            basket.AddFood();
            basket.CalculateSubTotal();
            basket.GetDiscount();
            basket.CalculateTotal();
            Console.ReadKey();
        }
    }
}
