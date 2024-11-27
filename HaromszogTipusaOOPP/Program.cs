using System;

namespace HaromszogTipusaOOP

{

    class HTipus

    {

        private int a, b, c;

        public HTipus(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public bool ErvenyesHaromszog()
        {
            return (a + b > c) && (a + c > b) && (b + c > a);
        }
        public bool DerekszoguHaromszog()
        {
            if (!ErvenyesHaromszog()) return false;
            int[] oldalak = { a, b, c };
            Array.Sort(oldalak);
            return (oldalak[0] * oldalak[0] + oldalak[1] * oldalak[1] == oldalak[2] * oldalak[2]);
        }

        public bool EgyenloSzaruHaromszog()
        {
            if (!ErvenyesHaromszog()) return false;
            return (a == b) || (a == c) || (b == c);
        }
        public bool EgyenloOldaluHaromszog()
        {
            if (!ErvenyesHaromszog()) return false;
            return (a == b) && (b == c);
        }
        public double Terulet()
        {
            if (!ErvenyesHaromszog()) throw new InvalidOperationException("Nem érvényes háromszög.");
            double s = (a + b + c) / 2.0;
            return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
        }
    }

    class Program
    {
        static void Main(string[] args)

        {
            HTipus haromszog1 = new HTipus(3, 4, 5);
            Console.WriteLine($"Érvényes háromszög: {haromszog1.ErvenyesHaromszog()}");
            Console.WriteLine($"Derékszögű háromszög: {haromszog1.DerekszoguHaromszog()}");
            Console.WriteLine($"Egyenlő szárú háromszög: {haromszog1.EgyenloSzaruHaromszog()}");
            Console.WriteLine($"Egyenlő oldalú háromszög: {haromszog1.EgyenloOldaluHaromszog()}");
            Console.WriteLine($"Terület: {haromszog1.Terulet()}");
            HTipus haromszog2 = new HTipus(5, 5, 5);
            Console.WriteLine($"Érvényes háromszög: {haromszog2.ErvenyesHaromszog()}");
            Console.WriteLine($"Derékszögű háromszög: {haromszog2.DerekszoguHaromszog()}");
            Console.WriteLine($"Egyenlő szárú háromszög: {haromszog2.EgyenloSzaruHaromszog()}");
            Console.WriteLine($"Egyenlő oldalú háromszög: {haromszog2.EgyenloOldaluHaromszog()}");
            Console.WriteLine($"Terület: {haromszog2.Terulet()}");
            Console.ReadLine();
        }
    }
}

