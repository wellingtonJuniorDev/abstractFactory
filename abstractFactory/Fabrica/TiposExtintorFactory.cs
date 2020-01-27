using abstractFactory.Produto;
using System;

namespace abstractFactory.Fabrica
{
    // Classe concreta de 'AbstractFactory'
    class TiposExtintorFactory : IExtintorFactory
    {
        public Extintor CriarExtintor(TipoExtintor tipo)
        {
            switch (tipo)
            {
                case TipoExtintor.Agua: return new Agua();
                case TipoExtintor.GasCarbonico: return new GasCarbonico();
                case TipoExtintor.PoQuimico: return new PoQuimico();

                default:
                    throw new ArgumentOutOfRangeException("Tipo de extintor informado é inexistente.");
            }
        }
    }    
}
