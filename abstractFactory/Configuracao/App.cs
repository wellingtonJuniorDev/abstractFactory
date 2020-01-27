using abstractFactory.Cliente;
using abstractFactory.Fabrica;
using SimpleInjector;
using SimpleInjector.Lifestyles;

namespace abstractFactory.Configuracao
{
    public static class App
    {
        private static Container container;

        public static void Bootstrap()
        {
            container = new Container();
            container.Options.DefaultScopedLifestyle = new AsyncScopedLifestyle();

            container.Register<IExtintorFactory, TiposExtintorFactory>(Lifestyle.Scoped);
            container.Register<ILojaDeExtintor, LojaDeExtintor>(Lifestyle.Scoped);

            container.Verify();
        }

        public static Container GetContainer() => container;

        public static TService GetInstance<TService>() where TService : class 
            => container.GetInstance<TService>();

    }
}
