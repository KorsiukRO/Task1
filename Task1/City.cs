using System.Threading.Channels;

namespace Task1;

public class City : Race
{
    public City(string nameRace, int passabilityRace)
    {
        NameRace = nameRace;
        PassabilityRace = passabilityRace;
    }

    public void StartRace(Car[] car)
    {
        Console.WriteLine($"Track: {NameRace}, passability: {PassabilityRace}\n");
        foreach (var i in car)
        {
            Console.WriteLine($"Car: {i.Manufacturer} {i.Model} (speed: {i.Speed}, passability: {i.Passability})");
        }
        Console.WriteLine();
        Array.Sort(car, new SpeedComparer());
        Array.Reverse(car);
        var rand = new Random();
        foreach (var i in car)
        {
            if (i.IsSpeedTune == true)
            {
                if (rand.Next(100) < 50)
                {
                    Console.WriteLine($"{i.Manufacturer} {i.Model} wins the \"{NameRace} race.\"\n");
                    return;
                }    
            }
            else if (rand.Next(100) < 30)
            {
                Console.WriteLine($"{i.Manufacturer} {i.Model} wins the \"{NameRace} race.\"\n");
                return;
            }
        }
        Console.WriteLine($"{car[0].Manufacturer} {car[0].Model} wins the \"{NameRace} race.\"\n");
    }
}