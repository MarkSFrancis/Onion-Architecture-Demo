using System;
using System.Collections.Generic;

namespace OnionArchitecture.UI.Injection
{
    public class Injector
    {
        Dictionary<Type, Func<object>> TypeMap { get; set; }

        public Injector()
        {
            TypeMap = new Dictionary<Type, Func<object>>();
        }

        public void RegisterSingleton<TInterface, TClass>() where TClass : TInterface
        {
            TypeMap.Add(typeof(TInterface), () => Activator.CreateInstance<TClass>());
        }

        public void RegisterSingleton<TInterface>(Func<TInterface> constructor)
        {
            TypeMap.Add(typeof(TInterface), () => constructor());
        }

        public TInterface GetInstance<TInterface>()
        {
            var constructor = TypeMap[typeof(TInterface)];

            return (TInterface)constructor();
        }
    }
}
