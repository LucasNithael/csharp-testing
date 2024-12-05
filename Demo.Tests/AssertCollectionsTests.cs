

using Xunit;

namespace Demo.Tests
{
    public class AssertCollectionsTests
    {
        [Fact]
        public void Funcionario_Habilidades_NaoDevePossuirHabilidadesVazias()
        {
            // Arrange & Act
            var funcionario = new Funcionario("Lucas", 1000);

            // Assert
            Assert.All(funcionario.Habilidades, habilidade => Assert.False(string.IsNullOrEmpty(habilidade)));
        }

        [Fact]
        public void Funcionario_Habilidades_JuniorDevePossuirHabilidadeBasica()
        {
            // Arrange & Act
            var funcionario = new Funcionario("Lucas", 1000);

            // Assert
            Assert.Contains("OOP", funcionario.Habilidades);
            Assert.Contains("Lógica de Programação", funcionario.Habilidades);
        }

        [Fact]
        public void Funcionario_Habilidades_JuniorNaoDevePossuirHabilidadeAvancada()
        {
            // Arrange & Act
            var funcionario = new Funcionario("Lucas", 1000);

            // Assert
            Assert.DoesNotContain("Microservices", funcionario.Habilidades);
            Assert.DoesNotContain("Testes", funcionario.Habilidades);

        }

        [Fact]
        public void Funcionario_Habilidades_SeniorDevePossuirTodasHabilidades()
        {
            // Arrange & Act
            var funcionario = new Funcionario("Lucas", 8000);

            var habilidadesSenior = new[]
            {
                "Lógica de Programação",
                "OOP",
                "Testes",
                "Microservices"
            };

            // Assert
            Assert.Equal(habilidadesSenior, funcionario.Habilidades);
        }
    }
}
