using System.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using TeoGarden.Data.EF;
using Microsoft.Extensions.Configuration;
using TeoGarden.Application.Interfaces;
using TeoGarden.Application.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: "CORS",
                      policy =>
                      {
                          policy.AllowAnyOrigin()
                          .AllowAnyMethod()
                          .AllowAnyHeader();
                      });
});

builder.Services.AddDbContext<TeoGardenDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Default")));

builder.Services.AddControllers();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "TeoGarden.Api", Version = "v1" });
});

//Declare DI
builder.Services.AddTransient<ICategoryService, CategoryService>(); 
builder.Services.AddTransient<IVegetableService, VegetableService>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "TeoGarden.BackendApi v1"));
}

app.UseCors("CORS"); 

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
