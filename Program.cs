using System;

namespace Backend.C__Sistema_de_Produtos
{
    class Program
    {
        static int tamanhoArrays = 10;
        static int tamanhoLista = 50;
        static string[] nomeProduto = new string[tamanhoArrays];
        static float[] precoProduto = new float[tamanhoArrays];
        static int i = 0;
        static bool VoltarMenu = false;
        static bool[] promocao = new bool[tamanhoArrays];
        static string novoProduto = "";
        static bool novoCadastro = false;
        static void Main(string[] args)
        {
            Console.WriteLine("\nCadastre o seu produto e comece a vender JÁ! :)\nO limite de cadastro de produto é 10.");
            do
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nO limite de cadastro de produto é 10!");
                mostarMenu();
                string menu = Console.ReadLine().ToLower();

                switch (menu)
                {
                    case "c":

                        cadastrarProduto();
                        break;

                    case "l":
                        ListarProdutos();

                        break;

                    case "0":
                        sairSistema();
                        break;
                    default:
                        tenteNovamente();
                        break;
                }

            } while (!VoltarMenu);

        }

        static void mostarMenu()
        {

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($@" 
    _______________________________
    ¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨                  
                 MENU
    ¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨           
    Escolha uma das opções abaixo: 
    ¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨ 
       C | Cadastrar produto   
       L | Listar produtos   
       0 | Sair        
    _______________________________
    ¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨   ");
        }

        static void cadastrarProduto()
        {
            do
            {
                if (i < tamanhoArrays)
                {

                    Console.WriteLine("\nInsira abaixo as informações do produto:");

                    Console.WriteLine($"Nome do {i + 1}º produto: ");
                    nomeProduto[i] = Console.ReadLine().ToLower();

                    Console.WriteLine($"\nPreço do {i + 1}º produto: ");
                    precoProduto[i] = float.Parse(Console.ReadLine());

                    Console.WriteLine($"\nDeseja adicionar que o {i + 1}º produto está em promoção? (1 | 2)\n(1 - sim | 2 - não)");
                    string promocaoProd = Console.ReadLine().ToLower();

                    if (promocaoProd == "1")
                    {
                        promocao[i] = true;

                    }
                    else
                    {
                        promocao[i] = false;
                    }


                    Console.WriteLine("\nDeseja cadastrar um novo produto? (s/n)");
                    string novoProduto = Console.ReadLine().ToLower();

                    if (novoProduto == "s")
                    {
                        novoCadastro = false;

                    }
                    else
                    {
                        novoCadastro = true;
                    }

                    i++;
                }
                else
                {
                    Console.WriteLine("\nO limite de cadastro de produtos foi excedido.");
                    novoCadastro = false;
                }

            } while (novoCadastro == false);
        }
        static void ListarProdutos()
        {
            for (var g = 0; g < i; g++)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine($@"
  __________________________________
  ¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨                     
      Lista do {g + 1}º produto:                      
  __________________________________
    Produto         {nomeProduto[g]}   
  ¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨
    Valor           {precoProduto[g].ToString("C")}
  ¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨
    Promoção        {(promocao[g] ? "SIM" : "NÃO")}
  __________________________________
  ¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨ ");

            }
        }

        static void sairSistema()
        {
            VoltarMenu = true;
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("\nVolte a nos visitar! Nossa plataforma estará esperando por você!\n\nVocê saiu do sistema.");
        }

        static void tenteNovamente()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("[Opção inválida] Tente novamente.");
        }

    }
}
