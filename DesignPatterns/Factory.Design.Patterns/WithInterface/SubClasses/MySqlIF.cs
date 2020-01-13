using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.Design.Patterns.Base.WithInterface
{
    public class MySqlIF : IBaglanti
    {
        public void BaglantiKur()
        {
            Console.WriteLine("MySql Bağlantısı Kuruldu");
            //throw new NotImplementedException();
        }
    }
}
