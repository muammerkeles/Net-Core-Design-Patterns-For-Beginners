using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.Design.Patterns.Base.WithAbstract
{
    public abstract class BaglantiAbstract
    {
        public abstract void BaglantiKur();

        /// <summary>
        ///     abstract base ile factory method kullanmanın interface ile kullanmaktan farklarından biri 
        ///     - abstract base içinde "Virtual" methodlar yazılabilir (Diğer methodlarda yazılabilir tabi) bu virtual methodlar
        ///     inherit olan (yani miras alınan) Class'lar içinde override edilebilir.
        ///     Interface içinde method yazamazsın, methodları belirlersin.
        /// </summary>
        /*public virtual void BaglantiKuruluncaMesajVer()
        {
            Console.WriteLine("Bağlantı kuruldu");
        }*/
    }

}
