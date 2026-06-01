using System;
using Xunit;
using FalseBI.ConsoleApp;

namespace FalseBI.Tests
{
    public class EntidadeNetflixTests
    {
        [Fact]
        public void EntidadeNetflix_ShouldHaveDefaultValues()
        {
            // Arrange & Act
            var entity = new EntidadeNetflix();
            
            // Assert
            Assert.Equal(0, entity.IdVideo);
            Assert.Equal(0, entity.IdPais);
            Assert.Equal(0, entity.IdCategoria);
            Assert.Equal(0, entity.Idade);
            Assert.Equal(0, entity.TempoMedioDia);
        }
        
        [Fact]
        public void EntidadeNetflix_ShouldSetAndGetProperties()
        {
            // Arrange
            var entity = new EntidadeNetflix();
            
            // Act
            entity.IdVideo = 1;
            entity.IdPais = 2;
            entity.IdCategoria = 3;
            entity.Idade = 25;
            entity.TempoMedioDia = 60;
            
            // Assert
            Assert.Equal(1, entity.IdVideo);
            Assert.Equal(2, entity.IdPais);
            Assert.Equal(3, entity.IdCategoria);
            Assert.Equal(25, entity.Idade);
            Assert.Equal(60, entity.TempoMedioDia);
        }
    }
}
