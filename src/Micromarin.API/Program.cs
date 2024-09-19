using Micromarin.Core.Repositories;
using Micromarin.Core.Services;
using Micromarin.Core.UnitOfWork;
using Micromarin.Data;
using Micromarin.Data.Repositories;
using Micromarin.Service.Services;
using Microsoft.EntityFrameworkCore;
using System;

var builder = WebApplication.CreateBuilder(args);



builder.Services.AddControllers();

var enviromentName = builder.Environment.EnvironmentName;
builder.Configuration.AddJsonFile($"appsettings.{enviromentName}.json", optional: true);


builder.Services.AddScoped(typeof(IGenericService<,>), typeof(GenericService<,>));
builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

builder.Services.AddDbContext<GenericDbContext>(options =>
{
  options.UseSqlServer(builder.Configuration.GetConnectionString("SqlConnection"),
      sqlServerOptionsAction =>
      {
        sqlServerOptionsAction.MigrationsAssembly("Micromarin.Data");
      });
});



builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
  app.UseSwagger();
  app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
