using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    class Aracı : OzetAracı
    {
        private Taraf1 _taraf1 = null;
        private Taraf2 _taraf2 = null;

        public Taraf1 Taraf1
        {
            set { _taraf1 = value; }
        }      

        public Taraf2 Taraf2
        {
            set { _taraf2 = value; }
        }
        public override void Gonder(string mesaj, OzetTaraf taraf)
        {
            if (taraf==_taraf1)
            {
                _taraf2.Bildir(mesaj:mesaj);
            }
            else
            {
                _taraf1.Bildir(mesaj: mesaj);
            }
        }
    }
}
