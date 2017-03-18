using System;
using System.Collections.Generic;

namespace Mediator.Sohbet
{
    class SohbetOdasi : OzetSohbetOdasi
    {
        public SohbetOdasi()
            : base()
        {

        }
        public override void HepsineGonder(string mesaj, Kullanici gonderenKullanici)
        {
            foreach (Kullanici kullanici in _kullanicilar.Values)
            {
                kullanici.Al(gonderenKullanici: gonderenKullanici, mesaj: mesaj);
            }
        }
        public override void Gonder(string mesaj, Kullanici gonderenKullanici, Kullanici alanKullanici)
        {
            Kullanici _alanKullanici = alanKullanici;
            if (_alanKullanici != null)
            {
                _alanKullanici.Al(gonderenKullanici: gonderenKullanici, mesaj: mesaj);
            }
        }

        public override void Kaydet(Kullanici kullanici)
        {
            if (!_kullanicilar.ContainsKey(kullanici.KullaniciId))
            {
                _kullanicilar.Add(kullanici.KullaniciId, kullanici);
            }
            kullanici.SohbetOdasi = this;
        }

    }
}
