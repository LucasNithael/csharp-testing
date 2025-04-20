using System;
using Bogus;
using Bogus.DataSets;
using Features.Clientes;
using Xunit;

namespace Features.Tests.DadosHumano
{
    [CollectionDefinition(nameof(ClienteCollection))]
    public class ClienteCollection : ICollectionFixture<ClienteTestsFixture>
    {}

    public class ClienteTestsFixture : IDisposable
    {
        public Cliente GerarClienteValido()
        {
            var faker    = new Faker("pt_BR");
            var genero   = faker.PickRandom<Name.Gender>();
            var name     = faker.Name.FirstName(genero);
            var lastName = faker.Name.LastName(genero);
            var email    = faker.Internet.Email(name, lastName);

            var cliente = new Cliente(
                Guid.NewGuid(),
                name,
                lastName,
                DateTime.Now.AddYears(-30),
                email,
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