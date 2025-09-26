namespace EditorHtml
{
    public static class Menu
    {
        public static void Show()
        {
            Console.Clear();
            //background blue, altera a cor do fundo no terminal
            //Console.BackgroundColor = ConsoleColor.Blue;
            //foreground black, altera a cor do texto no terminal
            //Console.ForegroundColor = ConsoleColor.Black;

            DrawScreen();
            WriteOptions();

            var option = short.Parse(Console.ReadLine()!);
            HandleMenuOption(option);
        }

        public static void WriteOptions()
        {
            //Console.SetCursorPosition(x, y), define a posição do cursor no terminal
            Console.SetCursorPosition(3, 2);
            Console.Write("Editor HTML");
            Console.SetCursorPosition(3, 3);
            Console.Write("===========");

            Console.SetCursorPosition(3, 4);
            Console.Write("Selecione uma opção abaixo");

            Console.SetCursorPosition(3, 6);
            Console.Write("1 - Novo arquivo");

            Console.SetCursorPosition(3, 7);
            Console.Write("2 - Abrir");

            Console.SetCursorPosition(3, 9);
            Console.Write("0 - Sair");

            Console.SetCursorPosition(3, 10);
            Console.Write("Opção: ");

        }


        public static void DrawScreen()
        {
            HeaderFooter();

            for (int lines = 0; lines <= 10; lines++)
            {
                Console.Write("|");
                for (int i = 0; i <= 30; i++)
                    Console.Write(" ");

                Console.Write("|");
                Console.Write("\n");
            }

            HeaderFooter();
        }


        public static void HeaderFooter()
        {
            Console.Write("+");
            for (int i = 0; i <= 30; i++)
                Console.Write("-");

            Console.Write("+");

            Console.Write("\n");
        }

        public static void HandleMenuOption(short option)
        {
            switch (option)
            {
                case 1: Editor.Show(); break; //Console.WriteLine("Editor"); break;
                case 2: Viewer.Show(""); break;
                case 0:
                    {
                        Console.Clear();
                        Environment.Exit(0);
                        break;
                    }
                default: Show(); break;
            }
        }
    }
}