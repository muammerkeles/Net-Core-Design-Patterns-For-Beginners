using System;
using System.Collections.Generic;
using System.Text;
namespace Factory.Design.Patterns.Base.WithInterface
{
    public class MsSqlIF : IBaglanti
    {
        public void BaglantiKur()
        {
            Console.WriteLine("Microsoft Sql Bağlantısı Kuruldu");
            //throw new NotImplementedException();
        }
    }
}
