using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kockak
{
    class Program
    {
        static void Main(string[] args)
        {
   
            NegyszogClass negyszog1 = new NegyszogClass();
            Console.WriteLine($"Terület: {negyszog1.GetTerulet()}, Kerület: {negyszog1.GetKerulet()}");


            NegyszogClass negyszog2 = new NegyszogClass(4);
            Console.WriteLine($"Terület: {negyszog2.GetTerulet()}, Kerület: {negyszog2.GetKerulet()}");

            NegyszogClass negyszog3 = new NegyszogClass(4, 5);
            Console.WriteLine($"Terület: {negyszog3.GetTerulet()}, Kerület: {negyszog3.GetKerulet()}");


            negyszog1.SetOldal1(6);
            Console.WriteLine($"Terület: {negyszog1.GetTerulet()}, Kerület: {negyszog1.GetKerulet()}");


            negyszog1.SetOldal2(6, 7);
            Console.WriteLine($"Terület: {negyszog1.GetTerulet()}, Kerület: {negyszog1.GetKerulet()}");

            Console.ReadKey();
        }
    }
}