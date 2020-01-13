using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.Design.Patterns.WithInterfaceCalculatorExample.SubClasses
{
    public class Bol : IHesaplayıcı
    {
        public void Hesapla(double deger1,double deger2)
        {
            Console.WriteLine("{0} / {1} eşittir {2}", deger1 , deger2, deger1 / deger2);

            //throw new NotImplementedException();
        }
    }
}
