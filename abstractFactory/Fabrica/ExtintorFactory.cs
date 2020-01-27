using abstractFactory.Produto;

namespace abstractFactory.Fabrica
{
    /// <summary>
    /// A abstração de 'AbstractFactory'
    /// </summary>
    interface IExtintorFactory
    {
        Extintor CriarExtintor(TipoExtintor tipo);
    }

    public enum TipoExtintor
    {
        Agua = 1,
        GasCarbonico = 2,
        PoQuimico = 3
    }
}
