
var builder = WebApplication.CreateBuilder(args);
var connectionString  = builder.Configuration.GetConnectionString("DefaultConnection");

var config = builder.Configuration;

Console.WriteLine(connectionString);


var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();

