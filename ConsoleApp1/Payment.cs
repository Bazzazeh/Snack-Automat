using System;

namespace SnackAutomat
{
    internal class Payment
    {
        public static void Pay(Order order)                 // To Pay
        {
            double total = order.CalculateTotalPreis();
            Console.WriteLine($"Ihre gesamte betrag: {total}");
            double allreadyPay = 0;

            while (true)                                    
            {
                Console.WriteLine("Bitte Geld einzahlen:");
                string inputMoney = Console.ReadLine();
                double money;

                if (!double.TryParse(inputMoney, out money) || money < 0 || money > 10)
                {
                    Console.WriteLine("Falsche eingabe, nur: 5, 10, 20, 50 Cent und 1, 2, 5, 10");
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
                    Console.WriteLine("Dankeschön\n");
                    break;

                }
                else if (allreadyPay > total)
                {
                    Console.Clear();
                    Console.WriteLine($"Sie erhalten {allreadyPay - total}\n");
                    break;
                }

                else if (result != total)
                {
                    Console.Clear();
                    Console.WriteLine($"noch {result} verbleibend, bitte noch einzahlen");
                    continue;
                }
            }
            Console.WriteLine("--------- Rechnung ---------\n");
            order.DisplayAllSnacks();
            Console.Read();
        }
    }
}
