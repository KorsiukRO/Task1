using System.Linq.Expressions;

namespace Task1;

public abstract class Car : IComparable
{
    protected int speed;
    protected int passability;
    protected string? manufacturer;
    protected string? model;
    protected bool isSpeedTune;
    protected bool isPassabilityTune;
    
    
    public virtual int Speed
    {
        get => speed;
        set { speed = value; }
    }
    public virtual int Passability
    {
        get => passability;
        set { passability = value; }
    }
    public virtual string? Manufacturer
    {
        get => manufacturer;
        set { manufacturer = (value != null) ? value : throw new ArgumentException("Виробник авто має бути вказаний");}
    }
    public virtual string? Model
    {
        get => model;
        set { model = (value != null) ? value : throw new ArgumentException("Модель авто має бути вказана");}
    }

    public bool IsSpeedTune
    {
        get => isSpeedTune;
        set { isSpeedTune = value; }
    }

    public bool IsPassabilityTune
    {
        get => isPassabilityTune;
        set { isPassabilityTune = value; }
    }

    
    public void Tune(int speed, int passability)
    {
        if (!(speed >= (float)this.speed * 0.1 && speed <= (float)this.speed * 0.3))
        {
            throw new ArgumentException($"Ви можете покращити швидкість в діапазоні від {(float)this.speed * 0.1} і до {(float)this.speed * 0.3}.");
        }
        int tempSpeed = this.speed;
        this.speed += speed;
        isSpeedTune = true;
        Console.WriteLine($"Швидкість: {Manufacturer} {Model} {tempSpeed} --> {this.speed}");

        if (!(passability >= (float)this.passability * 0.1 && passability <= (float)this.passability * 0.3))
        {
            throw new ArgumentException($"Ви можете покращити швидкість в діапазоні від {(float)this.passability * 0.1} і до {(float)this.passability * 0.3}.");            
        }
        int tempPassability = this.passability;
        this.passability += passability;
        isPassabilityTune = true;
        Console.WriteLine($"Прохідність: {Manufacturer} {Model} {tempPassability} --> {this.passability}");
        Console.WriteLine();
    }

    public virtual int CompareTo(object? obj) // мало зрозумів переписав з книжки ст. 376
    {
        if (obj is Car car)
        {
            return this.speed.CompareTo(car.speed);
        }

        throw new ArgumentException("Параметр не є об'єктом типу Car!");
    }
    
    
}