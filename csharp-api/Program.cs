using csharp_api.Applications;
using csharp_api.Infrastructure;
using csharp_api.Infrastructure.Database;
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

var builder = WebApplication.CreateBuilder(args);

/*builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();*/
builder.Services.AddRouting(options => options.LowercaseUrls = true);

// Add services to the container.
builder.Services.AddServices();
builder.Services.AddRepositories();

builder.Services.AddControllers()
    .AddNewtonsoftJson(opt =>
    {
        opt.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
        opt.SerializerSettings.DateTimeZoneHandling = DateTimeZoneHandling.Local;
        opt.SerializerSettings.DefaultValueHandling = DefaultValueHandling.Include;
        opt.SerializerSettings.NullValueHandling = NullValueHandling.Ignore;
    })
    .AddControllersAsServices();



builder.Services.AddDbContext<CoreDbContext>(options =>
{
    string mySqlConnectionStr = builder.Configuration.GetConnectionString("Database");
    options.UseMySql(mySqlConnectionStr, ServerVersion.AutoDetect(mySqlConnectionStr));
}, ServiceLifetime.Transient);


var app = builder.Build();


app.UseRouting();
app.MapControllers();

app.Run();
