// Configura��o Builder 
var builder = WebApplication.CreateBuilder(args);

// Configura��ode Pipeline
// Middlewares 
// Services 

// Configura��ode da App

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
