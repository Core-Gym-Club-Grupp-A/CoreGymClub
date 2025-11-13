namespace Domain.Models;

/* 
    User Story 1: Som användare vill jag kunna se en lista över kommande träningspass.
    Denna modell representerar ett träningspass i systemet.
    Den används av både Repository- och Service-lagret för att hantera och presentera data.
*/

public class TrainingSession
{
    public int Id { get; set; }
    public string Title { get; set; } = null!;
    public string Instructor { get; set; } = null!;
    public string Location { get; set; } = null!;
    public DateTime StartTime { get; set; }
    public int MaxParticipants { get; set; }
    public int CurrentParticipants { get; set; }

    // Beräknad egenskap för antalet lediga platser.
    public int AvailableSeats => MaxParticipants - CurrentParticipants;
}
