using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_app
{
    class Program
    {
        static void Main(string[] args)
        {
            int price = 5;
            int quantity = 10;
            int cost = price * quantity;

            Console.WriteLine("You bought {0} at {1:C} costing {2:C} ", quantity, price, cost);
        }
    }
}
