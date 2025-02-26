using System;

namespace HelloWorld
{
    class Program
    {
        static int ellenorzes(string x)
        {
            int jo;
            int joszam;
            int szorzo = 10;
            int osszeg = 0;
            for (int i = 0; i < x.Length; i++)
            {
                bool siker = int.TryParse(x[i].ToString(), out jo);
                if (siker)
                {
                    osszeg = osszeg + (jo * szorzo);
                    szorzo--;
                }
            }

            int osztas;
            osztas = osszeg % 11;

            if (osztas == Convert.ToInt32(x[12].ToString()))
            {
                joszam = 1;
            }
            else
                joszam = 0;



            return joszam;
        }
        static void Main(string[] args)
        {
            string szemszam = "1-980227-1258";
            Console.WriteLine(ellenorzes(szemszam));

        }
    }
}