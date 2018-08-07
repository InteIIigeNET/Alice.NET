using SimpleInjector;

namespace Alice.NET.Ioc
{
    public static class Ioc
    {
        private static readonly Container container = new Container();

        public static TInterface GetInstance<TInterface>()
            where TInterface : class
        {
            return container.GetInstance<TInterface>();
        }

        public static void RegisterSingleton<TInterface, TImplementation>()
            where TInterface : class
            where TImplementation : class, TInterface
        {
            container.Register<TInterface, TImplementation>(Lifestyle.Singleton);
        }

        public static void RegisterTransient<TInterface, TImplementation>()
            where TInterface : class
            where TImplementation : class, TInterface
        {
            container.Register<TInterface, TImplementation>(Lifestyle.Transient);
        }

        public static void Verify()
        {
            container.Verify();
        }
    }
}
