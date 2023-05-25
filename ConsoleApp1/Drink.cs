using System;

namespace SnackAutomat
{
    class Drink : Snack
    {
        public bool Big { get; set; }

        public Drink(bool big, double price, string name) : base("Drink", name, price)
        {
            Big = big;
        }

        public override void Display()
        {
            base.Display();
            if (Big)
            {
                Console.WriteLine("Groß");
            }
        }
    }
}
