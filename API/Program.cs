using Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

#region Config
ConfigurationManager config = builder.Configuration;
builder.Services.AddSingleton(sg => config);
#endregion

#region Database
builder.Services.AddDbContext<MovixContext>(options => options.UseNpgsql(config.GetConnectionString("Local")), ServiceLifetime.Transient);
#endregion

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.Run();