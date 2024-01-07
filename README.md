# HelloWorldAPI

Este é um projeto de exemplo de uma API RESTful simples usando ASP.NET Core 8.0.

## Como Rodar

Certifique-se de ter o SDK do .NET 8.0 instalado. Você pode baixá-lo em [dotnet.microsoft.com](https://dotnet.microsoft.com/download/dotnet/8.0).

```bash
    git clone https://github.com/RyanFurt12/HelloWorldAPI.git
    cd HelloWorldAPI
    
    dotnet run
```
    
## Resposta

A aplicação estará disponível em http://localhost:5050 por padrão.

Acesse a API no navegador ou use uma ferramenta como curl ou Postman para fazer uma solicitação GET:

```bash
    curl http://localhost:5000
```
Você deve receber a seguinte resposta JSON:

```json
    {"mensagem": "Olá, Mundo!"}
```` 
