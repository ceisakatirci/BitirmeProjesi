using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Iterator
{
    class SomutIteratorV2 : Iterator
    {
        private SomutKume _kume;
        private int _simdiki = 0;
        public SomutIteratorV2(SomutKume kume)
        {
            this._kume = kume;
        }
        public override object BastaGelen()
        {
            return _kume[0];
        }

        public override object Sonraki()
        {
            object obj = null;
            if (_simdiki < _kume.ElemanSayisi - 1)
            {
                obj = _kume[++_simdiki];
            }
            return obj;
        }

        public override bool BittiMi()
        {
            if (_simdiki < _kume.ElemanSayisi)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override object SimdikiEleman()
        {
            Object obj = _kume[_simdiki];
            _simdiki++;
            return obj;
        }
    }
    
}
