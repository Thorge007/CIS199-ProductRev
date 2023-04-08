//Grading ID: S0941

using System;
//Grading ID: S0941
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ProductRev
{
    class Program
    {
        static void Main(string[] args)
        {
            double currentValue;   // Current product's value
            double totalValue = 0; // Running total of product's value
            FuelOrder[] orders; // Product Items

            // #1 - Put code here to construct 3  Fuel orders
            FuelOrder order1
            FuelOrder order2
            FuelOrder order3

            orders = new FuelOrder[] { order1, order2, order3 };

            WriteLine($"Product Revenue Report:");

            // #2 - Complete loop to step through array of items
            for (int index = 0; index <= orders.Length-1; ++index)
            {

                currentValue = FuelOrder.CalcFuelCost();

                totalValue += currentValue;

                // #5 - Output currentValue, with currency formatting, followed by string representation
                //      of current item from array
            }

            WriteLine("\nTotal Gross Revenue:" + totalValue.ToString("C"));
            // #6 - Output totalValue of Gross Revenue, with currency formatting

        }
    }
}
