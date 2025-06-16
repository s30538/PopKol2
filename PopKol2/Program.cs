using Microsoft.EntityFrameworkCore;
using PopKol2.Data;
using PopKol2.Services;

var builder = WebApplication.CreateBuilder(args);
// Add services to the container.
builder.Services.AddControllers().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.ReferenceHandler = System.Text.Json.Serialization.ReferenceHandler.Preserve;
    options.JsonSerializerOptions.WriteIndented = true;
});


builder.Services.AddDbContext<DatabaseContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Default"))
);

// https://learn.microsoft.com/en-us/dotnet/core/extensions/dependency-injection
builder.Services.AddScoped<IDbService, DbService>();
/*builder.Services.AddScoped<IPatientService, PatientService>();*/
var app = builder.Build();
// Configure the HTTP request pipeline.
app.UseAuthorization();
app.MapControllers();
app.Run();