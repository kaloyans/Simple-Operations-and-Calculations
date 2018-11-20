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

            int days = int.Parse(Console.ReadLine());
            int pastyCook = int.Parse(Console.ReadLine());
            int cake = int.Parse(Console.ReadLine());
            int waffle = int.Parse(Console.ReadLine());
            int pancake = int.Parse(Console.ReadLine());

            double cakePrise = cake * 45;
            double wafflePrise = waffle * 5.80;
            double pancakePrise = pancake * 3.20;
            double productPrice = (cakePrise + wafflePrise + pancakePrise) * pastyCook;

            double fullPrice = (productPrice * days);
            double lastPrice = fullPrice * 0.875;


            Console.WriteLine("{0:f2}", lastPrice);

        }
    
    }
}
