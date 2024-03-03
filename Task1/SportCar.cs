namespace Task1;

public sealed class SportCar : Car
{
    private const int minSpeed = 240;
    private const int maxSpeed = 400;
    private const int minPassability = 5;
    private const int maxPassability = 30;
    
    public SportCar(int speed, int passability, string? manufacturer, string? model)
    {
        Speed = speed;
        Passability = passability;
        Manufacturer = manufacturer;
        Model = model;
    }
    
    public override int Speed
    {
        get => speed;
        set { speed = (value >= minSpeed && value <= maxSpeed) ? value : throw new ArgumentException($"Швидкість має бути в діапазоні {minSpeed} - {maxSpeed} км/год"); }
    }
    
    public override int Passability
    {
        get => passability;
        set { passability = (value >= minPassability && value <= maxPassability) ? value : throw new ArgumentException($"Прохідність має бути в діапазоні {minPassability} - {maxPassability}");}
    }
}