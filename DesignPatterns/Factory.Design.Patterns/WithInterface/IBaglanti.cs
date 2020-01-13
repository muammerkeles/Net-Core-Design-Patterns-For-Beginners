using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.Design.Patterns.Base.WithInterface
{
    public interface IBaglanti
    {
        /// <summary>
        ///     abstract base ile factory method kullanmanın interface ile kullanmaktan farklarından biri 
        ///     - abstract base içinde "Virtual" methodlar yazılabilir (Diğer methodlarda yazılabilir tabi) ancak bu virtual methodlar
        ///     inherit olan (yani miras alınan) Class'lar içinde override edilebilir.
        ///     Interface içinde method yazamazsın, methodları belirlersin.
        /// </summary>
        void BaglantiKur();

    }
}
