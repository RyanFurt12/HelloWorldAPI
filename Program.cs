var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => new { mensagem = "Olá, Mundo!" });

app.Run();
