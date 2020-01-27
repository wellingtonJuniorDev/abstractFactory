using abstractFactory.Cliente;
using abstractFactory.Configuracao;
using abstractFactory.Fabrica;
using abstractFactory.Produto;
using SimpleInjector.Lifestyles;
using System;

namespace abstractFactory
{
    class Program
    {
        static Program() => App.Bootstrap();

        static void Main(string[] args)
        {
            using (AsyncScopedLifestyle.BeginScope(App.GetContainer()))
            {
                var lojaDeExtintor = App.GetInstance<ILojaDeExtintor>();

                Extintor agua = lojaDeExtintor.ObterExtintor(TipoExtintor.Agua);
                agua.Indicacao();

                Extintor gasCarbonico = lojaDeExtintor.ObterExtintor(TipoExtintor.GasCarbonico);
                gasCarbonico.Indicacao();

                Extintor poQuimico = lojaDeExtintor.ObterExtintor(TipoExtintor.PoQuimico);
                poQuimico.Indicacao();

                Console.ReadKey();
            }
        }
    }
}
