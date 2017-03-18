using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Iterator
{
    class IteratorV1 : OzetIterator
    {
        private Koleksiyon _koleksiyon;
        private int _simdiki = 0;
        public IteratorV1(Koleksiyon koleksiyon)
        {
            this._koleksiyon = koleksiyon;
        }
        public override object BastaGelen()
        {
            return _koleksiyon[0];
        }
        public override object Sonraki()
        {
            object obj = null;
            if (_simdiki < _koleksiyon.ElemanSayisi - 1)
            {
                obj = _koleksiyon[++_simdiki];
            }
            return obj;
        }
        public override bool BittiMi()
        {
            return _simdiki >= _koleksiyon.ElemanSayisi;
        }
        public override object SimdikiEleman()
        {
            return _koleksiyon[_simdiki];
        }
    }
}
