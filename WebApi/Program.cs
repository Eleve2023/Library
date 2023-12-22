using Infrastructure.Data;
using Application;
using Domain.Interfaces;
using WebApi.Services;
using Application.Dtos.Ouvrages;
using Application.Dtos.LibraryManagement;
using Application.Dtos.LibraryManagement.Borrowings;
using Application.Dtos.Persons;
using WebApi.MinimalApi;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var connectionString = builder.Configuration.GetConnectionString("AppLibraryConnection") ?? throw new InvalidOperationException("Connection string 'AppLibraryConnection' not found.");
builder.Services.AddApplicationDbContext(connectionString);

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IWorkTypeRepository<WorkTypeDto>, WorkTypeRepository>();
builder.Services.AddScoped<IWorkDomainRepository<WorkDomainDto>, WorkDomainRepository>();
builder.Services.AddScoped<IWorkDomainRepository<WorkDomainDto>, WorkDomainRepository>();
builder.Services.AddScoped<IWorkRepository<WorkDto>, WorkRepository>();
builder.Services.AddScoped<ILibraryCardRepository<LibraryCardDto>, LibraryCardRepository>();
builder.Services.AddScoped<IBorrowingRepository<BorrowingDto>, BorrowingRepository>();
builder.Services.AddScoped<IBorrowingAlertViewRepository<BorrowingAlertViewDto>, BorrowingAlertViewRepository>();
builder.Services.AddScoped<IBorrowRuleRepository<BorrowRuleDto>, BorrowRuleRepository>();
builder.Services.AddScoped<IPersonRepository<PersonDto>, PersonRepository>();
builder.Services.AddApplicationServices();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapAlerts();

app.MapControllers();

app.Run();
