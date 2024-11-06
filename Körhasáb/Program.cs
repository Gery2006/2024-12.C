using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Körhasáb
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1.objektum
            // A kör osztály felhasználása
            // 1. objektum

            kor K1 = new kor(); // Objektum példány létrehozása üresen
            K1.ReadSugar(15.0); // Sugár megadása 
            K1.SetKerulet();  // Kiszámoltatjuk a kerületet
            K1.SetTerulet();  // Kiszámoltatjuk a területet
            Console.WriteLine($"{K1.GetSugar()} sugarú kör terüete {K1.GetKerulet()},területe: {K1.GetTerulet()}");

            #endregion EOP 1.objektum
            #region 2.objektum
            kor K2 = new kor(28.7); // Objektum példány létrehozása üresen
            K2.ReadSugar(15.0); // Sugár megadása 
            K2.SetKerulet();
            K2.SetTerulet(); 
            Console.WriteLine($"{K2.GetSugar()} sugarú kör terüete {K2.GetKerulet()},területe: {K2.GetTerulet()}");

            Console.ReadKey();
            #endregion EOP 2.objektum
            #region kor2 használata
            kor2 k21 = new kor2(24.5);
            Console.WriteLine($"\n\nA kör2 adatai: \nsugár = {k21.GetSugár()}, \nkerület = {k21.GetKerület()}, \nterület = {k21.GetTerület()} ");
            #endregion Eof kor2
            #region Henger számítás
            Henger h1 = new Henger(15, 30);
            Console.WriteLine($"\n\nA henger adatai:\nsugara={h1.GetSugar()}, magassága={h1.GetMagasság()},\nalapterülete={h1.GetTerulet()}, \ntérfogata={h1.GetTérfogat()}");
            #endregion Eof Henger
            Console.ReadKey();
        }
    }
}
