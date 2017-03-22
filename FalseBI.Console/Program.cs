using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace FalseBI.ConsoleApp
{
    class Program
    {
        public static Random MyRandom = new Random();

        static void Main(string[] args)
        {
            int tecla = 0;
            var caminho = @"c:\\netflix\dados.txt";
            while (tecla != 9)
            {
                Console.Clear();
                Console.WriteLine("--------------------------");
                Console.WriteLine("----    NETFLIX BI    ----");
                Console.WriteLine("--------------------------");
                Console.WriteLine("1) Gerar Massa de dados Aleatória");
                Console.WriteLine("2) Tabelas");
                Console.WriteLine("9) Sair");

                int.TryParse(Console.ReadLine(), out tecla);
                Console.Clear();

                switch (tecla)
                {
                    case 1:
                        {
                            Console.Write("Digite a quantidade de registros: ");
                            var quantidade = int.Parse(Console.ReadLine());
                            Console.Write("\n");

                            Console.Write($"Digite o caminho de saída dos registros <{caminho}>: ");
                            var caminhoC = Console.ReadLine();
                            caminho = caminhoC == "" ? caminho : caminhoC;
                            Console.Write("\n");

                            var i = 0;

                            var lista = new List<EntidadeNetflix>();
                            while (i < quantidade)
                            {
                                var entidade = new EntidadeNetflix()
                                {
                                    Idade = MyRandom.Next(18, 80),
                                    IdCategoria = MyRandom.Next(1, 4),
                                    IdPais = MyRandom.Next(1, 4),
                                    IdVideo = MyRandom.Next(1, 4),
                                    TempoMedioDia = MyRandom.Next(1, 60),
                                };
                                lista.Add(entidade);
                                Console.WriteLine($"Idade:{entidade.Idade} | Categoria:{entidade.IdCategoria} | País:{entidade.IdPais} | Vídeo:{entidade.IdVideo} | Tempo:{entidade.TempoMedioDia.ToString().PadLeft(2, '0')} ms");
                                i++;
                            }
                            System.IO.Directory.CreateDirectory(System.IO.Path.GetDirectoryName(caminho));

                            File.WriteAllText(caminho, $"Netflix{System.Environment.NewLine}{System.Environment.NewLine}Idade,Categoria,País,Vídeo,Tempo{System.Environment.NewLine}");
                            File.AppendAllLines(caminho, lista.Select(q => $"{q.Idade},{q.IdCategoria},{q.IdPais},{q.IdVideo},{q.TempoMedioDia}").ToArray());
                            Console.ReadKey();
                            continue;
                        }
                    case 2:
                        {
                            Console.WriteLine("[TABELA]\n");
                            Console.WriteLine("1) Idade : (18 até 80)\n");
                            Console.WriteLine("2) Categoria : (1 até 4)");
                            Console.WriteLine("     [1 - Humor | 2 - Drama | 3 - Romance | 4 - Ação]\n");
                            Console.WriteLine("3) País:  (1 até 4)");
                            Console.WriteLine("     [1 - Brasil | 2 - França | 3 - Espanha | 4 - Cuba]\n");
                            Console.WriteLine("4) Vídeo:  (1 até 4)");
                            Console.WriteLine("     [1 - How I Met Your Mother | 2 - House | 3 - Chuck | 4 - Naruto]\n");
                            Console.WriteLine("5) Tempo Médio:  (1 até 60 minutos)");
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
}
