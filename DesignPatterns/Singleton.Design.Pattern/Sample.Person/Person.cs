
using Singleton.Design.Pattern.Sample.Person.Interface;
using System;

namespace Singleton.Design.Pattern.Sample.Person {
    /// <summary>
    //  @@@  SENARYO
    /// Websitenize yeni bir üye register olduğunda ona bunu mail ile bildireceğimizi senaryo edelim.
    /// Bu durumda  "Singleton-Design-Pattern" kullanılabilir.

    // PersonId  ve CreatedDate fieldları private, çünkü "Person" classının oluşturucu (Constructor) methodu çağrıldığında değer verilecek.
    // Tabi ki böyle bir kaide yok, public de yapılabilir ancak bunun c.tor içinde değil bu obje oluşturulduktan sonra değer ver.
    /// </summary>

    public class Person {
        private int PersonId;
        private string PersonName;
        private DateTime BildirimTarihi= DateTime.Now;
        public string EmailAddress;

        /// <summary>
        /// Bir tane de Interface ekleyerek, bu DesignPattern içinde Interface kullanımını da tecrübe etmiş olalım.
        /// </summary>
        IEposta email;

        public Person(string email,string isim,IEposta epostaServis)
        {
            this.EmailAddress = email;
            this.PersonName = isim;
            this.email = epostaServis;
        }
        public void KullaniciyiBilgilendir()
        {
            Console.WriteLine("Kişi bilgileri\nİsim : {0} \nE-posta: {1}", PersonName, EmailAddress);
            email.EpostaGonder();
        }
    }
}
