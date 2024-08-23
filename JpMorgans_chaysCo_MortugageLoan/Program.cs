using JpMorgans_chaysCo_MortugageLoan.BusinessEntities.Interfaces;
using JpMorgans_chaysCo_MortugageLoan.DataBaseLogic;
using JpMorgans_chaysCo_MortugageLoan.RepositoryLayer;
using JpMorgans_chaysCo_MortugageLoan.ServiceLayer;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IUserRegistrationRepository, UserRegistrationRepositores>();
builder.Services.AddScoped<IUserRegistrationServices,UserRegistrationServices>();
builder.Services.AddDbContext<HotelmanagementContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("CFAConnection")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
