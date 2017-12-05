using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolo1_NS_A
{
    class Program
    {
        static void Main(string[] args)
        {

            Wycieczka w1 = new Wycieczka("Grecja", 2100);
            Wycieczka w2 = new Wycieczka("Turcja", 2200);
            WycieczkaKrajowa wk1 = new WycieczkaKrajowa("Krynica Morska", 3000, true);
            WycieczkaKrajowa wk2 = new WycieczkaKrajowa("Krakow", 1800, false);
            WycieczkaZagraniczna wz1 = new WycieczkaZagraniczna("Hiszpania", 2000, 4);
            WycieczkaZagraniczna wz2 = new WycieczkaZagraniczna("Egipt", 2500, 8);
            wk1.LastMinute();
            wk1.LastMinute();
            wz1.FirstMinute();
            wz2.FirstMinute();

            Console.WriteLine(w1.Info());
            Console.WriteLine(w2.Info());
            Console.WriteLine(wk1.Info());
            Console.WriteLine(wk2.Info());
            Console.WriteLine(wz1.Info());
            Console.WriteLine(wz2.Info());

            Console.ReadKey();

        }
    }
}
