
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();


builder.Services.AddSingleton<IWorkerDal, WorkerDal>();

builder.Host.UseSerilog();
var app = builder.Build();
app.UseExceptionHandler("/Errors");

app.MapControllers();
app.Run();
