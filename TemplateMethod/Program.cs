using System;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cálculo de impostos!");

            //Impostos "normais"
            Imposto iss = new Iss();
            Imposto icms = new Icms();

            //Impostos criados usando o Template Method
            Imposto ikkk = new Ikkk();
            Imposto ijjj = new Ijjj();

            //O calculador serve para caso haja alguma outra regra de negócio
            //Se não houver, ela não é necessária
            var calculador = new CalculadorDeImpostos();

            var orcamento = new Orcamento(100);
            orcamento.AdicionaItem(new Item("Caneta", 20));
            orcamento.AdicionaItem(new Item("Lápis", 80));

            //cálculo através do calculador, aso tenha mais coisa pra ser feita lá:
            calculador.RealizaCalculo(orcamento, iss);
            calculador.RealizaCalculo(orcamento, icms);
            calculador.RealizaCalculo(orcamento, ijjj);
            calculador.RealizaCalculo(orcamento, ikkk);

            //cálculo direto, sem passar por mais ninguém:
            Console.WriteLine(iss.Calcula(orcamento));
            Console.WriteLine(icms.Calcula(orcamento));
            Console.WriteLine(ijjj.Calcula(orcamento));
            Console.WriteLine(ikkk.Calcula(orcamento));

            Console.ReadKey();
        }
    }
}
