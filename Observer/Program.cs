using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            Nesne nesne1 = new Nesne();
            nesne1.Ekle(new Gozlemci(nesne1, "G1"));
            nesne1.Ekle(new Gozlemci(nesne1, "G2"));
            nesne1.Ekle(new Gozlemci(nesne1, "G3"));
            nesne1.Ekle(new Gozlemci(nesne1, "G4"));
            nesne1.NesneDurum = "YeniDurum";
            nesne1.Bildir();
            Console.ReadKey();
        }
    }
}
