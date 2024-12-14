using Xunit;
using Features.Clientes;

namespace Features.Testes._01___Traits
{
    [Collection(nameof(ClienteCollection))]
    public class ClienteTesteValido
    {
        private readonly ClienteTestsFixture _clienteTestsFixture;

        public ClienteTesteValido(ClienteTestsFixture clienteTestsFixture)
        {
            _clienteTestsFixture = clienteTestsFixture;
        }

        [Fact(DisplayName = "Novo Cliente Válido 2")]
        [Trait("Categoria", "Cliente Trait Testes 2")]
        public void Cliente_NovoCliente_DeveEstarValido2()
        {
            // Arrange 
            var cliente = _clienteTestsFixture.GerarClienteValido();

            // Act
            var result = cliente.EhValido();

            // Assert
            Assert.True(result);
            Assert.Empty(cliente.ValidationResult.Errors);
        }
    }

    [Collection(nameof(ClienteCollection))]
    public class ClienteTesteInvalido
    {
        private readonly ClienteTestsFixture _clienteTestsFixture;

        public ClienteTesteInvalido(ClienteTestsFixture clienteTestsFixture)
        {
            _clienteTestsFixture = clienteTestsFixture;
        }

        [Fact(DisplayName = "Novo Cliente Inválido 2")]
        [Trait("Categoria", "Cliente Trait Testes 2")]
        public void Cliente_NovoCliente_DeveEstarInvalido2()
        {
            // Arrange 
            var cliente = _clienteTestsFixture.GerarClienteInvalido();

            // Act
            var result = cliente.EhValido();

            // Assert
            Assert.False(result);
            Assert.NotEmpty(cliente.ValidationResult.Errors);
        }
    }
}
