using Microsoft.EntityFrameworkCore;
using Persistence.Data;
using Services.ClassServices;
using Services.InterfaceService;
using Services.ServiceProfile;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IEmployeeService, EmployeeService>();
builder.Services.AddScoped<IDepartmentService,DepartmentService>();
builder.Services.AddScoped<IRegionService,RegionService>();
builder.Services.AddScoped<ICountrieService,CountrieService>();
builder.Services.AddScoped<ILocationService,LocationService>();
builder.Services.AddScoped<IJobService,JobService>();
// Add services to the container.
// get connection string from appsettings.json
string connection = builder.Configuration.GetConnectionString("DefaultConnection");


// Add DataContext in DI injection
builder.Services.AddDbContext<DataContext>(options => options.UseNpgsql(connection));


builder.Services.AddAutoMapper(typeof(ServiceProfile));
builder.Services.AddControllers();
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

app.UseAuthorization();

app.MapControllers();

app.Run();
