using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Iterator
{
    class ListeIterator : OzetIterator
    {
        private Fakulte _fakulte = null;
        public Fakulte Fakulte
        {
            get { return _fakulte; }
            set { _fakulte = value; }
        }
        private int indeks = -1;
        public override object BastaGelen()
        {
            return Fakulte.Ogrenciler[0];
        }

        public override object Sonraki()
        {
            indeks++;
            Ogrenci ogrenci = Fakulte.Ogrenciler[indeks];
            return ogrenci;
        }

        public override bool BittiMi()
        {
            return indeks >= Fakulte.Ogrenciler.Count - 1;
        }

        public override object SimdikiEleman()
        {
            return Fakulte.Ogrenciler[indeks];
        }
    }
}
