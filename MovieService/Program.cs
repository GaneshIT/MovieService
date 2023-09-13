using Microsoft.EntityFrameworkCore;
using MovieEntity;
using MovieEntity.Repositories;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var sqlconnection = builder.Configuration.GetConnectionString("sqlconnection");
var logger = new LoggerConfiguration()
    .ReadFrom.Configuration(builder.Configuration)
    .Enrich.FromLogContext()
    .CreateLogger();
builder.Logging.AddSerilog(logger);

builder.Services.AddControllers();
builder.Services.AddDbContext<MovieDbContext>(options => options.UseSqlServer(sqlconnection));
builder.Services.AddScoped<IMovieRepository, MovieRepository>(); ;

builder.Services.AddScoped<IBookingRepo, BookingRepo>();
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
app.UseCors(x =>
x.AllowAnyHeader()
.AllowAnyMethod()
.WithOrigins("http://localhost:3000"));
app.UseAuthorization();

app.MapControllers();

app.Run();
