using ExEtc.WebApi.Application.Apis;
using ExEtc.WebApi.Application.Strava.Settings;
using Refit;
using System.Net.Http.Headers;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRefitClient<IStravaApi>()
    .ConfigureHttpClient(c => {
        var settings = builder.Configuration.GetSection("Strava").Get<StravaApiSettings>();
        c.BaseAddress = new Uri("https://www.strava.com/api");
        c.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", settings.AccessToken);
    });
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
