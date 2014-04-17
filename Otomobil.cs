using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ornek_2
{
    abstract class Otomobil
    {
        public string marka;

        public int uretimYili;

        public abstract string getMarka();
        
        public int getUretimYili()
        {
            return this.uretimYili;
        }

        public void BilgiYaz()
        {
            Console.WriteLine("\n");
            Console.WriteLine(" Marka : " + getMarka() + "\n");
            Console.WriteLine(" Üretim Yılı : " + getUretimYili() + "\n");
            
            Console.ReadLine();
        }

    }
}
