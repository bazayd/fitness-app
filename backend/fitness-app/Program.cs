using Microsoft.EntityFrameworkCore;
using FitnessTrackerAPI.Data; // Ensure this matches your actual namespace

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddDbContext<FitnessContext>(options =>
    options.UseMySql(builder.Configuration.GetConnectionString("DefaultConnection"),
                     new MySqlServerVersion(new Version(8, 3, 0))) // Replace with your MySQL version
);

// Add additional services as needed
var app = builder.Build();

app.MapControllers();
app.Run();
