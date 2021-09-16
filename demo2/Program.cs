using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo2
{
    struct order
    {
        public string itemName;
        public int unitCount;
        public double unitCost;
        public double TotalCost() => unitCount * unitCost;
        public string Info() => "Order information: " + unitCount.ToString() +
        " " + itemName + " items at $" + unitCost.ToString() +
        " each, total cost $" + TotalCost().ToString();
    }
    class Program
    {
        static void Main(string[] args)
        {
            order o;
            o.itemName = "lala";
            o.unitCount = 5;
            o.unitCost = 5.0;
            o.Info();

        }
    }
}
