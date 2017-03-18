using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.Sohbet
{
   abstract class OzetKullanici
    {
       public abstract int KullaniciId { get; set; }
       public abstract void Al(Kullanici gonderenKullanici, string mesaj);
    }
}
