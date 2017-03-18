using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    abstract class OzetAracı
    {
        public abstract void Gonder(string mesaj, OzetTaraf taraf);
    }
}
