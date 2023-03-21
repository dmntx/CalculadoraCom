using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraCom
{
    class Program
    {
        static void Main(string[] args)
        {
            Component tree = new Composite('+',new Composite('-',new Leaf(10),new Leaf(5)));
            double result = tree.operate();
            Console.WriteLine(result);
        }
    }
}
