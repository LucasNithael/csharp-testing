using Xunit;

namespace Demo.Tests
{
    public class AssertObjectTypesTests
    {
        [Fact]
        public void FuncionarioFactory_Criar_DeveRetornarTipoFuncionario()
        {
            // Arrange & Act
            var funcionarioFactory = new FuncionarioFactory();

            var funcionario = funcionarioFactory.Criar("Lucas", 1000);

            // Assert
            Assert.IsType<Funcionario>(funcionario);
        }

        [Fact]
        public void FuncionarioFactory_Criar_DeveRetornarTipoDerivadoPessoa()
        {
            // Arrange & Act
            var funcionarioFactory = new FuncionarioFactory();

            var funcionario = funcionarioFactory.Criar("Lucas", 1000);

            // Assert
            Assert.IsAssignableFrom<Pessoa>(funcionario);
        }
    }
}
