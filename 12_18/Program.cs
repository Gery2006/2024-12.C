using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            int lampa;

            // lampa lehet 0:szabad 1:tilos 2:lassan

            Console.WriteLine("Jön-e vonat? (Igen/Nem)");


            string vonatvalasz = Console.ReadLine();
            if (vonatvalasz == "Igen" || vonatvalasz == "Nem")
            {



                if (vonatvalasz == "Igen")
                {

                    Random rnd = new Random();
                    int szam = rnd.Next(3);
                    int veszhelyzet = rnd.Next(2);

                    lampa = szam;
                    if (veszhelyzet == 0) //nincs vészhelyzet)
                    {
                        if (lampa == 1)
                        {
                            Console.WriteLine("Tilos továbbmeni");
                        }
                        else if (lampa == 0)
                        {
                            Console.WriteLine("szabad továbbmenni");
                        }

                        else
                        {
                            Console.WriteLine("Lassan lehet menni");
                        }
                    }
                    else
                        Console.WriteLine("Vészhelyzet van");
                }
                else
                {
                    Console.WriteLine("OK");
                }
            }
            else
            {
                Console.WriteLine("Rossz válasz!");
            }


            Console.WriteLine("Nyomj meg egy gombot a kilépéshez!");
            Console.ReadKey();




        }
    }
}
