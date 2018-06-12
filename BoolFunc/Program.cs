using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoolFunc;

namespace BoolFunc
{
    class Program
    {
        static void Main(string[] args)
        {
            BooleanFunc b1 = new BooleanFunc(3, new int[] { 0,1,0,0,1,1,0,0});
            BooleanFunc b2 = (BooleanFunc)b1.Clone();
            Console.WriteLine($"b1 equals b2?: {b1.Equals(b2)}");
            Console.WriteLine($"b1 is identically false?: {b1.IdenticallyFalse()}");
            Console.WriteLine($"b1 number: {b1.GetNumber()}");
        }
    }
}
