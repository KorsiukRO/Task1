using Task1.Models.Cars.Abstract;

namespace Task1.Models.Races.Abstract;

public abstract class Race
{
    public required string NameRace { get; init; }
   
    public required int PassabilityRace { get; init; }
   
    public abstract void StartRace(Car[] car);
}