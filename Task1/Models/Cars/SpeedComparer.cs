using System.Collections;
using Task1.Models.Cars.Abstract;

namespace Task1;

public class SpeedComparer : IComparer
{
    public int Compare(object? o1, object? o2)
    {
        if (o1 is Car t1 && o2 is Car t2)
        {
            return t1.Speed.CompareTo(t2.Speed);
        }
        throw new ArgumentException("The parameter is not an object of type Car!");
    }
}