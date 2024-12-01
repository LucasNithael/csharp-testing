## Frameworks para Teste de Unidade
- [MSTest - Open Source](https://github.com/microsoft/testfx)
- [NUnit](https://nunit.org/)
- [XUnit - Open Source](https://xunit.net/)
### Como installar o xunit
  ```
  Install-Package xunit
  Install-Package xunit.runner.visualstudio
  ```

## Nomenclatura de Testes de Unidade
### Estruturas: 
- ```ObjetoEmTeste_MetodoComportamentoEmTeste_ComportamentoEsperado```
  - Pedido_AdicionarPedidoItem_DeveIncrementarUnidadesSeItemJaExistente
  - Estoque_RetirarItem_DeveEnviarEmailSeAbaixoDe10Unidades
- ```MetodoEmTeste_EstadoEmTeste_ComportamentoEsperado```
  - AdicionarPedidoItem_ItemExistenteCarrinho_DeveIncrementarUnidadesDoItem
 
## Framework de Mock
- Moq
```
Install-Package Moq
```    
