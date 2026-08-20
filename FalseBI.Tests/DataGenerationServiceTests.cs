using FalseBI.ConsoleApp;

namespace FalseBI.Tests;

public class DataGenerationServiceTests
{
    [Fact]
    public void MapIdade_Returns18_WhenInputIs1()
    {
        Assert.Equal(18, DataGenerationService.MapIdade(1));
    }

    [Fact]
    public void MapIdade_Returns25_WhenInputIs2()
    {
        Assert.Equal(25, DataGenerationService.MapIdade(2));
    }

    [Fact]
    public void MapIdade_Returns30_WhenInputIs3()
    {
        Assert.Equal(30, DataGenerationService.MapIdade(3));
    }

    [Fact]
    public void MapIdade_Returns50_WhenInputIsOutOfRange()
    {
        Assert.Equal(50, DataGenerationService.MapIdade(0));
        Assert.Equal(50, DataGenerationService.MapIdade(4));
        Assert.Equal(50, DataGenerationService.MapIdade(-1));
    }

    [Fact]
    public void MapTempo_Returns20_WhenInputIs1()
    {
        Assert.Equal(20, DataGenerationService.MapTempo(1));
    }

    [Fact]
    public void MapTempo_Returns40_WhenInputIs2()
    {
        Assert.Equal(40, DataGenerationService.MapTempo(2));
    }

    [Fact]
    public void MapTempo_Returns60_WhenInputIs3()
    {
        Assert.Equal(60, DataGenerationService.MapTempo(3));
    }

    [Fact]
    public void MapTempo_Returns120_WhenInputIsOutOfRange()
    {
        Assert.Equal(120, DataGenerationService.MapTempo(0));
        Assert.Equal(120, DataGenerationService.MapTempo(4));
        Assert.Equal(120, DataGenerationService.MapTempo(-5));
    }

    [Theory]
    [InlineData(0)]
    [InlineData(1)]
    [InlineData(5)]
    [InlineData(100)]
    public void GenerateRandomData_ReturnsCorrectCount(int count)
    {
        var random = new Random(42);
        var result = DataGenerationService.GenerateRandomData(random, count);
        Assert.Equal(count, result.Count);
    }

    [Fact]
    public void GenerateRandomData_ReturnsEmptyList_WhenCountIsZero()
    {
        var random = new Random(42);
        var result = DataGenerationService.GenerateRandomData(random, 0);
        Assert.Empty(result);
    }

    [Fact]
    public void GenerateRandomEntry_ReturnsValidAge()
    {
        var random = new Random(42);
        var validAges = new[] { 18, 25, 30, 50 };

        for (var i = 0; i < 100; i++)
        {
            var entry = DataGenerationService.GenerateRandomEntry(random);
            Assert.Contains(entry.Idade, validAges);
        }
    }

    [Fact]
    public void GenerateRandomEntry_ReturnsValidCategoria()
    {
        var random = new Random(42);

        for (var i = 0; i < 100; i++)
        {
            var entry = DataGenerationService.GenerateRandomEntry(random);
            Assert.InRange(entry.IdCategoria, 1, 4);
        }
    }

    [Fact]
    public void GenerateRandomEntry_ReturnsValidPais()
    {
        var random = new Random(42);

        for (var i = 0; i < 100; i++)
        {
            var entry = DataGenerationService.GenerateRandomEntry(random);
            Assert.InRange(entry.IdPais, 1, 4);
        }
    }

    [Fact]
    public void GenerateRandomEntry_ReturnsValidVideo()
    {
        var random = new Random(42);

        for (var i = 0; i < 100; i++)
        {
            var entry = DataGenerationService.GenerateRandomEntry(random);
            Assert.InRange(entry.IdVideo, 1, 4);
        }
    }

    [Fact]
    public void GenerateRandomEntry_ReturnsValidTempoMedioDia()
    {
        var random = new Random(42);
        var validTempos = new[] { 20, 40, 60, 120 };

        for (var i = 0; i < 100; i++)
        {
            var entry = DataGenerationService.GenerateRandomEntry(random);
            Assert.Contains(entry.TempoMedioDia, validTempos);
        }
    }

    [Fact]
    public void GenerateRandomData_ProducesDifferentResults_WithDifferentSeeds()
    {
        var random1 = new Random(42);
        var random2 = new Random(99);

        var result1 = DataGenerationService.GenerateRandomData(random1, 10);
        var result2 = DataGenerationService.GenerateRandomData(random2, 10);

        var anyDifferent = false;
        for (var i = 0; i < 10; i++)
        {
            if (result1[i].Idade != result2[i].Idade ||
                result1[i].IdCategoria != result2[i].IdCategoria ||
                result1[i].TempoMedioDia != result2[i].TempoMedioDia)
            {
                anyDifferent = true;
                break;
            }
        }

        Assert.True(anyDifferent, "Different seeds should produce different data");
    }

    [Fact]
    public void FormatEntry_ReturnsCorrectFormat()
    {
        var entry = new EntidadeNetflix
        {
            Idade = 18,
            IdCategoria = 1,
            IdPais = 1,
            IdVideo = 1,
            TempoMedioDia = 20,
        };

        var result = DataGenerationService.FormatEntry(entry);
        Assert.Equal("Idade:18 | Categoria:1 | País:1 | Vídeo:1 | Tempo:20 ms", result);
    }

    [Fact]
    public void FormatEntry_PadsTempoWithLeadingZero()
    {
        var entry = new EntidadeNetflix
        {
            Idade = 18,
            IdCategoria = 1,
            IdPais = 1,
            IdVideo = 1,
            TempoMedioDia = 20,
        };

        var result = DataGenerationService.FormatEntry(entry);
        Assert.Contains("Tempo:20 ms", result);
    }

    [Fact]
    public void FormatCsvHeader_ContainsNetflixHeader()
    {
        var result = DataGenerationService.FormatCsvHeader();
        Assert.Contains("Netflix", result);
    }

    [Fact]
    public void FormatCsvHeader_ContainsColumnHeaders()
    {
        var result = DataGenerationService.FormatCsvHeader();
        Assert.Contains("Idade,Categoria,País,Vídeo,Tempo", result);
    }

    [Fact]
    public void FormatCsvLines_ReturnsCorrectNumberOfLines()
    {
        var entries = new List<EntidadeNetflix>
        {
            new() { Idade = 18, IdCategoria = 1, IdPais = 1, IdVideo = 1, TempoMedioDia = 20 },
            new() { Idade = 25, IdCategoria = 2, IdPais = 2, IdVideo = 2, TempoMedioDia = 40 },
        };

        var result = DataGenerationService.FormatCsvLines(entries);
        Assert.Equal(2, result.Length);
    }

    [Fact]
    public void FormatCsvLines_ContainsCommaSeparatedValues()
    {
        var entries = new List<EntidadeNetflix>
        {
            new() { Idade = 18, IdCategoria = 1, IdPais = 1, IdVideo = 1, TempoMedioDia = 20 },
        };

        var result = DataGenerationService.FormatCsvLines(entries);
        Assert.Equal("18,1,1,1,20", result[0]);
    }

    [Fact]
    public void FormatCsvLines_ReturnsEmptyArray_WhenNoEntries()
    {
        var result = DataGenerationService.FormatCsvLines(new List<EntidadeNetflix>());
        Assert.Empty(result);
    }
}
