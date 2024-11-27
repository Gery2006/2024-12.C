using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaromszogTipusaOOPP
{
    public class HTipus
    {
        private int a, b, c;

        public HTipus(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public bool IsTriangle()
        {
            return a + b > c && a + c > b && b + c > a;
        }

        public bool IsRightTriangle()
        {
            if (!IsTriangle()) return false;
            int[] sides = { a, b, c };
            Array.Sort(sides);
            return sides[0] * sides[0] + sides[1] * sides[1] == sides[2] * sides[2];
        }

        public bool IsIsosceles()
        {
            if (!IsTriangle()) return false;
            return a == b || a == c || b == c;
        }

        public bool IsEquilateral()
        {
            if (!IsTriangle()) return false;
            return a == b && b == c;
        }

        public double Area()
        {
            if (!IsTriangle()) throw new InvalidOperationException("Not a valid triangle.");
            double s = (a + b + c) / 2.0;
            return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
        }

        public static void Main(string[] args)
        {
            HTipus triangle = new HTipus(3, 4, 5);

            Console.WriteLine("Is Triangle: " + triangle.IsTriangle());
            Console.WriteLine("Is Right Triangle: " + triangle.IsRightTriangle());
            Console.WriteLine("Is Isosceles: " + triangle.IsIsosceles());
            Console.WriteLine("Is Equilateral: " + triangle.IsEquilateral());
            Console.WriteLine("Area: " + triangle.Area());
        }
    }

}

