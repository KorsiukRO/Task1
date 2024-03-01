using System.Linq.Expressions;

namespace Task1;

public abstract class Car
{
    protected int speed;//костиль(
    public virtual int Speed
    {
        get => speed;
        set { speed = value; }
    }
    
    protected int passability;//костиль(
    public virtual int Passability
    {
        get => passability;
        set { passability = value; }
    }
    
    protected string? manufacturer;//костиль(
    public virtual string? Manufacturer
    {
        get => manufacturer;
        set { manufacturer = value; }
    }


    
}