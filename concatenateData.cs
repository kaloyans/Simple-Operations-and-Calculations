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
            //Console.WriteLine("Enter firstname:");
            string firstName = Console.ReadLine();
           // Console.WriteLine("Enter lastname:");
            string lastName = Console.ReadLine();
            //Console.WriteLine("Enter age:");
            int age = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter town:");
            string town = Console.ReadLine();

            Console.WriteLine("You are {0} {1}, a {2}-years" +
                " old person from {3}.", firstName, lastName, age, town);

        }
    }
}
