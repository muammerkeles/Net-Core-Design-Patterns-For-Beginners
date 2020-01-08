using System;
using System.Collections.Generic;
using System.Text;

namespace Super.Sub.Classes {
    /// <summary>
    /// ClassBaba  ClassAileden Türetildi (derived), yani ClassAilenin özelliklerine sahip ve kendi özelliklerini kullanabilir, 
    /// ayrıca ClassAile'nin de override edilebilen (virtual veya abstract olarak oluşturulmuş) methodlarına ulaşabilir, menupule edebilir
    /// Yemek methodunda olduğu gibi
    /// </summary>
    public class ClassBirey : ClassAile {
        private string name;
        private string rol;
        public ClassBirey(string isim,string rolTanimi)
        {
            this.rol = rolTanimi;
            this.name= isim;
            //Console.WriteLine("'{0}' bireyi için '{0}' rol tanımı yapıldı.", this.name,this.rol);
        }
        public override void Yemek()
        {
            Console.WriteLine("{0} bireyi {1}, ailesiyle birlikte akşam yemeği yerler",this.name,this.rol);
        }
    }
}