using CoreGymApi;
using CoreGymApi.Entities;
using CoreGymApi.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOpenApi();
builder.Services.AddCors();
builder.Services.AddScoped<ISessionService, SessionService>();

var app = builder.Build();

app.MapOpenApi();
app.UseCors(c => c.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());
app.UseHttpsRedirection();



app.MapGet("/sessions", (ISessionService service) =>
{
    return service.GetSessions();
})
.WithName("GetTrainingSessions");



app.Run();
