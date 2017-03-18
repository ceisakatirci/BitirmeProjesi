using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class Gozlemci :OzetGozlemci
    {
        private string _ad;
        private string _gozlemciDurum;
        public Nesne Nesne { get; set; }
        public Gozlemci(Nesne nesne, string ad)
        {
            this._ad = ad;
            this.Nesne = nesne;
        }
        public override void Guncelle()
        {
            _gozlemciDurum = Nesne.NesneDurum;
            Console.WriteLine("Gözlemci {0}'nın yeni durumu  {1}",
              _ad, _gozlemciDurum);
        }
    }
}
