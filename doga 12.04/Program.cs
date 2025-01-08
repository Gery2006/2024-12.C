using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doga_12._04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kérem az évet: ");

            string ev = Console.ReadLine();
            int szam;
            bool szam1 = int.TryParse(ev, out szam);

            if (szam1)
            {
                Console.WriteLine($"{ev} egy szám.");
            }
            else
            {
                Console.WriteLine($"{ev} nem egy szám.");
            }

            Console.WriteLine("Kérem a halál évszámát: ");

            int szam2;
            if (szam2)
            {
                Console.WriteLine($"{ev} egy szám.");
            }
            else
            {
                Console.WriteLine($"{ev} nem egy szám.");
            }
            int halal = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Add meg a nevet: ");
            string nev = Convert.ToString(Console.ReadLine());
            ev = 0;
            szam1 = int.TryParse(ev, out szam);
            if (szam1)
            {
                int idos = halal - ev;
                Console.WriteLine($"Ennyi idősen halt meg: {nev}: {idos}");
            }
            

            Console.WriteLine("Kérem az országot: ");
            string orszag=Convert.ToString(Console.ReadLine());
            Console.ReadKey();

            
        }
    }
}


  