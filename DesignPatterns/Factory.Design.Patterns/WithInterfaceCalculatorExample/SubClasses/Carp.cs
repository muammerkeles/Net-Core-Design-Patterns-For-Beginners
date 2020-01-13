using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.Design.Patterns.WithInterfaceCalculatorExample.SubClasses
{
    public class Carp : IHesaplayıcı
    {
        public void Hesapla(double deger1, double deger2)
        {
            //Console.WriteLine("Deger1 x Deger2 eşittir {0}", deger1 * deger2);
            Console.WriteLine("{0} x {1} eşittir {2}", deger1, deger2, deger1 * deger2);

            //throw new NotImplementedException();
        }
    }
}
