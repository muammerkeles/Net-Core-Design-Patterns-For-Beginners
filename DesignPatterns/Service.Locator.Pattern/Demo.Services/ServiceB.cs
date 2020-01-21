using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Locator.Pattern.Demo.Services
{
    public interface IServiceB
    {
        string GetName();
    }
    public class ServiceB:IServiceB
    {
        public string GetName()
        {
            return "Muammer K.";
        }
    }
    public interface IServiceB1
    {
        string GetName();
    }
    public class ServiceB1 : IServiceB1
    {
        public string GetName()
        {
            return "Muammer K.";
        }
    }
}
