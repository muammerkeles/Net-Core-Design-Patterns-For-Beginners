using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.Design.Patterns.Base.WithInterface
{
    public class OracleIF : IBaglanti
    {
        public void BaglantiKur()
        {
            Console.WriteLine("Oracle Bağlantısı Kuruldu");

            //throw new NotImplementedException();
        }
    }
}
