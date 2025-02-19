using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            int n, i, d1, d2, d3;
            do
            {
                try
                {

                    Console.WriteLine("Mennyit akarsz játszani?");
                    n = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Nem számot adtál meg!");
                }
            } while(n > 0);
            

            int anninyer = 0;
            n = 0;
            int panninyer = 0;
            int dontetlen = 0;

            for (i = 0; i < n; i++)
            {
                d1 = rnd.Next(1, 6);
                d2 = rnd.Next(1, 6);
                d3 = rnd.Next(1, 6);
                int annioszeg = d1 + d2 + d3;
                Console.WriteLine($"{d1}{d2}{d3}{annioszeg}");
                

                d1 = rnd.Next(1, 6);
                d2 = rnd.Next(1, 6);
                d3 = rnd.Next(1, 6);
                int pannioszeg = d1 + d2 + d3;
                Console.WriteLine($"{d1}{d2}{d3}{pannioszeg}");

                if (annioszeg > pannioszeg)
                {
                    Console.WriteLine("Annyi nyert!");
                    annioszeg++;
                }
                else if (pannioszeg > annioszeg)
                {
                    Console.WriteLine("Panni nyert!");
                    pannioszeg++;
                }
                else
                {
                    Console.WriteLine("Döntetlen!");
                    dontetlen++;
                }
               
            }
            Console.WriteLine($"Panni{panninyer}\nAnni{anninyer}\nDöntetlen:{dontetlen}");
            Console.ReadKey();
        }
    }
}