using Microsoft.Extensions.Configuration;
using MongoDB.Driver;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


//var configuration = Configuration.GetSection("ConnectionStrings");
//var connectionString = configuration[s"MongoDBConnection"];


//// Register MongoDB client
//builder.Services.AddSingleton<IMongoClient>(new MongoClient(connectionString));
//// Register your data access classes
//builder.Services.AddTransient<IMongoDatabase, MongoContext>();
//builder.Services.AddTransient<IYourRepository, YourRepository>();


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
