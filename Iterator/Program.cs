using System;

namespace Iterator
{
    enum IteratorVersiyon { SomutIteratorV1, SomutIteratorV2 }
    class Program
    {
        static void Main(string[] args)
        {
            SomutKume kume = new SomutKume();
            kume[0] = "Elaman 1";
            kume[1] = "Elaman 2";
            kume[2] = "Elaman 3";
            kume[3] = "Elaman 4";
            Iterator iterator = kume.IteratorOlustur(
                IteratorVersiyon.SomutIteratorV1);
            object eleman = null;
            while ((eleman = iterator.Sonraki()) != null)
            {
                Console.WriteLine(eleman);
            }
            iterator = kume.IteratorOlustur(
                IteratorVersiyon.SomutIteratorV2);
            while (iterator.BittiMi())
            {
                Console.WriteLine(iterator.SimdikiEleman());
            }
        }
    }
}
