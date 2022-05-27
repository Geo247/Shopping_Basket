using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingBasket
{
    class Basket
    {
        int beansAmount = 0;
        int breadAmount = 0;
        int milkAmount = 0;
        int orangeAmount = 0;

        decimal beansPrice = 0.98m;
        decimal breadPrice = 0.84m;
        decimal milkPrice = 1.50m;
        decimal orangePrice = 1.90m;

        decimal beansSubTotal = 0m;
        decimal breadSubTotal = 0m;
        decimal milkSubTotal = 0m;
        decimal orangeSubTotal = 0m;
        decimal subTotal = 0m;


        public static void ReturnAvailableFood()
        {
            List<string> availableFood = new List<string>();
            availableFood.Add("Beans - 98p");
            availableFood.Add("Bread - 84p");
            availableFood.Add("Milk - £1.50");
            availableFood.Add("Oranges - £1.90");
            foreach(string food in availableFood)
            {
                Console.WriteLine(food);
            }
        }
        public void AddFood()
        {
            Console.WriteLine("Please enter the valid items you would like to purchase | Please leave a space between each item:");
            string item = Console.ReadLine();
            item = item.ToLower();
            string[] items = item.Split(" ");


            for (int i = 0; i < items.Length; i++)
            {
                if (items[i].Contains("beans"))
                {
                    beansAmount++;
                }
                else if (items[i].Contains("bread"))
                {
                    breadAmount++;
                }
                else if (items[i].Contains("milk"))
                {
                    milkAmount++;
                }
                else if (items[i].Contains("orange"))
                {
                    orangeAmount++;
                }
                else
                {
                    Console.WriteLine($"\n| {items[i]} Is not a valid item | ");
                }
            }
            Console.WriteLine($"\nYou ordered {beansAmount} cans of beans, {breadAmount} loafs of bread, {milkAmount} jugs of milk and {orangeAmount} oranges");
        }

        public static void GetOffers()
        {
            Console.WriteLine("Current savings are:");
            Console.WriteLine(" \x80 Oranges have a 20% discount this week");
            Console.WriteLine(" \x80 Multi-buy offer - buy 2 tins of beans and get half price on a loaf of bread");
        }

        public void CalculateSubTotal()
        {
            beansSubTotal = beansAmount * beansPrice;
            breadSubTotal = breadAmount * breadPrice;
            milkSubTotal = milkAmount * milkPrice;
            orangeSubTotal = orangeAmount * orangePrice;
            subTotal = beansSubTotal + breadSubTotal + milkSubTotal + orangeSubTotal;
            Console.WriteLine($"\nYour Subtotal Is: £{subTotal}p");
        }

        public void GetDiscount()
        {
            decimal orangeDiscounted = 0m;
            int discountAmount = 20;
            if(orangeAmount > 0)
            {
                orangeDiscounted = (orangeSubTotal / 100) * discountAmount;
                orangeDiscounted = Decimal.Round(orangeDiscounted, 2);
                subTotal = subTotal - orangeDiscounted;
                Console.WriteLine($"\nOranges {discountAmount}% off: -£{orangeDiscounted}p to your order");
            }
            if (beansAmount >= 2)
            {
                decimal breadOffer = breadPrice / 2;
                subTotal = subTotal - breadOffer;
                Console.WriteLine($"\nFor purchasing {beansAmount} tins of beans, a bread is 50% off: -£{breadOffer}p to your order");
            }
            if (orangeAmount == 0 && beansAmount < 2)
            {
                Console.WriteLine("\n(No offers avaialbe.)");
            }
        }

        public void CalculateTotal()
        {
            decimal fullTotal = subTotal;
            fullTotal = Decimal.Round(fullTotal, 2);
            Console.WriteLine($"\nTotal: £{fullTotal}p");
        }
    }
}
