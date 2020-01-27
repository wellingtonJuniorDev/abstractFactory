using abstractFactory.Fabrica;
using abstractFactory.Produto;

namespace abstractFactory.Cliente
{
    interface ILojaDeExtintor
    {
        Extintor ObterExtintor(TipoExtintor tipo);
    }

    /// <summary>
    /// A classe concreta 'Client'
    /// </summary>
    class LojaDeExtintor : ILojaDeExtintor
    {
        private readonly IExtintorFactory _extintorFactory;

        public LojaDeExtintor(IExtintorFactory extintorFactory)
        {
            _extintorFactory = extintorFactory;
        }

        public Extintor ObterExtintor(TipoExtintor tipo)
            => _extintorFactory.CriarExtintor(tipo);
    }
}
