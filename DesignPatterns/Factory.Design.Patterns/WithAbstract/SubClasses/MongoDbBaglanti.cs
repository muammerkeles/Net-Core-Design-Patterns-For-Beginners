using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.Design.Patterns.Base.WithAbstract
{
    public class MongoDbBaglanti : BaglantiAbstract
    {
        public override void BaglantiKur()
        {
            Console.WriteLine("Mongo Db Bağlantısı Kuruldu");
        }
    }
}
