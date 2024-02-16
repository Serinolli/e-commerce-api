using Data.Context;
using Microsoft.EntityFrameworkCore;
using API;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddTransient<Startup>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
