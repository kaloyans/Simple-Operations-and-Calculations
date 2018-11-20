using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseSyntaxExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            uint table = uint.Parse(Console.ReadLine());
            double tableLenght = double.Parse(Console.ReadLine());
            double tableWidth = double.Parse(Console.ReadLine());

            double recArea = table * (tableLenght + 2 * 0.30) * (tableWidth + 2 * 0.30);
            double squareArea = table * (tableLenght / 2) * (tableLenght / 2);

            double priceUSD = recArea * 7 + squareArea * 9;
            double priceBGN = priceUSD * 1.85;

            Console.WriteLine("{0:f2} USD", priceUSD);
            Console.WriteLine("{0:f2} BGN", priceBGN);
        }
    
    }
}
