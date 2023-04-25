
using Microsoft.EntityFrameworkCore;
using Data;
using Business.Interface;
using Business.Implementation;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
// Update Parameters for the Current Project !
builder.Services.AddDbContext<DatabaseContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"),b=>b.MigrationsAssembly("FleetManagementSystem")));

// Providing Implementation of Managers as Service

builder.Services.AddScoped<IBookingManager, BookingManager>();
builder.Services.AddScoped<ICustomerManager, CustomerManager>();
builder.Services.AddScoped<IInventoryManager, InventoryManager>();
builder.Services.AddScoped<IMaintenanceManager, MaintenanceManager>();
builder.Services.AddScoped<IPaymentManager, PaymentManager>();
builder.Services.AddScoped<IStaffManager, StaffManager>();
builder.Services.AddScoped<IVehicleManager, VehicleManager>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors(builder => builder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());

app.UseAuthorization();

app.MapControllers();

app.Run();
