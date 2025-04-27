using System;
using System.Linq;
using EFCoreExample;
using Microsoft.EntityFrameworkCore;
using ProjectManagementAPI;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));



// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

using (var scope = app.Services.CreateScope())
{
    var context = scope.ServiceProvider.GetRequiredService<AppDbContext>();

    if (!context.customers.Any(s => s.Name == "John Doe"))
    {
        var customer = new Customer{ Name = "Shell BP" };
        context.customers.Add(customer);
        context.SaveChanges();
    }

    var query = context.customers.Where(s => s.Name == "John Doe");
    foreach (var stud in query)
    {
        Console.WriteLine($"Student: {stud.Name}");
    }
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
