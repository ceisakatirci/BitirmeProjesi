using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    class Taraf1 : OzetTaraf
    {
        public Taraf1(OzetAracı arabulucu)
            : base(arabulucu)
        {

        }
        public void Gonder(string mesaj)
        {
            arabulucu.Gonder(mesaj, this);
        }

        public void Bildir(string mesaj)
        {
            Console.WriteLine("Taraf1 mesajı aldı:\n'{0}'", mesaj);
        }
    }
}
