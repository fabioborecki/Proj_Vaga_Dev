using API.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Repository.Context;
using Repository;
using API;

var builder = WebApplication.CreateBuilder(args);



// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors(options =>
					options.AddPolicy("mypolicy", builder => builder
					.AllowAnyOrigin()
					.AllowAnyMethod()
					.AllowAnyHeader()
		//			.AllowCredentials())
					));

//builder.Services.AddSingleton<IConfiguration>();

builder.Services.AddDbContext<EFContext>(options =>
                                        options.UseMySql("Server=localhost; port = 3306; Database=localdb; uid = user;", ServerVersion.AutoDetect("Server=localhost; port = 3306; Database=localdb; uid = user;"),
                                        b => b.MigrationsAssembly("API")));
//builder.Services.AddDbContext<EFContext>(options => options.UseMySql(builder.Configuration.GetConnectionString("DefaultConnection"), new MySqlServerVersion(new Version())));


builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();

builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<ICategoryService, CategoryService>();




var app = builder.Build();



// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseCors(builder => builder
                              .AllowAnyMethod()
                              .AllowAnyHeader()
                              .AllowAnyOrigin());

}

app.UseHttpsRedirection();

app.UseCors(builder => builder
                              .AllowAnyMethod()
                              .AllowAnyHeader()
                              .AllowAnyOrigin());


app.UseAuthorization();

app.MapControllers();

app.Run();
