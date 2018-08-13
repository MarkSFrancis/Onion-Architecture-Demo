using OnionArchitecture.Core.Data.Repositories;
using OnionArchitecture.Core.Services;
using OnionArchitecture.Database.Repositories;
using OnionArchitecture.Services;
using OnionArchitecture.UI.Injection;
using System;

namespace OnionArchitecture.UI
{
    class Program
    {
        static Injector diContainer;

        static void SetupDi()
        {
            diContainer = new Injector();

            diContainer.RegisterSingleton<ISampleRepository, SampleRepository>();

            diContainer.RegisterSingleton<ISampleService>(() => new SampleService(diContainer.GetInstance<ISampleRepository>()));
        }

        static void Main(string[] args)
        {
            SetupDi();

            var sampleService = diContainer.GetInstance<ISampleService>();

            foreach (var sampleModel in sampleService.GetAll())
            {
                Console.WriteLine(sampleModel.Description);
            }

            Console.ReadLine();
        }
    }
}
