using Moq;
using Features.Tests;
using Bogus;
using Bogus.DataSets;
using Features.Tests.DadosHumano;
using Features.Clientes;
using MediatR;
using Xunit;

namespace Features.Testes._05___Mock
{
    [Collection(nameof(ClienteCollection))]
    public class ClienteServiceTests(ClienteTestsFixture clienteTestsFixture)
    {
        private readonly ClienteTestsFixture _clienteTestsFixture = clienteTestsFixture;

        [Fact(DisplayName = "Adicionar novo cliente valido - 05")]
        public void ClienteService_Adicionar_DeveFalharDevidoClienteInvalido()
        {
            var cliente = _clienteTestsFixture.GerarClienteValido();
            var clienteRepo = new Mock<IClienteRepository>();
            var mediator = new Mock<IMediator>();

            var clienteService = new ClienteService(clienteRepo.Object, mediator.Object);
            clienteService.Adicionar(cliente);

            Assert.True(cliente.EhValido());
        }
    }
}
