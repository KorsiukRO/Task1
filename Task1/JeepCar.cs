namespace Task1;

public class JeepCar : Car
{
    private const int minSpeed = 150;
    private const int maxSpeed = 240;
    private const int minPassability = 60;
    private const int maxPassability = 100;
    
    public JeepCar(int speed, int passability, string? manufacturer, string? model)
    {
        Speed = speed;
        Passability = passability;
        Manufacturer = manufacturer;
        Model = model;
    }
    
    public override int Speed
    {
        get => speed;
        set { speed = (value >= minSpeed && value <= maxSpeed) ? value : throw new ArgumentException($"The speed should be in the range of {minSpeed} - {maxSpeed} km/h."); }
    }
    
    public override int Passability
    {
        get => passability;
        set { passability = (value >= minPassability && value <= maxPassability) ? value : throw new ArgumentException($"The passability should be in the range of {minPassability} - {maxPassability}."); }
    }
}