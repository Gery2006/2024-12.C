using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Macskak
{
    class Program
    {
        enum Animals {macska, kutya, tigris, farkas};
        static void Main(string[] args)
        {
            Animals b = Animals.farkas;
            Animals c = Animals.macska;
            if (b == Animals.farkas)
            {
                Console.WriteLine("A b állat farkas");
            }
            if (c==Animals.macska)
            {
                Console.WriteLine("A c állat macska");
            }
            Console.ReadKey();

        }
    }
}
