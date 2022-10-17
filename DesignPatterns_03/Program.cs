namespace DesignPatterns_03
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Aplicando o padrão de projeto Template Method

            // var orcamento = new Orcamento(500.0);
            // var icpp = new ICPP();
            // var ikcv = new IKCV();
            // var ihit = new IHIT();
            // var calculador = new CalculadorDeImpostos();
            // calculador.RealizaCalculo(orcamento, icpp);
            // calculador.RealizaCalculo(orcamento, ikcv);
            // calculador.RealizaCalculo(orcamento, ihit);

            // Aplicando o padrão de projeto Decorator

            // Imposto impostoComplexo = new ISS(new ICMS());
            // Orcamento orcamento = new Orcamento(500.0);
            // double valor = impostoComplexo.Calcula(orcamento);
            // Console.WriteLine(valor);

            // Imposto impostoMuitoAlto = new ImpostoMuitoAlto(new ICMS());
            // double valor2 = impostoMuitoAlto.Calcula(orcamento);
            // Console.WriteLine(valor2);       

        }

        // Template Method Pattern applied to the project DesignPatterns_03
    }
}

