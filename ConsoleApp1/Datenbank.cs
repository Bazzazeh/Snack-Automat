using System.Collections.Generic;

namespace SnackAutomat
{
    internal class Datenbank
    {
        public static Dictionary<int, Snack> snacks = new Dictionary<int, Snack>()
        {
            {
                1,new Drink(true, 2.50, "CocaCola")
            },
            {
                2,new Drink(false, 2.50, "Redbull")
            },
            {
                3,new Pikant(true,2.00 , "Chips")
            },
            {
                4,new Pikant(false, 2.00, "Pizza")
            },
            {
                5,new Sweet(true, 2.00, "Cake")
            }
        };
    }
}
