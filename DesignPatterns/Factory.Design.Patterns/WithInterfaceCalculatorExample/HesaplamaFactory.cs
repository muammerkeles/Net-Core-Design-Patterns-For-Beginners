using Factory.Design.Patterns.WithInterfaceCalculatorExample.SubClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.Design.Patterns.WithInterfaceCalculatorExample
{
    public enum DortIslem
    {
        Topla=1,
        Cikar=2,
        Bol=3,
        Carp=4
    }

    public class HesaplamaFactory
    {
        public IHesaplayıcı HesaplayiciFactoryMethod(DortIslem islem)
        {
            IHesaplayıcı sonuc = null;
            switch (islem)
            {
                case DortIslem.Bol:
                    sonuc = new Bol();
                    break;

                case DortIslem.Carp:
                    sonuc = new Carp();
                    break;

                case DortIslem.Cikar:
                    sonuc = new Cikar();
                    break;

                case DortIslem.Topla:
                default:
                    sonuc = new Topla();
                    break;
            }
            return sonuc;
        }
    }
}
