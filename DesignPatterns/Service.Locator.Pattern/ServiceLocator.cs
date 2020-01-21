using Service.Locator.Pattern.Demo.Services;
using System;
using System.Collections.Generic;

namespace Service.Locator.Pattern
{
    /// <summary>
    ///     source : http://www.stefanoricciardi.com/2009/09/25/service-locator-pattern-in-csharpa-simple-example/
    /// </summary>
    public interface IServiceLocator
    {
        T GetService<T>();
    }

    public class ServiceLocator : IServiceLocator
    {
        private IDictionary<object, object> servicesKutuphanesi;

        public ServiceLocator()
        {
            servicesKutuphanesi = new Dictionary<object, object>();

            // fill the map
            this.servicesKutuphanesi.Add(typeof(IServiceB).Name, new ServiceB());
            this.servicesKutuphanesi.Add(typeof(IServiceB1).Name, new ServiceB1());

            //throw new NotImplementedException();
        }

        public T GetService<T>()
        {
            try
            {
                T instance = default(T);
                instance = (T)servicesKutuphanesi[typeof(T).Name];
                return instance;
                //throw new NotImplementedException();
            }
            catch (KeyNotFoundException ex)
            {
                throw new ApplicationException("The requested service is not registered");
            }
        }
    }
}