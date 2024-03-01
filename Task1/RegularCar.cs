using System.Linq.Expressions;

namespace Task1;

public class RegularCar : Car
{
    public RegularCar(int speed, int passability, string? manufacturer)
    {
        Speed = speed;
        Passability = passability;
        Manufacturer = manufacturer;
    }
    
    public override int Speed
    {
        get => speed;
        set { speed = (value >= 180 && value <= 280) ? value : throw new ArgumentException("Швидкість має бути в діапазоні 180 - 280 км/год"); }
    }


    

    public override int Passability
    {
        get => passability;
        set { passability = (value >= 20 && value <= 60) ? value : throw new ArgumentException("Швидкість має бути в діапазоні 180 - 280 км/год");}
    }

    

    public override string? Manufacturer
    {
        get => manufacturer;
        set { manufacturer = (value != null) ? value : throw new ArgumentException("Назва авто має бути вказана");}
    }
    
    
    public void Tune(int speed, int passability)
    {
        speed = (speed >= (this.speed / 100 * 10) && speed <= (this.speed / 100 * 30)) ? this.speed = speed : throw new ArgumentException("Швидкість має бути в діапазоні 180 - 280 км/год");
        //(speed / 100 * 30)
        //(speed / 100 * 10) 
    }
}