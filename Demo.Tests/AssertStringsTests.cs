using Xunit;

namespace Demo.Tests
{
    public class AssertStringsTests
    {
        [Fact]
        public void StringsTools_UnirNomes_RetornarNomeCompleto()
        {
            // Arrange
            var stringsTools = new StringsTools();

            // Act
            var nomeCompleto = stringsTools.Unir("Lucas", "Nithael");

            // Assert
            Assert.Equal("Lucas Nithael", nomeCompleto);
        }

        [Fact]
        public void StringsTools_UnirNomes_DeveIgnorarCase()
        {
            // Arrange
            var stringsTools = new StringsTools();

            // Act
            var nomeCompleto = stringsTools.Unir("lucas", "nithael");

            // Assert
            Assert.Equal("Lucas Nithael", nomeCompleto, ignoreCase: true);
        }

        [Fact]
        public void StringsTools_UnirNomes_DeveConterTrecho()
        {
            // Arrange
            var stringsTools = new StringsTools();

            // Act
            var nomeCompleto = stringsTools.Unir("Lucas", "Nithael");

            // Assert
            Assert.Contains("uca", nomeCompleto);
        }

        [Fact]
        public void StringsTools_UnirNomes_DeveComecarCom()
        {
            // Arrange
            var stringsTools = new StringsTools();

            // Act
            var nomeCompleto = stringsTools.Unir("Lucas", "Nithael");

            // Assert
            Assert.StartsWith("Luc", nomeCompleto);
        }

        [Fact]
        public void StringsTools_UnirNomes_DeveTerminarCom()
        {
            // Arrange
            var stringsTools = new StringsTools();

            // Act
            var nomeCompleto = stringsTools.Unir("Lucas", "Nithael");

            // Assert
            Assert.EndsWith("ael", nomeCompleto);
        }

        [Fact]
        public void StringsTools_UnirNomes_ValidarExpressaoRegular()
        {
            // Arrange
            var stringsTools = new StringsTools();

            // Act
            var nomeCompleto = stringsTools.Unir("Lucas", "Nithael");

            // Assert
            Assert.Matches("[A-Z]{1}[a-z]+ [A-Z]{1}[a-z]+", nomeCompleto);
        }
    }
}
