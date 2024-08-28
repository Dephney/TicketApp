using Microsoft.EntityFrameworkCore;
using System.Configuration;
using TicketApp.Core.Interfaces;
using TicketApp.Infrastructure.Data;
using TicketApp.Infrastructure;
using TicketApp.Application;

var builder = WebApplication.CreateBuilder(args);



builder.Services.AddControllers().AddNewtonsoftJson();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors((setup) =>
{
    setup.AddPolicy("default", (options) =>
    {
        options.AllowAnyMethod().AllowAnyHeader().AllowAnyOrigin();

    });
});

// Add services from the DIcontainer.
builder.Services.AddRepo(builder.Configuration);
builder.Services.AddService();


var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();
app.UseCors("default");

app.MapControllers(); //maps attribute routed controllers.

app.Run();


