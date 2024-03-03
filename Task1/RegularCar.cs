using System.Linq.Expressions;

namespace Task1;

public sealed class RegularCar : Car
{
    private const int minSpeed = 180;
    private const int maxSpeed = 280;
    private const int minPassability = 20;
    private const int maxPassability = 60;
    public RegularCar(int speed, int passability, string? manufacturer, string? model)
    {
        Speed = speed;
        Passability = passability;
        Manufacturer = manufacturer;
        Model = model;
    }
    
    
    public override int Speed
    {
        get => speed;
        set { speed = (value >= minSpeed && value <= maxSpeed) ? value : throw new ArgumentException($"{Manufacturer} {Model}(Швидкість має бути в діапазоні {minSpeed} - {maxSpeed} км/год)"); }
    }
    
    public override int Passability
    {
        get => passability;
        set { passability = (value >= minPassability && value <= maxPassability) ? value : throw new ArgumentException($"{Manufacturer} {Model}(Прохідність має бути в діапазоні {minPassability} - {maxPassability})");}
    }
}