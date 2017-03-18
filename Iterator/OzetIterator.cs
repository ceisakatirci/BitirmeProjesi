using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    abstract class OzetIterator
    {
        public abstract object BastaGelen();
        public abstract object Sonraki();
        public abstract bool BittiMi();
        public abstract object SimdikiEleman();
    }
}
