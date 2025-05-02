using System;
using System.Linq;
using EFCoreExample;
using Microsoft.EntityFrameworkCore;
using ProjectManagementAPI;
using ProjectManagment.Data.Enteties;
using ProjectManagement.ServiceLibrary.DataAccess;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"),
        sqlOptions => sqlOptions.EnableRetryOnFailure()));

// Registrer repository-implementeringen i DI
builder.Services.AddScoped<ICustomerRepositoryInterface, CustomerRepository>();

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowReactDev", policy =>
    {
        policy.WithOrigins("http://localhost:3000")
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});


var app = builder.Build();
app.UseCors("AllowReactDev");


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

using (var scope = app.Services.CreateScope())
{
    var context = scope.ServiceProvider.GetRequiredService<AppDbContext>();

    var customers = await context.customers.ToListAsync();

    //context.customers.Add(new Customer { name = "bjørk", employee_id = 2 }) ;
    //await context.SaveChangesAsync();

    foreach (var customer in customers)
    {
        Console.WriteLine($"ID: {customer.id}, Name: {customer.name}, Customer_Since: {customer.customer_since}");
    }

 
}



app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
