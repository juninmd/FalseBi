namespace FalseBI.ConsoleApp;

class Program
{
    public static Random MyRandom = new();

    static void Main(string[] args)
    {
        var caminho = @"c:\\netflix\dados.txt";
        int tecla = 0;

        while (tecla != 9)
        {
            Console.Clear();
            Console.WriteLine("--------------------------");
            Console.WriteLine("----    NETFLIX BI    ----");
            Console.WriteLine("--------------------------");
            Console.WriteLine("1) Gerar massa de dados aleatóriamente");
            Console.WriteLine("2) Tabelas");
            Console.WriteLine("\n\n9) Sair");

            int.TryParse(Console.ReadLine(), out tecla);
            Console.Clear();

            switch (tecla)
            {
                case 1:
                    {
                        Console.Write("Digite a quantidade de registros: ");
                        var quantidade = 0;
                        int.TryParse(Console.ReadLine(), out quantidade);

                        while (quantidade == 0)
                        {
                            Console.Write("Por favor, digite uma quantidade superior a 0: ");
                            int.TryParse(Console.ReadLine(), out quantidade);
                        }

                        Console.Write("\n");

                        Console.Write($"Digite o caminho de saída dos registros <{caminho}>: ");
                        var caminhoC = Console.ReadLine();
                        caminho = caminhoC == "" ? caminho : caminhoC;
                        Console.Write("\n");

                        var lista = DataGenerationService.GenerateRandomData(MyRandom, quantidade);

                        foreach (var entidade in lista)
                        {
                            Console.WriteLine(DataGenerationService.FormatEntry(entidade));
                        }

                        Directory.CreateDirectory(Path.GetDirectoryName(caminho)!);

                        File.WriteAllText(caminho, DataGenerationService.FormatCsvHeader());
                        File.AppendAllLines(caminho, DataGenerationService.FormatCsvLines(lista));
                        Console.ReadKey();
                        continue;
                    }
                case 2:
                    {
                        Console.WriteLine("================================");
                        Console.WriteLine("----     TABELA de Ranges   ----");
                        Console.WriteLine("================================\n");
                        Console.WriteLine("1) Idade : (18 | 25 | 30 | 50) anos\n");
                        Console.WriteLine("2) Categoria : (1 até 4)");
                        Console.WriteLine("     [1 - Humor | 2 - Drama | 3 - Romance | 4 - Ação]\n");
                        Console.WriteLine("3) País:  (1 até 4)");
                        Console.WriteLine("     [1 - Brasil | 2 - França | 3 - Espanha | 4 - Cuba]\n");
                        Console.WriteLine("4) Vídeo:  (1 até 4)");
                        Console.WriteLine("     [1 - How I Met Your Mother | 2 - House | 3 - Chuck | 4 - Naruto]\n");
                        Console.WriteLine("5) Tempo Médio de Visualização: (20 | 40 | 60 | 120) minutos");
                        Console.ReadKey();
                        continue;
                    }
                case 9:
                    {
                        break;
                    }
                default:
                    {
                        Console.Write("Por favor digite uma opção válida :)");
                        Console.ReadKey();
                        continue;
                    }
            }
        }
    }
}
