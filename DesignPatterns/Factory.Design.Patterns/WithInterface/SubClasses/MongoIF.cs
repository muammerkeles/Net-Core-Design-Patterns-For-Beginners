using Factory.Design.Patterns.Base.WithAbstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.Design.Patterns.Base.WithInterface
{
    public class MongoIF : IBaglanti
    {
        public void BaglantiKur()
        {
            Console.WriteLine("Mongo Db Bağlantısı Kuruldu");
        }
    }
}
