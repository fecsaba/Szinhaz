using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szinhaz
{
    class Szinhaz
    {
        static void Main(string[] args)
        {
            // 1.
            Console.WriteLine("1. feltölt");
            Nezoter nt = new Nezoter();
            // 2.
            Console.WriteLine("\n2.");
            nt.Beker();
            // 3.

            Console.WriteLine("\n3.");
            nt.Eladott();
            Console.WriteLine($"Az előadásra eddig {nt.FoglaltSzek} jegy kelt el, ez {nt.Szazalek}%");

            // 4.
            Console.WriteLine("\n4.");
            nt.MaxKat();
            Console.WriteLine($"A legtöbb jegy a {Array.IndexOf(nt.Kat,nt.Kat.Max())+1} kategóriából került ki");

            // 5.
            Console.WriteLine("\n5.");
            Console.WriteLine($"Jelenlegi bevétel: {nt.Bevetel}");


            Console.ReadKey();
        }

        
    }
}
