using GridPlanner.Library;
using GridPlanner.Library.DataAccess;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c=>c.SwaggerDoc("v1", new OpenApiInfo()
{
    Title = "50Hertz Gridplanner",
    Version = "v1"
}));

builder.Services.AddScoped<IDataAccess, DataAccess>();
builder.Services.AddScoped<ILoginDataAccess, LoginDataAccess>();
builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(LibraryEntrypoint).Assembly));
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseCors(x => x.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod().SetIsOriginAllowed(origin => true));
app.UseAuthorization();

app.MapControllers();

app.Run();