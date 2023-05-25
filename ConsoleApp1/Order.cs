using System.Collections.Generic;

namespace SnackAutomat
{
    internal class Order
    {
        public List<Snack> snacks = new List<Snack>();

        public void AddSnack(Snack snack)
        {

            if (snacks.Count <= 5)
            {
                snacks.Add(snack);
            }
        }
        public double GetPrice()
        {
            double price = 0;
            foreach (Snack snack in snacks)
            {
                price += snack.Price;
            }
            return price;
        }
        public void DisplayAllSnacks()
        {
            foreach (Snack snack in snacks)
            {
                snack.Display();
            }
        }
    }
}
