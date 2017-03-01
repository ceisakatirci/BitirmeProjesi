using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Singleton
{
    class SingletonVersiyon1
    {
        static void Main()
        {
            Singleton singleton1 = Singleton.Instance;
            Singleton singleton2 = Singleton.Instance;
            if (singleton1 == singleton2)
            {
                Console.WriteLine("Sınıf nesneleri aynı instance'ı gösterir");
            }
            Console.ReadKey();
        }
    }
    class Singleton
    {
        private static Singleton _instance;
        protected Singleton()
        {
        }
        public static Singleton Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Singleton();
                }
                return _instance;
            }
        }
    }
}
