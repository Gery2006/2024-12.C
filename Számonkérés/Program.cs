using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Számonkérés
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Add meg a diák nevét: ");
            string diakNev = Console.ReadLine();


            Console.Write("Add meg az első dolgozat pontszámát (0-100): ");
            double dolgozat1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Add meg a második dolgozat pontszámát (0-100): ");
            double dolgozat2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Add meg a harmadik dolgozat pontszámát (0-100): ");
            double dolgozat3 = Convert.ToDouble(Console.ReadLine());


            double atlag = (dolgozat1 + dolgozat2 + dolgozat3) / 3;


            string erdemjegy = "";
                    
            if (atlag >= 90)
            {
                erdemjegy = "Jeles";
            }
            else if (atlag >= 80)
            {
                erdemjegy = "Jó";
            }
            else if (atlag >= 70)
            {
                erdemjegy = "Közepes";
            }
            else if (atlag >= 60)
            {
                erdemjegy = "Elégséges";
            }
            else
            {
                erdemjegy = "Elégtelen";
            }


            Console.WriteLine("\nDiák neve: " + diakNev);
            Console.WriteLine("Átlag: " + atlag);
            Console.WriteLine("Érdemjegy: " + erdemjegy);
            Console.ReadKey();
        }
    }
}
