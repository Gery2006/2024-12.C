using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doga03_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Add meg az adószámod: ");
            string adoszam = Convert.ToString(Console.ReadLine());

            if (adoszam.Length != 10) 
            {
                Console.WriteLine("Nem jó adószámot irtál be.");
            }

            try
            {
                bool success=int.TryParse(adoszam, out int result);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ne irj be betűt!");           
            }
            Console.ReadKey();


          
            int szam1 = Convert.ToInt32(Convert.ToString(adoszam[0]));
            int szam2 = Convert.ToInt32(Convert.ToString(adoszam[1]));
            int szam3 = Convert.ToInt32(Convert.ToString(adoszam[2]));
            int szam4 = Convert.ToInt32(Convert.ToString(adoszam[3]));
            int szam5 = Convert.ToInt32(Convert.ToString(adoszam[4]));
            int szam6 = Convert.ToInt32(Convert.ToString(adoszam[5]));
            int szam7 = Convert.ToInt32(Convert.ToString(adoszam[6]));
            int szam8 = Convert.ToInt32(Convert.ToString(adoszam[7]));
            int szam9 = Convert.ToInt32(Convert.ToString(adoszam[8]));
            int szam10 = Convert.ToInt32(Convert.ToString(adoszam[9]));

            int szor1 = szam1 * 1;
            int szor2 = szam2 * 2;
            int szor3 = szam3 * 3;
            int szor4 = szam4 * 4;
            int szor5 = szam5 * 5;
            int szor6 = szam6 * 6;
            int szor7 = szam7 * 7;
            int szor8 = szam8 * 8;
            int szor9 = szam9 * 9;


            int osszeg = szor1 + szor2 + szor3 + szor4 + szor5 + szor6 + szor7 + szor8 + szor9;

            Console.WriteLine(osszeg);

            int osztas = osszeg % 11;
            Console.WriteLine(osztas);
            if (osztas == szam10)
            {
                Console.WriteLine("Jó az adószámod");
            }
            else
            {
                Console.WriteLine("Rossz az adószámod");
            }

        }
    }
}
