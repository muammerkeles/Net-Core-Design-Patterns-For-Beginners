using System;
using System.Collections.Generic;
using System.Text;

namespace ModelConcept.Sample.Person.Interface {
    public interface IEposta {
        void EpostaGonder();
    }
    public class SmtpMail : IEposta {
        public void EpostaGonder()
        {
            Console.WriteLine("Smpt üzerinden eposta gönderildi.");
            //throw new NotImplementedException();
        }
    }
    public class Pop3Mail : IEposta {
        public void EpostaGonder()
        {
            Console.WriteLine("Pop3 üzerinden eposta gönderildi.");
            //throw new NotImplementedException();
        }

    }
    public class LocalMakineMail : IEposta {
        public void EpostaGonder()
        {
            Console.WriteLine("Local Makine üzerinden eposta gönderildi.");
            //throw new NotImplementedException();
        }

    }
}
