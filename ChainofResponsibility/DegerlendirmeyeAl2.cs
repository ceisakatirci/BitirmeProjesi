using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainofResponsibility
{
    class DegerlendirmeyeAl2: OzetDegerlendirmeyeAl
    {
        public override void TalepDegerlendirmeyeAl(int talep)
        {
            if (talep >= 10 && talep < 20)
            {
                Console.WriteLine("{0} talep {1}'i değerlendirmeye aldı",
                  this.GetType().Name, talep);
            }
            else if (sonraGelen != null)
            {
                sonraGelen.TalepDegerlendirmeyeAl(talep);
            }
        }
    }
}
