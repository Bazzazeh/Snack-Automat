using System;

namespace SnackAutomat
{
    class Drink : Snack
    {
        public bool Big { get; set; }
        public bool Sugar { get; set; }
        public bool Carbohydrate { get; set; }

        public Drink(bool big, double price, string name, bool sugar, bool carbohydrate) : base("Drink", name, price)
        {
            Big = big;
            Sugar = sugar;
            Carbohydrate = carbohydrate;
        }


        public override void Display()
        {

            Console.WriteLine("Name----- {0}", Name);
            double totalPrice = Price;

            if (Big)
            {
                Console.WriteLine("Groß");
                totalPrice += 0.50;
            }
            else
            {
                Console.WriteLine("Klein");
            }

            if (Sugar)
            {
                Console.WriteLine("Mit Extra Zucker");
                totalPrice += 1.00;
            }

            if (Carbohydrate)
            {
                Console.WriteLine("Mit Kohlensäure");
                totalPrice += 1.00;
            }
            Console.WriteLine("Price----- {0}", totalPrice);
        }
    }
}
