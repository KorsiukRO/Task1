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
        Console.WriteLine($"Траса: {NameRace}, прохідність: {PassabilityRace}\n");
        foreach (var i in car)
        {
            Console.WriteLine($"Авто: {i.Manufacturer} {i.Model} (Швидкість: {i.Speed}, прохідність: {i.Passability})");
        }
        Console.WriteLine();
        
        Array.Sort(car);
        Array.Reverse(car);
        var rand = new Random();
        foreach (var i in car)
        {
            if (i.IsSpeedTune == true)
            {
                if (rand.Next(100) < 50)
                {
                    Console.WriteLine($"У гонці \"{NameRace}\" перемагає {i.Manufacturer} {i.Model}\n----------------------------------------");
                    return;
                }    
            }
            else if (rand.Next(100) < 30)
            {
                Console.WriteLine($"У гонці \"{NameRace}\" перемагає {i.Manufacturer} {i.Model}\n----------------------------------------");
                return;
            }
        }
        Console.WriteLine($"У гонці \"{NameRace}\" перемагає {car[0].Manufacturer} {car[0].Model}\n----------------------------------------");
    }
}