using System.Linq.Expressions;

namespace Task1;

public abstract class Car
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
        set { manufacturer = (value != null) ? value : throw new ArgumentException("The Manufacturer must be specified.");}
    }
    public virtual string? Model
    {
        get => model;
        set { model = (value != null) ? value : throw new ArgumentException("The model must be specified.");}
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
            throw new ArgumentException($"You can improve the speed in the range from {(float)this.speed * 0.1} to {(float)this.speed * 0.3}.");
        }
        int tempSpeed = this.speed;
        this.speed += speed;
        isSpeedTune = true;
        Console.WriteLine($"Швидкість: {Manufacturer} {Model} {tempSpeed} --> {this.speed}");

        if (!(passability >= (float)this.passability * 0.1 && passability <= (float)this.passability * 0.3))
        {
            throw new ArgumentException($"You can improve the passability in the range from {(float)this.passability * 0.1} to {(float)this.passability * 0.3}.");            
        }
        int tempPassability = this.passability;
        this.passability += passability;
        isPassabilityTune = true;
        Console.WriteLine($"Прохідність: {Manufacturer} {Model} {tempPassability} --> {this.passability}");
        Console.WriteLine();
    }
}