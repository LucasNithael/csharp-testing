using Features.Clientes;
using Xunit;

namespace Features.Testes._01___Traits
{
    // Collection Permite que todos os testes de uma coleção compartilhem o mesmo contexto de uma instancia de uma classe
    [CollectionDefinition(nameof(ClienteCollection))]
    public class ClienteCollection : ICollectionFixture<ClienteTestsFixture>
    {
    }
    public class ClienteTestsFixture : IDisposable
    {
        public Cliente GerarClienteValido()
        {
            var cliente = new Cliente(
                Guid.NewGuid(),
                "Fulano",
                "Ciclano",
                DateTime.Now.AddYears(-30),
                "fulado@email.com",
                true,
                DateTime.Now
                );

            return cliente;
        }

        public Cliente GerarClienteInvalido()
        {
            var cliente = new Cliente(
                Guid.NewGuid(),
                "",
                "",
                DateTime.Now.AddYears(-30),
                "fulado@email.com",
                true,
                DateTime.Now
                );

            return cliente;
        }
        public void Dispose()
        {
        }

    }
}
