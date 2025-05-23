using bl.Api;
using bl.Models;
using bl.Services;
using dal.Api;
using dal.Models;
using dal.Services;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

// Add Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//עדכון שירותים
builder.Services.AddScoped<IBLProjectService, ProjectBl>();
builder.Services.AddScoped<IBLTaskService,TaskBL>();
builder.Services.AddScoped<IBlWorkerService, WorkerBl>();
builder.Services.AddScoped<IProjectDalService, ProjectDal>();
builder.Services.AddScoped<IWorkerDalService, WorkerDal>();
builder.Services.AddScoped<ITaskDALService, TaskDAL>();
builder.Services.AddScoped<dbClass>();






var app = builder.Build();

// Configuration for development environments
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// General application configuration
app.UseHttpsRedirection();
app.UseCors("AllowAllOrigins"); // Enable CORS
app.UseAuthorization();
app.MapControllers();

app.Run();