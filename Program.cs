// Configura��o Builder 
using static PorBaixoDosPanos.MeuMiddleware;

var builder = WebApplication.CreateBuilder(args);

// Configura��ode Pipeline
// Middlewares 
// Services 

// Configura��ode da App

var app = builder.Build();

app.UseMiddleware<LogTemplateMidlleware>();

app.MapGet("/", () =>
{
    Thread.Sleep(1500);
    return "Teste 2";
});

app.Run();
