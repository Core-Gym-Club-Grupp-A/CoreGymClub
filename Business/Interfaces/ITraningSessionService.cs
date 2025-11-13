using Domain.Models;

namespace Business.Interfaces;

/* 
    User Story 1: Som användare vill jag kunna se en lista över kommande träningspass.
    Detta interface tillhör Business-lagret och definierar affärslogiken.
    Metoden filtrerar framtida pass och returnerar dessa till presentationslagret.
*/

public interface ITraningSessionService
{
    Task<IEnumerable<TrainingSession>> GetUpcomingSessionsAsync();
}
