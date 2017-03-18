using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mediator.Sohbet
{
    class Kullanici : OzetKullanici
    {
        public static int id = 0;
        public override int KullaniciId { get; set; }
        public string Ad { get; private set; }
        public SohbetOdasi SohbetOdasi { get; set; }
        public Kullanici(string ad)
        {
            this.Ad = ad;
            this.KullaniciId = ++id;
        }   
        public override void Al(Kullanici gonderenKullanici,
            string mesaj)
        {
            Console.WriteLine("Gönderen: {0}  Alan: {1}:  Mesaj: '{2}'",
                gonderenKullanici.Ad, Ad, mesaj);
        }
        public void Gonder(Kullanici alanKullanici, string mesaj)
        {
            if (this.SohbetOdasi != null)
            {
                this.SohbetOdasi.Gonder(mesaj: mesaj, gonderenKullanici: this, alanKullanici: alanKullanici);
            }
        }

    }
}
