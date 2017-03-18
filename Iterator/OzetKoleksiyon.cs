using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    abstract class OzetKoleksiyon
    {
        public abstract OzetIterator IteratorOlustur(IteratorVersiyon versiyon);
    }
}
