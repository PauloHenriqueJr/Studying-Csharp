namespace DesignPatterns_02
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // calculo normal

            // CalculadorDeDescontos calculador = new CalculadorDeDescontos();
            // Orcamento orcamento = new Orcamento(500.0);
            // orcamento.AdicionaItem(new Item("CANETA", 250.0));
            // orcamento.AdicionaItem(new Item("LAPIS", 250.0));
            // orcamento.AdicionaItem(new Item("BORRACHA", 250.0));
            // orcamento.AdicionaItem(new Item("APONTADOR", 250.0));
            // orcamento.AdicionaItem(new Item("REGUA", 250.0));
            // orcamento.AdicionaItem(new Item("ESTOJO", 250.0));
            // double descontoFinal = calculador.Calcula(orcamento);
            // Console.WriteLine(descontoFinal);

            // calculo com venda casada e desconto por mais de 500 reais

            IDesconto d1 = new DescontoPorCincoItens();
            IDesconto d2 = new DescontoPorMaisDeQuinhentosReais();
            IDesconto d3 = new DescontoPorVendaCasada();
            IDesconto d4 = new SemDesconto();

            d1.Proximo = d2;
            d2.Proximo = d3;
            d3.Proximo = d4;

            Orcamento orcamento = new Orcamento(500.0);
            orcamento.AdicionaItem(new Item("CANETA", 250.0));
            orcamento.AdicionaItem(new Item("LAPIS", 250.0));
            orcamento.AdicionaItem(new Item("BORRACHA", 250.0));

            double descontoFinal = d1.Desconta(orcamento);
            Console.WriteLine(descontoFinal);

        }

        // Chain of Responsibility Pattern applied to the project DesignPatterns_02
    }
}