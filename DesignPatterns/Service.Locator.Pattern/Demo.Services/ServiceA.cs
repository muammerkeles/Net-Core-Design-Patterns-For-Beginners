using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Locator.Pattern.Demo.Services
{
    public interface IServiceA
    {
        string Kodu();
    }
    public class ServiceA
    {
        public string Kodu()
        {
            return this.GetHashCode().ToString();
        }
    }
}
