using Task1.Models.Cars.Abstract;

namespace Task1.Models.Cars.Concrete;

public class JeepCar : Car
{
    private const int MinSpeed = 150;
    private const int MaxSpeed = 240;
    private const int MinPassability = 60;
    private const int MaxPassability = 100;
    
    
    public JeepCar(int speed, int passability) : base(speed, passability, MinSpeed, MaxSpeed, MinPassability, MaxPassability) { }
}