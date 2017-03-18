using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            Arabulucu arabulucu = new Arabulucu();
            Taraf1 taraf1 = new Taraf1(arabulucu);
            Taraf2 taraf2 = new Taraf2(arabulucu);
            arabulucu.Taraf1 = taraf1;
            arabulucu.Taraf2 = taraf2;
            taraf1.Gonder("Nasılsın?");
            taraf2.Gonder("İyi, teşekkürler");
            Console.ReadKey();
        }
    }
}
