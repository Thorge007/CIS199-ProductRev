//Grading ID: S0941

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductRev

{
    public class FuelOrder

    {
        // #1 - Put needed backing fields here
        // Remember: Some properties may be
        // auto-implemented, so only create
        // backing fields for ones needed
        private int _volume;
        private int _price;

        double Cost;

        public string Description
        { get; set; }

        public string OctaneRating
        { get; set; }
        

        public int Volume
        {
            get
            {
                return (int)(_volume * 1.1);
            }

            set
            {
                if (value >= 0)
                    _volume = value;
                else
                    _volume = 0;
            }
        }

        public double Price
        {
            get
            {
                return _price;
            }

            set
            {
                if (value >= 0)
                    _price = (int)value;
                else
                    _price = 0;
            }
        }

        public FuelOrder(string desc, string octaneRating, double volume, double price)
        {
            Description = desc;
            OctaneRating = octaneRating;
            Volume = Convert.ToInt32(volume);
            Price = price;

        }

        public double CalcFuelCost()
        {
            Cost = Price * Volume;
            return Cost;
        }

        public override string ToString()
        {
            // #8 - Put your code here to create formatted string
            // Use format that would produce a string like:
            // "Premium: 92 (25 @ $2.99)"
            // where 92 is the octane rating, Premium is the
            // description, 25 is the volume, and $2.99 is
            // the price. No newlines are needed.
            string objectString;

            objectString = $"{"Premium:  " + OctaneRating + "(" + Volume + "@" + "$" + Price +}";

            return objectString;

        }
    }
}
