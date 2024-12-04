using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_27
{
    class Program
    {
        static void Main(string[] args)
        {
            double szam;
            string szoveg;

            szoveg = Console.ReadLine();
            bool siker = double.TryParse(szoveg, out szam);
            Console.WriteLine(siker);
            Console.WriteLine(szam);

            int szam2 = 10;
            string szoveg2 = Convert.ToString(szam2);
            Console.WriteLine(szoveg2);

            string taj;
            int i;
            int j;
            int sum = 0;
            taj = "673457015";

            for (i = 0; 1<=7;i++)
            {
                if (i + 1 % 2 == 1)
                {
                    sum = sum + (Convert.ToInt32(taj[i]) * 3);
                }
                else
                {
                    sum = sum + (Convert.ToInt32(taj[i]) * 7);

                }
            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
