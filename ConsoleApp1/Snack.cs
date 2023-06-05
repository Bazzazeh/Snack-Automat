using System;

namespace SnackAutomat
{

    abstract class Snack
    {
        public string Type { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        protected Snack(string type, string name, double price)
        {
            Type = type;
            Name = name;
            Price = price;
        }

        public virtual void Display()
        {
            Console.WriteLine("Name----- {0}", Name);
            Console.WriteLine("Price----- {0}", Price);
        }
    }
}
