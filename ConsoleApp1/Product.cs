using System.Collections.Generic;

namespace SnackAutomat
{
    internal class Product              //Products
    {

        public static Dictionary<int, Drink> drinks = new Dictionary<int, Drink>()
        {
            {
                1,new Drink(true, 2.00, "CocaCola",false,false)
            },
            {
                2,new Drink(false, 2.50, "Redbull", false, false)
            },
            {
                3,new Drink(true, 2.00, "Fanta", false, false)
            },
            {
                4,new Drink(true, 2.00, "Sprite", false, false)
            }   };

        public static Dictionary<int, Snack> snacks = new Dictionary<int, Snack>()
            {
            {
                5,new Sweet(true, 2.00, "Cake")
            },
            {
                6,new Pikant(true, 2.00, "Chips")
            },
            {
                7,new Pikant(true, 2.00, "Pizza")
            }
        };




    }
}
