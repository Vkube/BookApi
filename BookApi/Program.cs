using System.Linq;
using ApiControllers.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);
string connection = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<Librarydb>(options => options.UseSqlServer(connection));



var app = builder.Build();
app.UseDefaultFiles();
app.UseStaticFiles();

app.MapGet("/api/books", (Librarydb db)=>db.Books.ToList());

app.MapGet("api/books/{id}", (Librarydb db) =>
{

});

app.Run();