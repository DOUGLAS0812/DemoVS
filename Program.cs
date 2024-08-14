// Configuração Builder 
var builder = WebApplication.CreateBuilder(args);

// Configuraçãode Pipeline
// Middlewares 
// Services 

// Configuraçãode da App

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
