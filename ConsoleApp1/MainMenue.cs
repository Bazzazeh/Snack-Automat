
using System;

namespace SnackAutomat
{
    internal class MainMenue
    {
        public static void Menu()
        {
            Order order = new Order();
            ChoiceProduct(order);
            while (true)
            {
                if (order.snacks.Count <= 5)
                {
                    Console.WriteLine("Möchten Sie noch andere Produkte auswählen:\n(1)- Ja\n(2)- Nein");
                    int choice = int.Parse(Console.ReadLine());
                    if (choice == 1)
                    {
                        ChoiceProduct(order);

                    }
                    else { break; }
                }
            }

            double total = order.GetPrice();
            Console.WriteLine($"ihre gesamte betrag: {total}");
            double allreadyPay = 0;

            while (true)
            {
                Console.WriteLine("Bitte Geld einzahlen:");
                string inputMoney = Console.ReadLine();
                double money;

                if (!double.TryParse(inputMoney, out money) || money < 0 || money > 10)
                {
                    Console.WriteLine("Falsche eingabe");
                    continue;
                }
                if (money != 0.05 && money != 0.10 && money != 0.20 && money != 0.50 && money != 1 && money != 2 && money != 5 && money != 10)
                {
                    Console.WriteLine("nur: 5, 10, 20, 50 Cent und 1, 2, 5, 10");
                    continue;
                }

                allreadyPay += money;
                double result = total - allreadyPay;

                if (allreadyPay == total)
                {
                    Console.WriteLine("Dankeschön");
                    break;

                }
                else if (allreadyPay > total)
                {
                    Console.WriteLine($"Sie erhalten {allreadyPay - total}");
                    break;
                }

                else if (result != total)
                {
                    Console.WriteLine($"noch {result} verbleibend, bitte noch einzahlen");
                    continue;
                }
            }
            order.DisplayAllSnacks();
            Console.Read();
        }

        private static void ChoiceProduct(Order order)
        {
            Console.WriteLine("Wählen Sie ein Produkt aus(Maximal 5 Stk):\n(1)- CocaCola\n(2)- Redbull\n(3)- Chips\n(4)- Pizza\n(5)- Cake\n(0)- Abbrechen");
            int selectedProduct = int.Parse(Console.ReadLine());
            Snack snack1 = Datenbank.snacks[selectedProduct];
            order.AddSnack(snack1);
        }
    }
}
