namespace DesignPatterns_03
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var orcamento = new Orcamento(500.0);
            var icpp = new ICPP();
            var ikcv = new IKCV();
            var ihit = new IHIT();
            var calculador = new CalculadorDeImpostos();
            calculador.RealizaCalculo(orcamento, icpp);
            calculador.RealizaCalculo(orcamento, ikcv);
            calculador.RealizaCalculo(orcamento, ihit);
        }

        // Template Method Pattern applied to the project DesignPatterns_03
    }
}

