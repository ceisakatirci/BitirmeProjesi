using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    abstract class OzetTaraf
    {
        protected OzetAracı arabulucu;
        public OzetTaraf(OzetAracı arabulucu)
        {
            this.arabulucu = arabulucu;
        }
    }
}
