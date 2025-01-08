using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kockak
{
    class NegyszogClass
    {
        private double oldal1, oldal2;
        private double terulet, kerulet;

        public NegyszogClass()
        {
            oldal1 = 0;
            oldal2 = 0;
            terulet = 0;
            kerulet = 0;
            Console.WriteLine("Üres konstruktor hívva.");
        }


        public NegyszogClass(double a)
        {
            oldal1 = a;
            oldal2 = a;
            Console.WriteLine("Egy paraméteres konstruktor (négyzet) hívva.");
            SetTerulet();
            SetKerulet();
        }


        public NegyszogClass(double a, double b)
        {
            oldal1 = a;
            oldal2 = b;
            Console.WriteLine("Két paraméteres konstruktor (téglalap) hívva.");
            SetTerulet();
            SetKerulet();
        }


        public void SetOldal1(double a)
        {
            oldal1 = a;
            if (oldal2 == 0) 
            {
                oldal2 = a;
            }
            SetTerulet();
            SetKerulet();
        }


        public void SetOldal2(double a, double b)
        {
            oldal1 = a;
            oldal2 = b;
            SetTerulet();
            SetKerulet();
        }


        private void SetTerulet()
        {
            terulet = oldal1 * oldal2;
        }


        private void SetKerulet()
        {
            kerulet = 2 * (oldal1 + oldal2);
        }


        public double GetTerulet()
        {
            return terulet;
        }

        public double GetKerulet()
        {
            return kerulet;
        }
    }
}