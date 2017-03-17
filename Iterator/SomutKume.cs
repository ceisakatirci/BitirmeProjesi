using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Iterator
{
    class SomutKume : Kume
    {
        private ArrayList _elemanlar = new ArrayList();
        public override Iterator IteratorOlustur(IteratorVersiyon versiyon)
        {
            switch (versiyon)
            {
                case IteratorVersiyon.SomutIteratorV1:
                    return new SomutIteratorV1(this);
                case IteratorVersiyon.SomutIteratorV2:
                    return new SomutIteratorV2(this);
                default:
                    throw new Exception(message: "Versiyon Belirtilmedi!");
            }
        }
        public int ElemanSayisi
        {
            get { return _elemanlar.Count; }
        }
        public object this[int index]
        {
            get { return _elemanlar[index]; }
            set { _elemanlar.Insert(index, value); }
        }
    }
}
