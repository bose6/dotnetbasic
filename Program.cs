using lotus.ExternalServices.AdbContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Load MySQL configuration
var mysqlConfig = builder.Configuration.GetSection("MySQL");
string connectionString = $"Server={mysqlConfig["Url"]};Port={mysqlConfig["Port"]};Database={mysqlConfig["Database"]};User={mysqlConfig["User"]};Password={mysqlConfig["Password"]};";

// Add services
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure middleware
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();