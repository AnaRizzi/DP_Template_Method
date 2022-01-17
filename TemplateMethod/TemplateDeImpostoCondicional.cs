namespace TemplateMethod
{
    public abstract class TemplateDeImpostoCondicional : Imposto
    {
        //o template vai herdar da interface, para manter o padrão de Imposto
        //o método é resumido para esse modelo
        //tudo o que é informação específica vira um novo método abstrato que será implementado por cada classe
        public double Calcula(Orcamento orcamento)
        {
            if (DeveUsarMaximaTaxacao(orcamento)){
                return MaximaTaxacao(orcamento);
            }
            return MinimaTaxacao(orcamento);
        }

        public abstract bool DeveUsarMaximaTaxacao(Orcamento orcamento);
        public abstract double MaximaTaxacao(Orcamento orcamento);
        public abstract double MinimaTaxacao(Orcamento orcamento);
    }
}
