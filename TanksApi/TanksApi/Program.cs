using InstantAPIs;
using Microsoft.EntityFrameworkCore;
using TanksApi.Data.Dbcontexts;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<TankContext>(ops =>
    ops.UseSqlServer(builder.Configuration.GetConnectionString("Default")));

builder.Services.AddInstantAPIs();

var app = builder.Build();

app.MapInstantAPIs<TankContext>();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapGet("/", () =>
{

});


app.Run();


