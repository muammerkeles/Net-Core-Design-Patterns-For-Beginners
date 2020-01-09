using ModelConcept.Sample.Person;
using ModelConcept.Sample.Person.Interface;
using Singleton.Design.Pattern;
 
using Singleton.Design.Pattern.Sample.Static;
using Super.Sub.Classes;
using System;

namespace App1 {
    class Program {
        static void Main(string[] args)
        {
            #region ProgramVariants
            string[] qsn = {
                "Programdan Çık",
                "Sigleton Design Pattern",
                "Concept Model",
                "Supper Class",
                "Factory Design Pattern"
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
                Console.WriteLine("Girilen değer hatalı.\nBir seçenek seçip ilerleyin!");
                goto step1;
            }
            #endregion

            ////  @@@@@      |||        @@@@    Bu bölüm de ilerleyen derslerden sonra bir designpattern ile refactoring edilmeli.
            switch (selectedId)
            {
                case 0:
                    Environment.Exit(0);
                    break;
                    //Console.WriteLine("Hatalı seçim.\nBir seçenek seçip ilerleyin!");
                    //Main(args);
                    //return;
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
