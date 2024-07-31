using BaseProject.Application;
using BaseProject.Infrastructure;
using BaseProject.Persistence;
using NLLogistics.Application;
using NLLogistics.Persistence;
using Serilog;
using Serilog.Context;
using Utilities.Infrastructure.UtilityInfrastructure;
using Utilities.Infrastructure.UtilityInfrastructure.Services.Storage.Local;
using Utilities.Presentation.UtilityApi.Middleware;
using Utilities.Presentation.UtilityApi.Middleware.GlobalException;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddBaseProjectPersistenceServices();
builder.Services.AddBaseProjectApplicationServices();
builder.Services.AddBaseProjectInfrastructureServices();
builder.Services.AddUtilityInfrastructureServices();
builder.Services.AddStroage<LocalStorage>();
builder.Services.AddNLLogisticsApplicationServices();
builder.Services.AddNLLogisticsPersistenceServices();

var corsUrls = builder.Configuration.GetSection("CorsPolicy:Urls").Get<string[]>();
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(
        builder =>
        {
            builder.WithOrigins(corsUrls)
                    .AllowAnyHeader()
                    .AllowAnyMethod()
                    .AllowCredentials();
        });
});

var logger = SerilogExtension.CreateLogger(builder.Configuration);
builder.Host.UseSerilog(logger);
builder.Services.AddCustomHttpLogging();
// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.ConfigureSwaggerCustom();
builder.Services.AddCustomJwtAuthentication(builder.Configuration);

builder.Services.AddRouting(options => options.LowercaseUrls = true);


var app = builder.Build();

// Configure the HTTP request pipeline.
var basedbName = builder.Configuration.GetSection("ConnectionStrings:BaseProjectDatabase");
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", $"{basedbName.Value}_BaseProject API");
    c.RoutePrefix = string.Empty;
});

app.UseStaticFiles();

app.UseSerilogRequestLogging();

app.UseCors();

app.UseDeveloperExceptionPage();


app.UseHttpsRedirection();
app.UseErrorWrappingMiddleware();
app.UseAuthentication();
app.UseAuthorization();

app.Use(async (context, next) =>
{
    var userName = context.User?.Identity?.IsAuthenticated != null || true ? context.User.Identity.Name : null;
    LogContext.PushProperty("CreatedBy", userName);
    await next();
});

app.MapControllers();

app.Run();
