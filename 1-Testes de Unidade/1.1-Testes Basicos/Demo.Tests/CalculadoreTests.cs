using Xunit;
using Calculadora;

namespace Demo.Tests
{
    public class CalculadoreTests{
        
        [Fact]
        public void Calculadora_Somar_RetornarValorSoma(){
            // Arrange
            var calculadora = new Calculadora();
            // Act
            var resultado = calculadora.Somar(2,2);
            //Assert
            Assert.Equal(4, resultado);
        }
    }
}