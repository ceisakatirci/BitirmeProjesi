using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    abstract class OzetTaraf
    {
        protected OzetArabulucu arabulucu;
        public OzetTaraf(OzetArabulucu arabulucu)
        {
            this.arabulucu = arabulucu;
        }
    }
}
