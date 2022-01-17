using System;

namespace TemplateMethod
{
    public class CalculadorDeImpostos
    {
        public void RealizaCalculo(Orcamento orcamento, Imposto imposto)
        {
            var calculo = imposto.Calcula(orcamento);
            Console.WriteLine(calculo);
        }

    }
}
