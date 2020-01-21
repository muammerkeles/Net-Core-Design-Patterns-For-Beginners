using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Locator.Pattern.Demo.Services
{
    public interface IServiceC
    {
        double GetVersionNo();
    }
    public class ServiceC : IServiceC
    {
        public double GetVersionNo() => 1;
    }
}
