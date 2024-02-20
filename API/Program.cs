using Data.Context;
using Microsoft.EntityFrameworkCore;
using API;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddTransient<Startup>();

var app = builder.Build();

app.UseRouting();

app.Run();