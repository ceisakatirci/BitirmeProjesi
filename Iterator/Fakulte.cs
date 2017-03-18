using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    class Fakulte : OzetKoleksiyon
    {
        private List<Ogrenci> _ogrenciler = null;

        public List<Ogrenci> Ogrenciler
        {
            get { return _ogrenciler; }
        }
        public override OzetIterator IteratorOlustur(IteratorVersiyon versiyon)
        {
            return new ListeIterator();
        }
        public Fakulte()
        {
            _ogrenciler = new List<Ogrenci>();
            _ogrenciler.AddRange(new Ogrenci[]{ 
                new Ogrenci { Ad = "Murat", Soyad = "Ülker" },
                new Ogrenci { Ad = "Hüsnü", Soyad = "Özyeğin"},
                new Ogrenci { Ad = "Semahat", Soyad = "Arsel"},
                new Ogrenci { Ad = "Şarık", Soyad = "Tara" },
                new Ogrenci { Ad = "Erman", Soyad = "Ilıcak"},
                new Ogrenci { Ad = "Rahmi", Soyad = "Koç" }});
        }

    }
}
