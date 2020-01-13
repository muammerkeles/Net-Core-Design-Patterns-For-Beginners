using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.Design.Patterns.Base.WithAbstract
{
    public class MsSqlBaglanti : BaglantiAbstract
    {
        public override void BaglantiKur()
        {
            Console.WriteLine("Microsoft Sql Bağlantısı Kuruldu");
            //throw new NotImplementedException();
        }
    }
}
