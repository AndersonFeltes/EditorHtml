using System.Text;

namespace EditorHtml
{
    public static class Editor
    {

        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

            Console.WriteLine("MODO EDITOR");
            Console.WriteLine("===========");
            Start();

        }

        public static void Start()
        {
            //StringBuilder permite criar uma string quando se tem um tamanho desconhecido
            var file = new StringBuilder();

            do
            {
                file.Append(Console.ReadLine());
                file.Append(Environment.NewLine);

            } while (Console.ReadKey().Key != ConsoleKey.Escape); //enquanto a tecla pressionada for diferente de escape

            Console.WriteLine("===========");
            //Viewer.Show(file.ToString());

            Console.WriteLine(" Deseja salvar o arquivo? S/N");

            string option = Console.ReadLine()!.ToLower();

            if (option == "s")
            {
                Save(file.ToString());
            }
            ReturnToMenu();

        }

        public static void Save(string text)
        {
            Console.Clear();
            Console.WriteLine("Qual o caminho para salvar o arquivo?");
            //ao passar o caminho é preciso informar qual nome ele vai ter e a extenção .txt
            var path = Console.ReadLine();

            //using, garante que o arquivo será fechado após o uso
            // StreamWriter, classe para escrever em arquivos
            using (var file = new StreamWriter(path!))
            {
                //Write, escreve o texto no arquivo e salva
                file.Write(text);
            }

            Console.WriteLine($"Arquivo {path} salvo com sucesso!");
            
            ReturnToMenu();
        }

        public static void ReturnToMenu()
        {
            Console.WriteLine("Voltando ao menu...");
            System.Threading.Thread.Sleep(3000);
            Menu.Show();
        }

    }
}