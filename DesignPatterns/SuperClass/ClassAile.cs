using System;
using System.Collections.Generic;
using System.Text;

namespace Super.Sub.Classes {
    /// <summary>
    /// Aile class bir BASE class (sub classları kapsayacak bir class olacak)
    /// </summary>
    public class ClassAile {
        public string Soyisim { get; set; }
        /*public ClassAile(string ailesoyismi)
        {
            this.soyisim = ailesoyismi;
        }*/
        public virtual void Yemek()
        {
            Console.WriteLine("{0} ailesi akşam yemeği yer.",this.Soyisim);
        }
    }
}
