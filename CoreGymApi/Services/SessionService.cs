using CoreGymApi.Entities;

namespace CoreGymApi.Services;

public class SessionService : ISessionService
{
    public List<Session> GetSessions()
    {
        var sessions = new List<Session>();
        var startDate = new DateTime(2025, 9, 22);

        var dailySchedule = new[]
        {
            new { Hour = 6, Minute = 0, Title = "Spinning", Trainer = "Ove Persson", Location = "Göteborg", Duration = 3 },
            new { Hour = 8, Minute = 30, Title = "Aerobics", Trainer = "Kent Olsson", Location = "Halmstad", Duration = 2 },
            new { Hour = 17, Minute = 0, Title = "Yoga", Trainer = "Anna Svensson", Location = "Stockholm", Duration = 1 },
            new { Hour = 18, Minute = 30, Title = "CrossFit", Trainer = "Marcus Berg", Location = "Malmö", Duration = 2 }
        };

        for (int day = 0; day < 14; day++)
        {
            var currentDate = startDate.AddDays(day);

            foreach (var schedule in dailySchedule)
            {
                sessions.Add(new Session
                {
                    Id = Guid.NewGuid(),
                    StartTime = new DateTime(currentDate.Year, currentDate.Month, currentDate.Day,
                                           schedule.Hour, schedule.Minute, 0),
                    Duration = schedule.Duration,
                    Title = schedule.Title,
                    Description = "",
                    Trainer = schedule.Trainer,
                    Location = schedule.Location,
                    Spots = 20
                });
            }
        }


        return sessions;
    }
}
