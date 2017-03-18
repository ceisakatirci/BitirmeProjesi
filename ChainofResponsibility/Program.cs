using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainofResponsibility
{
    class Program
    {
        readonly static Random random = new Random();
        static void Main(string[] args)
        {
            OzetDegerlendirmeyeAl degerlendir1 = new DegerlendirmeyeAl1();
            OzetDegerlendirmeyeAl degerlendir2 = new DegerlendirmeyeAl2();
            OzetDegerlendirmeyeAl degerlendir3 = new DegerlendirmeyeAl3();
            degerlendir1.SonraGeleniBelirle(degerlendir2);
            degerlendir2.SonraGeleniBelirle(degerlendir3);
            List<int> talepler = new List<int>();
            for (int i = 0; i < 30; i++)
            {
                talepler.Add(random.Next(30));
            }
            foreach (int talep in talepler)
            {
               degerlendir1.TalepDegerlendirmeyeAl(talep);
            }

        }
    }
}
