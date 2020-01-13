using System;
using System.Collections.Generic;
using System.Text;
namespace Factory.Design.Patterns.Base.WithAbstract
{
    public enum Baglantilar{
        MsSql,
        MySql,
        Oracle,
        MongoDb
    }
    public class BaglantiCreator
    {
        public BaglantiAbstract FactoryMethodum(Baglantilar baglantiSecimi)
        {
            BaglantiAbstract _result = null;
            switch (baglantiSecimi)
            {
                default:
                case Baglantilar.MsSql:
                    _result = new MsSqlBaglanti();
                    break;

                case Baglantilar.MySql:
                    _result = new MySqlBaglanti();
                    break;


                case Baglantilar.Oracle:
                    _result = new OracleBaglanti();
                    break;

                case Baglantilar.MongoDb:
                    _result = new MongoDbBaglanti();
                    break;
            }
            return _result;
        }
    }
}
