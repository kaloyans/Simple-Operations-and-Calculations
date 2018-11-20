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
            int lenght = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());

            double volumeInCubicSantimeters = lenght * width * height;
            double volumeInLiters = volumeInCubicSantimeters / 1000;

            double noNeedPercents = percent * 0.01;
            double finalResult = volumeInLiters * (1 - noNeedPercents);

            Console.WriteLine($"{finalResult:F3}");
            
        }
    }
}
