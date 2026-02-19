var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => MyWebApp.GreetingService.GetGreeting("World"));

app.Run();
