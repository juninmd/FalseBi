using FalseBI.ConsoleApp;

namespace FalseBI.Tests;

public class EntidadeNetflixTests
{
    [Fact]
    public void EntidadeNetflix_DefaultProperties_AreZero()
    {
        var entidade = new EntidadeNetflix();
        Assert.Equal(0, entidade.IdVideo);
        Assert.Equal(0, entidade.IdPais);
        Assert.Equal(0, entidade.IdCategoria);
        Assert.Equal(0, entidade.Idade);
        Assert.Equal(0, entidade.TempoMedioDia);
    }

    [Fact]
    public void EntidadeNetflix_CanSetAndGetAllProperties()
    {
        var entidade = new EntidadeNetflix
        {
            IdVideo = 1,
            IdPais = 2,
            IdCategoria = 3,
            Idade = 25,
            TempoMedioDia = 60,
        };

        Assert.Equal(1, entidade.IdVideo);
        Assert.Equal(2, entidade.IdPais);
        Assert.Equal(3, entidade.IdCategoria);
        Assert.Equal(25, entidade.Idade);
        Assert.Equal(60, entidade.TempoMedioDia);
    }

    [Fact]
    public void EntidadeNetflix_CanSetPropertiesIndependently()
    {
        var entidade = new EntidadeNetflix();
        entidade.IdVideo = 4;
        entidade.IdPais = 3;
        entidade.IdCategoria = 2;
        entidade.Idade = 50;
        entidade.TempoMedioDia = 120;

        Assert.Equal(4, entidade.IdVideo);
        Assert.Equal(3, entidade.IdPais);
        Assert.Equal(2, entidade.IdCategoria);
        Assert.Equal(50, entidade.Idade);
        Assert.Equal(120, entidade.TempoMedioDia);
    }

    [Theory]
    [InlineData(18)]
    [InlineData(25)]
    [InlineData(30)]
    [InlineData(50)]
    public void EntidadeNetflix_Idade_AcceptsValidValues(int idade)
    {
        var entidade = new EntidadeNetflix { Idade = idade };
        Assert.Equal(idade, entidade.Idade);
    }

    [Theory]
    [InlineData(20)]
    [InlineData(40)]
    [InlineData(60)]
    [InlineData(120)]
    public void EntidadeNetflix_TempoMedioDia_AcceptsValidValues(int tempo)
    {
        var entidade = new EntidadeNetflix { TempoMedioDia = tempo };
        Assert.Equal(tempo, entidade.TempoMedioDia);
    }
}
