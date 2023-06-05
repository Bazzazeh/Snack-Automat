using System;
using System.Collections.Generic;

namespace SnackAutomat
{
    internal class Order
    {
        public List<Snack> snacks = new List<Snack>();
        public List<Drink> drinks = new List<Drink>();
        public int maxItems = 3; 

        public void AddSnack(Snack snack)                       // To add snack
        {
            if ((snacks.Count + drinks.Count) < maxItems) 
            {
                snacks.Add(snack);
            }
            else { Console.WriteLine("Sie haben schon 3 Produkt bestellt"); }
        }

        public void AddDrink(Drink drink)                       // To add drink
        {
            if ((snacks.Count + drinks.Count) <= maxItems)
            {
                drinks.Add(drink);
            }
            else { Console.WriteLine("Sie haben schon 3 Produkt bestellt"); }
        }

        public double GetSnackPrice()                       // snack price 
        {
            double price = 0;
            foreach (Snack snack in snacks)
            {
                price += snack.Price;
            }
            return price;
        }
        public double CalculateDrinkExtra()             // To calculate Extra choice for drink
        {
            double cost = 0;

            foreach (Drink drink in drinks)
            {
                cost += drink.Price;
                if(drink.Big == true)
                {
                    cost += 0.50;
                    
                }
                
                if (drink.Sugar == true)
                {
                    cost += 1.00;
                }
                if(drink.Carbohydrate == true)
                {
                    cost += 1.00;
                }
            }
           
            return cost;
        }
        public double CalculateTotalPreis()                     // calculate the total price from snack and drink
        {
            double total = CalculateDrinkExtra() + GetSnackPrice();
            return total;
        }
        

        public void DisplayAllSnacks()                      // print the order in the end
        {
            foreach (Snack snack in snacks)
            {
                snack.Display();
                Console.WriteLine("\n----------");
            }
            foreach(Drink drink in drinks) { drink.Display(); Console.WriteLine("\n----------"); }
        }
        
    }
}
        