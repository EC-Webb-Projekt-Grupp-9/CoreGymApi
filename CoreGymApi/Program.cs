using CoreGymApi.Entities;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOpenApi();

var app = builder.Build();

app.MapOpenApi();


app.UseHttpsRedirection();

var sessions = new List<Session>
{
    new Session
    {
        Id = Guid.NewGuid(),
        StartTime = DateTime.Now,
        Duration = 3,
        Title = "Spinning",
        Description = "",
        Trainer = "Ove Persson",
        Location = "Göteborg",
        Spots = 20
    },
    new Session
    {
        Id = Guid.NewGuid(),
        StartTime = DateTime.Now,
        Duration = 2,
        Title = "Aerobics",
        Description = "",
        Trainer = "Kent olsson",
        Location = "Halmstad",
        Spots = 20
    },
    new Session
    {
        Id = Guid.NewGuid(),
        StartTime = DateTime.Now,
        Duration = 3,
        Title = "Cross Fit",
        Description = "",
        Trainer = "Kalle Stenhård",
        Location = "Örebro",
        Spots = 20
    },
     new Session
    {
        Id = Guid.NewGuid(),
        StartTime = DateTime.Now.AddDays(1),
        Duration = 3,
        Title = "Spinning",
        Description = "",
        Trainer = "Ove Persson",
        Location = "Göteborg",
        Spots = 20
    },
    new Session
    {
        Id = Guid.NewGuid(),
        StartTime = DateTime.Now.AddDays(1),
        Duration = 2,
        Title = "Aerobics",
        Description = "",
        Trainer = "Kent olsson",
        Location = "Halmstad",
        Spots = 20
    },
    new Session
    {
        Id = Guid.NewGuid(),
        StartTime = DateTime.Now.AddDays(1),
        Duration = 3,
        Title = "Cross Fit",
        Description = "",
        Trainer = "Kalle Stenhård",
        Location = "Örebro",
        Spots = 20
    }
};


app.MapGet("/sessions", () =>
{
    return sessions;
})
.WithName("GetTrainingSessions");



app.Run();
