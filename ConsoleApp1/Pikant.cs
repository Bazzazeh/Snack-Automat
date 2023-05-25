using System;

namespace SnackAutomat
{
    class Pikant : Snack
    {
        public bool WithSpicy { get; set; }

        public Pikant(bool withSpicy, double price, string name) : base("Pikant",name , price)
        {
            WithSpicy = withSpicy;
        }
        public override void Display()
        {
            base.Display();
            if (WithSpicy)
            {
                Console.WriteLine("Mit Scharf.");
            }
        }
    }
}
