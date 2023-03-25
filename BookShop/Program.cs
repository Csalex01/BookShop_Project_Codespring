using BookShopV2.Infrastructure.Repositories;
using BookShopV2.Application.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using BookShopV2.Application.Interfaces.Services;
using BookShopV2.Application.Services;
using BookShopV2.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

// Dependency injection -> Repositories
builder.Services.AddScoped<IBookRepository, BookRepository>();
builder.Services.AddScoped<IAuthorRepository, AuthorRepository>();

// Dependency injetion -> Services
builder.Services.AddScoped<IBookService, BookService>();
builder.Services.AddScoped<IAuthorService, AuthorService>();

builder.Services.AddDbContext<BookShopContext>(options => options.UseNpgsql(builder.Configuration.GetConnectionString("BookShop")));

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

app.UseHttpsRedirection();

app.MapControllers();

app.Run();
