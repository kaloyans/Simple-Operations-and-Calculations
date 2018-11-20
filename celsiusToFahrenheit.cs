using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseSyntaxDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            double Celsius = double.Parse(Console.ReadLine());
            double Farenhait = Celsius * 1.8 + 32;

            Console.WriteLine(Math.Round(Farenhait, 2));
        }
    }
}
