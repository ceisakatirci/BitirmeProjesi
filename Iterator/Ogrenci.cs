using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    class Ogrenci
    {
        private static int _id = 0;
        public int OgrenciId { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public Ogrenci()
        {
            this.OgrenciId = ++_id;
        }
        public override string ToString()
        {
            return  String.Format("Id: {0,-2} Ad: {1,-8} Soyad: {2,-8}",OgrenciId,Ad,Soyad); 
        }
    }
}
