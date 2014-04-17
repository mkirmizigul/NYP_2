using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ornek_2
{
    class Program
    {
        static void Main(string[] args)
        {

            Otomobil oto = new OtoUret();

            oto.marka = "BMW";

            oto.uretimYili = 2013;

            oto.BilgiYaz();
        }
    }
}
