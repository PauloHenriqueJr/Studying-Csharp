namespace DesignPatterns_06
{
    public class Program
    {
        public static void Main(string[] args)
        {
            NotasMusicais notas = new NotasMusicais();
            IList<INota> musica = new List<INota>();
            IList<IPartitura> partituras = new List<IPartitura>()
            {
                new MarchaTurca(notas),
                new FurElise(notas)
            };

            foreach (var partitura in partituras)
            {
                foreach (var nota in partitura.Notas)
                {
                    musica.Add(nota);
                }
            }

            Piano piano = new Piano();
            piano.Toca(musica);

            Console.ReadKey();
        }

        // Creating Music using the Flyweight Pattern
    }
}
