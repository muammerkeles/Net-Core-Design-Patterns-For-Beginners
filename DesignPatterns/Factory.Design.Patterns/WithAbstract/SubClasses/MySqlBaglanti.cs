using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.Design.Patterns.Base.WithAbstract
{
    public class MySqlBaglanti : BaglantiAbstract
    {
        public override void BaglantiKur()
        {
            Console.WriteLine("MySql Bağlantısı Kuruldu");
            //throw new NotImplementedException();
        }
    }
}
