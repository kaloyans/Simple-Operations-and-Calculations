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

            double wiskeyPricePerLiter = double.Parse(Console.ReadLine());
            double beer = double.Parse(Console.ReadLine());
            double wine = double.Parse(Console.ReadLine());
            double rakiya = double.Parse(Console.ReadLine());
            double wiskey = double.Parse(Console.ReadLine());

            double rakiyaPricePerLiter = wiskeyPricePerLiter * 0.5;
            double winePricePerLiter = rakiyaPricePerLiter - (rakiyaPricePerLiter * 0.4);
            double beerPricePerLiter = rakiyaPricePerLiter - (rakiyaPricePerLiter * 0.8);

            double rakiyaAmount = rakiya * rakiyaPricePerLiter;
            double wineAmount = wine * winePricePerLiter;
            double beerAmount = beer * beerPricePerLiter;
            double wiskeyAmount = wiskey * wiskeyPricePerLiter;

            double money = rakiyaAmount + wineAmount + beerAmount + wiskeyAmount;


            Console.WriteLine("{0:f2}", money);

        }
    
    }
}
