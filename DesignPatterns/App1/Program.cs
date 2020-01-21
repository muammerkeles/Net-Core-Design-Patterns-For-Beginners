using ModelConcept.Sample.Person;
using ModelConcept.Sample.Person.Interface;
using Singleton.Design.Pattern;
using Factory.Design.Patterns;
#region factoryDesignPattern_Abstract
using Factory.Design.Patterns.Base.WithAbstract;
#endregion factoryDesignPattern_Abstract

#region factoryDesignPattern_Interface
using Factory.Design.Patterns.Base.WithInterface;
#endregion factoryDesignPattern_Interface

#region factoryDesignPattern_Interface___ HESAPLAMA_ORNEGI
using Factory.Design.Patterns.WithInterfaceCalculatorExample;
#endregion factoryDesignPattern_Interface

using Singleton.Design.Pattern.Sample.Static;
using Super.Sub.Classes;
using System;
using Service.Locator.Pattern;
using Service.Locator.Pattern.Demo.Services;

namespace App1 {
    class Program {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            #region ProgramVariants
            string[] qsn = {
                "0-Programdan Çık",
                "1-Sigleton Design Pattern",
                "2-Concept Model",
                "3-Supper Class",
                "4-Factory Design Pattern",
                "5-Factory Design Pattern (Başka bir örnek : Hesaplama)",
                "6-Service Locator Pattern "
            };
            for( int i=1;i<=qsn.Length;i++)
            {
                Console.WriteLine("{0} : {1} örneği", i-1, qsn[i-1]);
            }
            step1:
            string chosen=Console.ReadLine();
            double selectedId;
            bool girilenDeger=double.TryParse(chosen,out selectedId);
            if (!girilenDeger)
            {
                Console.WriteLine("Girilen değer hatalı.\nBir seçenek seçip ilerleyin!\n");
                
                goto step1;
            }
            #endregion

            ////  Bu bölüm de, ilerleyen derslerde bir "Design Pattern" örneği ile refactoring ediliebilir!



            switch (selectedId)
            {
                #region ExitCase
                case 0:
                    Environment.Exit(0);
                    break;
                //Console.WriteLine("Hatalı seçim.\nBir seçenek seçip ilerleyin!");
                //Main(args);
                //return;
                #endregion ExitCase

                #region SingleTon

                case 1:
                    /////       Singleton
                    ///  Sadece tek bir objenin tekrar tekrar kullanılacağı durumlarda(örn;logger, bidirimler gibi) kullanılıyor.
                    //  GetInstance methodu ile aynı obje tekrar tekrar kullanılabilir.. Örnek; 
                    Logger log = Logger.GetInstance;
                    Logger log2 = Logger.GetInstance;
                    Console.WriteLine("Log1 : {0}", log.GetHashCode());
                    Console.WriteLine("Log2 : {0}", log2.GetHashCode());
                    /////////           instance kodlarının aynı olduğunu görebiliriz.
                    ///
                    break;
                #endregion SingleTon

                #region ConceptModel 

                case 2:
                    // Örnek  
                    var eg1 = new Person("info@muammerkeles.com", "Muammer K.", new Pop3Mail());
                    eg1.KullaniciyiBilgilendir();
                    Console.WriteLine("Bu işlemin Hash Kodu'si : {0}\n{1}\n", eg1.GetHashCode(), "-----------------");

                    // Örnek  - Tek satırda işlem tamamlanabilir
                    var eg2 = new Person("smptMember@singletonsample.com", "Alice S.", new SmtpMail());
                    eg2.KullaniciyiBilgilendir();
                    Console.WriteLine("Bu işlemin Hash Kodu'si : {0}\n{1}\n", eg2.GetHashCode(), "-----------------");

                    break;

                #endregion ConceptModel

                #region superClass
                case 3:
                    /////       Superclass
                    Console.WriteLine("-------- Super Clas ----");
                    ClassAile obj = new ClassAile();
                    obj.Soyisim = "Taha";
                    obj.Yemek();
                    Console.WriteLine("");
                    ///



                    Console.WriteLine("-------- Super Class with Sub Class----");
                    ClassAile obj2 = new ClassBirey("Yusuf","Çocuk");
                    obj2.Soyisim = "Taha";
                    obj2.Yemek();
                    Console.WriteLine("");
                    ///


                    Console.WriteLine("-------- Super Clas ----");
                    ClassBirey obj3 = new ClassBirey("Cemal","Baba");
                    obj3.Soyisim = "Taha";
                    obj3.Yemek();
                    break;
                #endregion superClass


                #region FactoryDesign
                case 4:
                    //abstract factory için Örnek1
                    BaglantiCreator baglantiFabrikasi = new BaglantiCreator();                    
                    BaglantiAbstract mmongoDb_abstract_inherit = baglantiFabrikasi.FactoryMethodum(Baglantilar.MongoDb);
                    mmongoDb_abstract_inherit.BaglantiKur();

                    //interface kullanım ile ÖRnek1
                    IBaglanti mysql_interface = new MySqlIF();
                    mysql_interface.BaglantiKur();
                    //interface kullanım ile Örnek1
                    IBaglanti oracle_interface = new OracleIF();
                    oracle_interface.BaglantiKur();
                    Console.WriteLine("\n\n");

                    break;

                #endregion FactoryDesign

                #region MoreFactoryDesign
                case 5:
                    ////            Interface + factory pattern ile Örnek2 |  Hesaplama / dört işlem)
                    Console.WriteLine("Hesaplama yapmak için aşağıdaki değerlerden bir tanesini girin.\n\n1:Topla işlemi \n2:Cikarma işlemi \n3:Bölme işlemi \n4:Çarpma işlemi ");

                    DortIslem diEnum;
                    var girilen = Enum.TryParse<DortIslem>(Console.ReadLine(), out diEnum);
                    IHesaplayıcı hesaplama = new HesaplamaFactory().HesaplayiciFactoryMethod(diEnum);
                    Console.WriteLine("Şimdi Birinci Değeri Girin::");
                    var deger1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Şimdi İkinci Değeri Girin::");
                    var deger2 = Convert.ToDouble(Console.ReadLine());
                    hesaplama.Hesapla(deger1, deger2);
                    break;
                #endregion MoreFactoryDesign

                #region ServiceLocator
                case 6:
                    //loc => locator => bulan, bulucu!
                    IServiceLocator loc = new ServiceLocator();
                    IServiceB servisa = loc.GetService<IServiceB>();
                    Console.WriteLine($"Servis cevabı : {servisa.GetName()}");
                    break;
                #endregion ServiceLocator


                default:
                    Console.WriteLine("Hatalı seçim.\nBir seçenek seçip ilerleyin!");
                    Console.ReadLine();
                    //Main(args);
                    break;
            }

            Console.WriteLine("\n\r");
            Console.WriteLine("Programı kapatmak için Escape tuşuna basın.");
            Console.WriteLine("\n\r");

            ConsoleKeyInfo escExpect =Console.ReadKey();
            if (escExpect.Key != ConsoleKey.Escape)
            {
                Main(args);
            } else
            {
                Environment.Exit(0);
            }
                //Console.ReadLine();
            //Console.ReadLine();
        }
        void ExitApp()
        {
            Environment.Exit(0);
        }
    }
}
