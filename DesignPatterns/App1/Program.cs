using Singleton.Design.Pattern;
using Singleton.Design.Pattern.Sample.Person;
using Singleton.Design.Pattern.Sample.Person.Interface;
using Singleton.Design.Pattern.Sample.Static;
using System;

namespace App1 {
    class Program {
        static void Main(string[] args)
        {
            /////       Singleton
            ///  Sadece tek bir objenin tekrar tekrar kullanılacağı durumlarda(örn;logger, bidirimler gibi) kullanılıyor.
            //  GetInstance methodu ile aynı obje tekrar tekrar kullanılabilir.. Örnek 3'te var. 

            // Örnek 1
            var eg1 = new Person("info@muammerkeles.com", "Muammer K.", new Pop3Mail());
            eg1.KullaniciyiBilgilendir();
            Console.WriteLine("Bu işlemin Hash Kodu'si : {0}\n{1}\n", eg1.GetHashCode(),"-----------------");

            // Örnek 2 - Tek satırda işlem tamamlanabilir
            var eg2 = new Person("smptMember@singletonsample.com", "Alice S.", new SmtpMail());
            eg2.KullaniciyiBilgilendir();
            Console.WriteLine("Bu işlemin Hash Kodu'si : {0}\n{1}\n", eg2.GetHashCode(), "-----------------");

            // Örnek 3 - Singleton static kullanım için GetInstance methodu ile obje zaten oluşturulmuş ise aynı obje ile işlem yaptırılır
            Logger log = Logger.GetInstance;
            Logger log2 = Logger.GetInstance;
            Console.WriteLine("Log1 : {0}", log.GetHashCode());
            Console.WriteLine("Log2 : {0}", log2.GetHashCode());

            Console.ReadLine();
            Console.WriteLine("Program kapatılacak..");
        }
    }
}
