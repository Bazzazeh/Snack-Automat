
using System;

namespace SnackAutomat
{
    internal class MainMenue
    {
        public static void Menu()
        {
            Order order = new Order();
            Order.ProductChoice(order);
            Payment.Pay(order);
        }
    }
}

