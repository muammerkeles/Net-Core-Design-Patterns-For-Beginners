using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.Design.Patterns.Base.WithAbstract
{
    public class OracleBaglanti : BaglantiAbstract
    {
        public override void BaglantiKur()
        {
            Console.WriteLine("Oracle Bağlantısı Kuruldu");

            //throw new NotImplementedException();
        }
    }
}
