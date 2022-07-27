namespace TextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        
        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("O que você deseja fazer?");
            Console.WriteLine("1 - Abrir arquivo");
            Console.WriteLine("2 - Criar novo arquivo");
            Console.WriteLine("0 - Sair");
            short option = Convert.ToInt16(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Abrir();
                    break;
                case 2:
                    Editar();
                    break;
                case 0:
                    Environment.Exit(0);
                    break;
                default:
                    Menu();
                    break;
            }          
        }
        
        static void Abrir()
        {
            Console.Clear();
            Console.WriteLine("Digite o caminho do arquivo");
            var path = Console.ReadLine();
            using (var stream = new StreamReader(path))
            {
                Console.Clear();
                Console.WriteLine(stream.ReadToEnd());
            }
            Console.ReadKey();
            Menu();
        }

        static void Editar()
        {
            Console.Clear();
            Console.WriteLine("Digite o seu texto abaixo (ESC para sair)");
            Console.WriteLine("----------------------------------------");
            string text = "";

            do
            {
                text += Console.ReadLine();
                text += "\n";
            }

            while (Console.ReadKey().Key != ConsoleKey.Escape);
            {
                Salvar(text);
            }
        }

        static void Salvar(string text)
        {
            Console.Clear();
            Console.WriteLine("Qual o caminho para salvar o arquivo");

            var path = Console.ReadLine();
            using (var file = new StreamWriter(path))
            {
                file.Write(text);
            }
            Console.WriteLine($"Arquivo {path} salvo com sucesso");
            Console.ReadKey();
            Menu();
        }
    }
}