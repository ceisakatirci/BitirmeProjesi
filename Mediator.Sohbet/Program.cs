using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.Sohbet
{
    class Program
    {
        static void Main(string[] args)
        {
            SohbetOdasi oda1 = new SohbetOdasi();
            Kullanici kullanici1 = new Kullanici("Ali");
            Kullanici kullanici2 = new Kullanici("Veli");
            Kullanici kullanici3 = new Kullanici("Ayşe");
            oda1.Kaydet(kullanici1);
            oda1.Kaydet(kullanici2);
            oda1.Kaydet(kullanici3);
            kullanici1.Gonder(mesaj: "Nasılsın?",alanKullanici: kullanici3);
            kullanici3.Gonder(mesaj: "Seni tanımıyorum :)",alanKullanici: kullanici1);
            oda1.HepsineGonder(mesaj: "Ali kullanıcı engellenmiştir", gonderenKullanici: kullanici2);
            Console.ReadLine();

        }
    }
}
