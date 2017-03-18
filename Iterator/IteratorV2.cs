using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Iterator
{
    class IteratorV2 : OzetIterator
    {
        private Koleksiyon _koleksiyon;
        private int _simdiki = 0;
        public IteratorV2(Koleksiyon koleksiyon)
        {
            this._koleksiyon = koleksiyon;
        }
        public override object BastaGelen()
        {
            return _koleksiyon[0];
        }

        public override object Sonraki()
        {
            object obj = _koleksiyon[_simdiki];
            ++_simdiki;
            return obj;

        }

        public override bool BittiMi()
        {
            if (_simdiki < _koleksiyon.ElemanSayisi)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public override object SimdikiEleman()
        {
            return _koleksiyon[_simdiki];
        }
    }

}
