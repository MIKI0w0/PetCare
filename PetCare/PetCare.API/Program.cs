using Microsoft.EntityFrameworkCore;
using PetCare.API.Models; // Cambia si tu namespace es diferente

var builder = WebApplication.CreateBuilder(args);

// Agregar el DbContext
builder.Services.AddDBContext<PetCareContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Add services to the container.
builder.Services.AddControllers();
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
