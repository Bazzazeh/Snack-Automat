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
        public static void ProductChoice(Order order)               // To choice a product
        {
            int maxOrder = 3;
            while (true)
            {
                Console.WriteLine("Wählen Sie ein Produkt aus(Maximal 3 Stk):\n(1)- CocaCola ----Klein 2,00----Groß 2,50\n(2)- Redbull ----Klein 2,50----Groß 3,00\n(3)- Fanta ----Klein 2,00----Groß 2,50\n(4)- Sprite ----Klein 2,00----Groß 2,50\n(5)- Cake ----2,00 (Mit Schokolade)\n(6)- Chips ----2,00\n(7)- Pizza ----2,00 (Mit Scharf)\n(0)- Abbrechen");
                int selectedProduct = Convert.ToInt32(Console.ReadLine());
                switch (selectedProduct)
                {
                    case 0:
                        Environment.Exit(0); break;
                    case 1:
                    case 2:
                    case 3:
                    case 4:
                        Drink drink = Product.drinks[selectedProduct];
                        order.AddDrink(drink);
                        Console.Clear();

                        while (true)
                        {
                            Console.WriteLine("Größe auswählen:\n(1) - Groß ---- Preis +0,50\n(2) - Klein");
                            int bigChoice = Convert.ToInt32(Console.ReadLine());

                            if (bigChoice == 1)
                            {
                                drink.Big = true;
                                break;
                            }
                            else if (bigChoice == 2)
                            {
                                drink.Big = false;
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Ungültige Eingabe. Bitte wiederholen.");
                            }
                        }

                        while (true)
                        {
                            Console.WriteLine("Möchten Sie Zucker oder Kohlensäure hinzufügen:\n(1) - Zucker----für 1,00\n(2) - Kohlensäure---- für 1,00\n(3) - Beides---- für 2,00\n(0) - Keine Zusätze");
                            int extraChoice = int.Parse(Console.ReadLine());

                            if (extraChoice == 1)
                            {
                                drink.Sugar = true;
                                break;
                            }
                            else if (extraChoice == 2)
                            {
                                drink.Carbohydrate = true;
                                break;
                            }
                            else if (extraChoice == 3)
                            {
                                drink.Carbohydrate = true;
                                drink.Sugar = true;
                                break;
                            }
                            else if (extraChoice == 0)
                            {
                                break;
                            }
                            else { Console.WriteLine("Ungültige Eingabe. Bitte wierderholen."); continue; }
                        }

                        Console.Clear();
                        break;
                    case 5:
                    case 6:
                    case 7:
                        Snack snack = Product.snacks[selectedProduct];
                        order.AddSnack(snack);
                        Console.Clear();
                        break;
                        
                }
                Console.WriteLine("Möchten Sie noch was kaufen?\n(1)- Ja\n(2)- Nein");
                int moreOrder = Convert.ToInt32(Console.ReadLine());
                if (moreOrder == 1)
                {
                    if ((order.snacks.Count + order.drinks.Count) >= maxOrder)
                    {
                        Console.Clear();
                        Console.WriteLine("Sie dürfen nur max 3 Bestellungen kaufen.");
                        break;
                    }
                    continue;
                }
                else if (moreOrder == 2) { Console.Clear(); break; }
                else { Console.WriteLine("Falsche Eingabe"); continue; }
            }
            
        }
    }
}
        