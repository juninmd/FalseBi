namespace FalseBI.ConsoleApp;

public static class DataGenerationService
{
    public static EntidadeNetflix GenerateRandomEntry(Random random)
    {
        var tempo = random.Next(1, 5);
        var idade = random.Next(1, 5);
        return new EntidadeNetflix
        {
            Idade = MapIdade(idade),
            IdCategoria = random.Next(1, 5),
            IdPais = random.Next(1, 5),
            IdVideo = random.Next(1, 5),
            TempoMedioDia = MapTempo(tempo),
        };
    }

    public static List<EntidadeNetflix> GenerateRandomData(Random random, int count)
    {
        var lista = new List<EntidadeNetflix>();
        for (var i = 0; i < count; i++)
        {
            lista.Add(GenerateRandomEntry(random));
        }
        return lista;
    }

    public static int MapIdade(int value)
    {
        return value switch
        {
            1 => 18,
            2 => 25,
            3 => 30,
            _ => 50,
        };
    }

    public static int MapTempo(int value)
    {
        return value switch
        {
            1 => 20,
            2 => 40,
            3 => 60,
            _ => 120,
        };
    }

    public static string FormatEntry(EntidadeNetflix entry)
    {
        return $"Idade:{entry.Idade} | Categoria:{entry.IdCategoria} | País:{entry.IdPais} | Vídeo:{entry.IdVideo} | Tempo:{entry.TempoMedioDia.ToString().PadLeft(2, '0')} ms";
    }

    public static string FormatCsvHeader()
    {
        return $"Netflix{Environment.NewLine}{Environment.NewLine}Idade,Categoria,País,Vídeo,Tempo{Environment.NewLine}";
    }

    public static string[] FormatCsvLines(List<EntidadeNetflix> entries)
    {
        return entries
            .Select(e => $"{e.Idade},{e.IdCategoria},{e.IdPais},{e.IdVideo},{e.TempoMedioDia}")
            .ToArray();
    }
}
