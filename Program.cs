var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
app.MapGet("/ready", () => Results.Text("dotnet-08f45801-ready"));
app.MapGet("/", () => Results.Json(new { @case = "dotnet-08f45801" }));
app.Run();
