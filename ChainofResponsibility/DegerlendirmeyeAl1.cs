﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainofResponsibility
{
    class DegerlendirmeyeAl1: OzetDegerlendirmeyeAl
    {
        public override void TalepDegerlendirmeyeAl(int talep)
        {
            if (talep >= 0 && talep < 10)
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
