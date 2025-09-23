using CoreGymApi.Entities;

namespace CoreGymApi;

public interface ISessionService
{
    List<Session> GetSessions();
}
