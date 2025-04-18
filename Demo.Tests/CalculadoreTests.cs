﻿using Xunit;

namespace Demo.Tests
{
    public class CalculadoreTests
    {

        [Fact]
        public void Calculadora_Somar_RetornarValorSoma()
        {
            // Arrange
            var calculadora = new Calculadora();
            // Act
            var resultado = calculadora.Somar(2, 2);
            //Assert
            Assert.Equal(4, resultado);
        }

        [Theory]  // permite que possa ser passado argumentos para os métodos de testes
        [InlineData(1, 1, 2)]
        [InlineData(2, 2, 4)]
        [InlineData(3, 2, 5)]
        public void Calculadora_Somar_RetornarValoresSomaCorretos(double v1, double v2, double total)
        {
            // Arrange
            var calculadora = new Calculadora();

            // Act
            var resultado = calculadora.Somar(v1, v2);

            // Assert
            Assert.Equal(total, resultado);
        }
    }
}