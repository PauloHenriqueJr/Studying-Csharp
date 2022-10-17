
namespace DesignPatterns_04
{
    class Program
    {
        static void Main(string[] args)
        {
            // Aplicando o padrão de projeto state (Estado)

            // Criando um orçamento
            Orcamento reforma = new Orcamento(500.0);

            // Aplicando descontos
            reforma.AplicaDescontoExtra();

            // Aprovando o orçamento
            reforma.Aprova();

            // Aplicando descontos
            reforma.AplicaDescontoExtra();

            // Finalizando o orçamento
            reforma.Finaliza();

            // Aplicando descontos
            reforma.AplicaDescontoExtra();


        }

        // State Pattern applied to the project DesignPatterns_04
    }
}