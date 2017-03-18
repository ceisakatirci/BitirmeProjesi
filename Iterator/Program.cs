using System;

namespace Iterator
{
    enum IteratorVersiyon { IteratorV1, IteratorV2, Diger }
    class Program
    {
        static void Main(string[] args)
        {
            Koleksiyon koleksiyon = new Koleksiyon();
            koleksiyon[0] = "Elaman 1";
            koleksiyon[1] = "Elaman 2";
            koleksiyon[2] = "Elaman 3";
            koleksiyon[3] = "Elaman 4";
            /************************************************************************/
            OzetIterator iterator = koleksiyon.IteratorOlustur(
                IteratorVersiyon.IteratorV1);
            object eleman = null;
            Console.WriteLine(iterator.BastaGelen());
            while ((eleman = iterator.Sonraki()) != null)
            {
                Console.WriteLine(eleman);
            }
            iterator = koleksiyon.IteratorOlustur(
                IteratorVersiyon.IteratorV2);
            while (!iterator.BittiMi())
            {
                Console.WriteLine(iterator.Sonraki());
            }
            /************************************************************************/
            ListeIterator listIterator = new ListeIterator();
            listIterator.Fakulte = new Fakulte();
            while (!listIterator.BittiMi())
            {
                Console.WriteLine(listIterator.Sonraki().ToString());
            }
            /************************************************************************/
            OgretmenContainer ogretmenler = new OgretmenContainer();
            foreach (Ogretmen ogretmen in ogretmenler.Ogretmenler)
            {
                Console.WriteLine(ogretmen.ToString());
            }


        }
    }
}
