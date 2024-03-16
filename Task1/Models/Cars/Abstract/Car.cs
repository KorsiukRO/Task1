namespace Task1.Models.Cars.Abstract;

public abstract class Car
{
    public int Speed { get; private set; }
    
    public int Passability { get; private set; }
    
    public required string Manufacturer { get; init; } 

    public required string Model { get; init; }  

    public bool IsSpeedTuned { get; private set; }
    
    public bool IsPassabilityTuned { get; private set; }
    
    public void Tune(int speed, int passability)
    {
        if (!(speed >= (float)Speed * 0.1 && speed <= (float)Speed * 0.3))
        {
            throw new ArgumentException($"You can improve the speed in the range from {(float)Speed * 0.1} to {(float)Speed * 0.3}.");
        }
        
        var newSpeed = Speed + speed;
        Console.WriteLine($"Speed: {Manufacturer} {Model} {Speed} --> {newSpeed}");
        Speed = newSpeed;
        IsSpeedTuned = true;

        if (!(passability >= (float)Passability * 0.1 && passability <= (float)Passability * 0.3))
        {
            throw new ArgumentException($"You can improve the passability in the range from {(float)Passability * 0.1} to {(float)Passability * 0.3}.");
        }

        var newPassability = Passability + passability;
        Console.WriteLine($"Passability: {Manufacturer} {Model} {Passability} --> {newPassability}");
        Passability = newPassability;
        IsPassabilityTuned = true;
    }

    public Car() { }
    
    public Car(int speed, int passability, int minSpeed, int maxSpeed, int minPassability, int maxPassability)
    {
        Speed = (speed >= minSpeed && speed <= maxSpeed) ? speed : throw new ArgumentException($"The speed should be in the range of {minSpeed} - {maxSpeed} km/h.");
        Passability = (passability >= minPassability && passability <= maxPassability) ? passability : throw new ArgumentException($"The passability should be in the range of {minPassability} - {maxPassability}.");
    }
}