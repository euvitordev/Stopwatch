using System;

namespace Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        
        static void Menu()
        {
            Console.Title = "Stopwatch - Beta 0.1";
            
            while (true)
            {
                Console.Clear();
                DesenharLinha(30, '+', '-');
                
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("> [Menu]");
                Console.WriteLine();
                Console.ResetColor();
            
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("  [1] - Timer");
                Console.ResetColor();
            
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("  [2] - Chronometer");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine();
                Console.WriteLine("  -----------");
                Console.WriteLine("  [0] - Sair");
                Console.ResetColor();
            
                DesenharLinha(30, '+', '-');
                
                Console.Write("> Digite uma opcao: ");
                var option = int.Parse(Console.ReadLine());

                switch (option)
                {
                  case 1:
                      Console.Clear();
                      Console.ForegroundColor = ConsoleColor.Green;
                      Console.WriteLine("[Iniciando aplicacao...]");
                      Console.ResetColor();
                      Thread.Sleep(1500);
                      StartTimer();
                      break;
                  case 2:
                      Console.Clear();
                      Console.ForegroundColor = ConsoleColor.Yellow;
                      Console.WriteLine("[Iniciando aplicacao...]");
                      Console.ResetColor();
                      Thread.Sleep(1500);
                      StartChronometer();
                      break;
                  case 0:
                      Console.Clear();
                      Console.ForegroundColor = ConsoleColor.Red;
                      Console.WriteLine("> Saindo do programa...");
                      Console.ResetColor();
                      Thread.Sleep(1500);
                      System.Environment.Exit(0);
                      break;
                  default:
                      Console.ForegroundColor = ConsoleColor.Red;
                      Console.WriteLine("> Opcao invalida.");
                      Console.ResetColor();
                      Thread.Sleep(1500);
                      Menu();
                      break;
                }
            }
        }
        
        static void DesenharLinha(int largura, char canto, char linha)
        {
            Console.WriteLine();
            Console.Write(canto);
            for (int i = 0; i < largura; i++)
                Console.Write(linha);
            Console.WriteLine(canto);
            Console.WriteLine();

        }
        static void StartTimer()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            DesenharLinha(30, '+', '-');
            Console.WriteLine("> [Timer]");
            Console.WriteLine();
            Console.WriteLine("  [V] - Voltar");
            Console.WriteLine("  [C] - Continuar");
            DesenharLinha(30, '+', '-');
            Console.ResetColor();
            
            Console.Write("> Digite uma opcao: ");
            var option = Console.ReadLine();

            if (option.ToUpper() == "V")
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("> Voltando...");
                Console.ResetColor();
                Thread.Sleep(1500);
                Menu();
            }
            
        }

        static void StartChronometer()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("> [Chronometer] - Em construcao...");
            Console.ResetColor();
            Thread.Sleep(1500);
            Menu();
        }
    }
}