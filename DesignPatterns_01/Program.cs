using System.Diagnostics;
namespace DesignPatterns
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Conta conta = new Conta();
            conta.Deposita(100);
            Investimento arrojado = new Arrojado();
            Investimento moderado = new Moderado();
            Investimento conservador = new Conservador();
            RealizadorDeInvestimentos realizador = new RealizadorDeInvestimentos();
            Console.WriteLine("Inestivento Inicial: " + conta.Saldo);
            Console.WriteLine("Investimento Arrojado: ");
            realizador.Realiza(conta, arrojado);
            Console.WriteLine("Investimento Moderado: ");
            realizador.Realiza(conta, moderado);
            Console.WriteLine("Investimento Conservador: ");
            realizador.Realiza(conta, conservador);
        }
   
        // Strategy Pattern applied to the project DesignPatterns_01
    }
}