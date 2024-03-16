using Task1.Models.Cars.Abstract;
using Task1.Models.Races.Abstract;

namespace Task1.Models.Races.Concrete;

public class Rally : Race
{
    public override void StartRace(Car[] car)
    {
        Console.WriteLine($"Track: {NameRace}, passability: {PassabilityRace}\n");
        
        foreach (var i in car)
        {
            Console.WriteLine($"Car: {i.Manufacturer} {i.Model} (speed: {i.Speed}, passability: {i.Passability})");
        }
        Console.WriteLine();
        
        Array.Sort(car, new PassabilityComparer());
        Array.Reverse(car);
        
        var rand = new Random();
        
        foreach (var i in car)
        {
            var probability = i.IsPassabilityTuned ? 50 : 30;
            if (rand.Next(100) < probability)
            {
                Console.WriteLine($"{i.Manufacturer} {i.Model} wins the \"{NameRace} race.\"\n");
                return;
            }
        }
        Console.WriteLine($"{car[0].Manufacturer} {car[0].Model} wins the \"{NameRace} race.\"\n");
    }
}