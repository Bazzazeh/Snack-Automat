using System;

namespace SnackAutomat
{
    internal class MainMenue
    {
        public static void Menu()
        {
            Order order = new Order();
            int maxOrder = 3;
            while (true)
            {                                                           // Menu
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
                        {                                                   // If big drink
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
                        {                                                   // If with sugar or carbohydrate
                            Console.WriteLine("Möchten Sie Zucker oder Kohlensäure hinzufügen:\n(1) - Zucker----für 1,00\n(2) - Kohlensäure---- für 1,00\n(3) - Beides---- für 2,00\n(0) - Keine Zusätze");
                            int extraChoice = Convert.ToInt32(Console.ReadLine());

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
                    default: Console.Clear(); Console.WriteLine("Falsche Eingabe"); continue;

                }
                Console.WriteLine("Möchten Sie noch was kaufen?\n(1)- Ja\n(2)- Nein");      // If more product
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
            Payment.Pay(order);
        }
    }
}
