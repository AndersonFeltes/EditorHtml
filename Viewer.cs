using System.Text.RegularExpressions;
using Microsoft.VisualBasic;

namespace EditorHtml
{
    public class Viewer
    {
        public static void Show(string text)
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

            Console.WriteLine("MODO VISUALIZAÇÃO");
            Console.WriteLine("=====================================");
            Console.WriteLine("Qual o caminho do arquivo?");

             var path = Console.ReadLine()!.ToString();

            OpenFile(path);

            //faz com que o programa aguarde e bloqueie a execução até que o usuário pressione uma tecla
            Console.ReadKey();

            //Menu.Show();

        }

        public static void OpenFile(string path)
        {
            using (var file = new StreamReader(path))
            {

                //le o conteudo do arquivo
                string text = file.ReadToEnd();
                Console.WriteLine(text);
            }

            Console.WriteLine("===========================");
            Console.WriteLine("");
            Console.WriteLine("Voltar ao menu? S/N");

            //capturando a resposta e convertendo para minuscula
            var resp = Console.ReadLine()!;
            var respFinal = resp.ToLower();

            if (respFinal == "s")
            {
                Menu.Show();
            }

            Console.WriteLine("Saindo...");
            Thread.Sleep(2500);
            Environment.Exit(0);
        }

        public static void Replace(string text)
        {
            var strong = new Regex(@"<\s*strong[^>]*>(.*?)<\s*/\s*strong>");

            //Separando todas as palavra recebidas no texo pelo caractere do espaço 
            var words = text.Split(' ');

            for (var i = 0; i < words.Length; i++)
            {
                //verificando se a palavra bate com a expressão regular criada
                //words é a variavél que armazena as palavras
                if (strong.IsMatch(words[i]))
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(
                        words[i].Substring(
                            words[i].IndexOf('>') + 1,
                            (
                                (words[i].LastIndexOf('<') - 1) -
                                words[i].IndexOf('>')
                            )
                        )
                    );

                    Console.Write(" ");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write(words[i]);
                    Console.Write(" ");
                }
            }

        }

    }
}