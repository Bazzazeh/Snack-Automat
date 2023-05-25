using System;

namespace SnackAutomat
{
    class Sweet : Snack
    {
        public bool WithChoclate { get; set; }

        public Sweet(bool withChoclate, double price, string name) : base("Sweet", name, price)
        {
            WithChoclate = withChoclate;
        }
        public override void Display()
        {
            base.Display();
            if (WithChoclate)
            {
                Console.WriteLine("Mit Schokolade.");
            }
        }
    }
}
