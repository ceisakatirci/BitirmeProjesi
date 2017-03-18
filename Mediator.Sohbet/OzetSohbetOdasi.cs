using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.Sohbet
{
    abstract class OzetSohbetOdasi
    {
        protected Dictionary<int, Kullanici> _kullanicilar = null;
        public OzetSohbetOdasi()
        {
            _kullanicilar = new Dictionary<int, Kullanici>();
        }
        public abstract void HepsineGonder(string mesaj, Kullanici gonderenKullanici);
        public abstract void Gonder(string mesaj, Kullanici gonderenKullanici, Kullanici alanKullanici);
        public abstract void Kaydet(Kullanici kullanici);
    }
}
