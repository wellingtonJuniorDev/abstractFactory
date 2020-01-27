using System;
/// <summary>
/// Classes concretas de 'AbstractProduct'
/// </summary>
namespace abstractFactory.Produto
{
    public class Agua : Extintor
    {
        public override void Indicacao()
        {
            Console.WriteLine("Para incêndios de classe A. Age por resfriamento e nunca dever deve ser usado em incêndios de classes B e C.");
        }
    }

    public class GasCarbonico : Extintor
    {
        public override void Indicacao()
        {
            Console.WriteLine("Para incêndios de classe B e C. Age por abafamento, extinguindo o oxigênio e causando resfriamento dos materiais.");
        }
    }

    public class PoQuimico : Extintor
    {
        public override void Indicacao()
        {
            Console.WriteLine("Para incêndios e classe A, B e C. Extingue o fogo por meio de reações químicas e abafamento. Pode ser usado para contenção de praticamente qualquer natureza.");
        }
    }

}
