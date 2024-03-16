using Task1.Models.Cars.Abstract;

namespace Task1.Models.Cars.Concrete;

public sealed class SportCar : Car
{
    private const int MinSpeed = 240;
    private const int MaxSpeed = 400;
    private const int MinPassability = 5;
    private const int MaxPassability = 30;
    
    public SportCar(int speed, int passability) : base(speed, passability, MinSpeed, MaxSpeed, MinPassability, MaxPassability) {}
}