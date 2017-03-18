using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    abstract class OzetNesne
    {
        private List<OzetGozlemci> _gozlemciler = new List<OzetGozlemci>();
        public void Ekle(OzetGozlemci gozlemci)
        {
            _gozlemciler.Add(gozlemci);
        }

        public void Cikar(OzetGozlemci gozlemci)
        {
            _gozlemciler.Remove(gozlemci);
        }

        public void Bildir()
        {
            foreach (OzetGozlemci o in _gozlemciler)
            {
                o.Guncelle();
            }
        }

       
    }
}
