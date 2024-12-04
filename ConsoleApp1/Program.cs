using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teszteéscon
{
    class Program
    {
        static void Main(string[] args)
        {
            double szam;
            string szöveg;

            szöveg = Console.ReadLine();
            bool siker = double.TryParse(szöveg, out szam);
            Console.WriteLine(siker);
            Console.WriteLine(szam);

            int szam2 = 10;
            string szoveg2 = Convert.ToString(szam2);
            Console.WriteLine(szoveg2);
            Console.ReadKey();

            string taj;
            int szum = 0;
            int i, j;
            taj = "467764647";

            for (i = 0; i <= 7; i++)
            {
                if ((i + 1) % 2 == 1)
                {
                    j = int.Parse(taj[i].ToString());
                    szum = szum + (j * 3);
                }
                else
                {
                    j = int.Parse(taj[i].ToString());
                    szum = szum + (j * 7);

                }
            }
            Console.WriteLine(szum);
            int ellenorzes = szum % 10;
            if (ellenorzes == int.Parse(taj[0].ToString())) ;
            else
            {
                Console.WriteLine("Rossz taj");
            }
        }
    }
}