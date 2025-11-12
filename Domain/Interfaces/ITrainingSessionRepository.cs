using Domain.Models;

namespace Domain.Interfaces;

/* 
    User Story 1: Som användare vill jag kunna se en lista över kommande träningspass.
    Detta interface ansvarar för dataåtkomst. 
    Här definieras anropet som hämtar träningspass från datakällan (t.ex. databas eller mock-data).
*/

public interface ITrainingSessionRepository
{
    Task<IEnumerable<TrainingSession>> GetAllSessionsAsync();
}
