using Task1.Models.Cars.Abstract;

namespace Task1.Models.Cars.Concrete;

public sealed class RegularCar : Car
{
    private const int MinSpeed = 180;
    private const int MaxSpeed = 280;
    private const int MinPassability = 20;
    private const int MaxPassability = 60;
    

    public RegularCar(int speed, int passability) : base(speed, passability, MinSpeed, MaxSpeed, MinPassability, MaxPassability) { }
}