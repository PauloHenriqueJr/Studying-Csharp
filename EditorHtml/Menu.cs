namespace EditorHtml
{
    public static class Menu
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.Black;
            
            DrawScreen();
            WriteOptions();

            var option = short.Parse(Console.ReadLine());
            HandleMenuOption(option);
        }
        public static void DrawScreen()
        {
            // linha inicial    
            Console.Write("+");
            for (int i = 0; i <= 30; i++)
                Console.Write("-");

            Console.Write("+");
            Console.Write("\n");
            // linhas e colunas laterais
            for (int lines = 0; lines <= 10; lines++)
            {
                Console.Write("|");
                for (int columns = 0; columns <= 30; columns++)
                    Console.Write(" ");
                Console.Write("|\n");
            }
            //linha do fim
            Console.Write("+");
            for (int i = 0; i <= 30; i++)
                Console.Write("-");

            Console.Write("+");
            Console.Write("\n");
        }
        
        public static void WriteOptions()
        {
            Console.SetCursorPosition(3, 2);
            Console.WriteLine("Editor HTML");
            Console.SetCursorPosition(3, 3);
            Console.WriteLine("============");
            Console.SetCursorPosition(3, 4);
            Console.WriteLine("Selecione uma opção abaixo");
            Console.SetCursorPosition(3, 6);
            Console.WriteLine("1 - Novo arquivo");
            Console.SetCursorPosition(3, 7);
            Console.WriteLine("2 - Abrir");
            Console.SetCursorPosition(3, 9);
            Console.WriteLine("0 - Sair");
            Console.SetCursorPosition(3, 10);
            Console.WriteLine("Opção: ");
            Console.SetCursorPosition(10,10);

        }

        public static void HandleMenuOption(int option)
        {
            switch (option)
            {
                case 1:
                    Console.Clear();
                    Editor.Show();
                    Console.ReadKey();
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("View");
                    Console.ReadKey();
                    break;
                case 0:
                    Console.Clear();
                    Environment.Exit(0);
                    Console.ReadKey();
                    break;
                default:
                    Show();
                    break;
            }
        }
    }
}