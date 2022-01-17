namespace TemplateMethod
{
    public class Ikkk : TemplateDeImpostoCondicional
    {
        //o método de Imposto já foi implementado no Template, então só complementa com as informações que faltam

        public override bool DeveUsarMaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor >= 500;
        }

        public override double MaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.07;
        }

        public override double MinimaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.05;
        }
    }
}
