# itiDigital

## API Teste Password

## Arquitetura

Para essa API, foi adotado um padrão simplificado, considerando baixa complexidade de negócio e ausência de contextos/ domínios ricos.
Foi separanda responsabilidades nos projetos:

- itidigital.API
- itidigital.Services
- itidigital.Tests.Unit
- itidigital.Tests.Integration

Para fins de desacoplamento, utilizado injeção de dependência para camada de serviço.
Não foram contemplados itens de autenticação como JWT por exemplo.
Os Testes foram separados em projetos diferentes e para o teste de integração necessario executar o projeto API.

## Instalação

#### API

Diretório: itidigital-test\itidigital.API

```
dotnet run
```

O serviço será executado na porta 5001. Swagger pode ser acessado para visualizar detalhes das rotas.

```
https://localhost:5001/swagger
```

### Testes Unidade

Diretório: itidigital.Tests.Unit

```
dotnet test
```

### Testes Integração

Diretório: itidigital.Tests.Integration

```
dotnet test
```
