using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Iterator
{
    class Koleksiyon : OzetKoleksiyon
    {
        private ArrayList _elemanlar = new ArrayList();
        public override OzetIterator IteratorOlustur(IteratorVersiyon versiyon)
        {
            switch (versiyon)
            {
                case IteratorVersiyon.IteratorV1:
                    return new IteratorV1(this);
                case IteratorVersiyon.IteratorV2:
                    return new IteratorV2(this);
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
