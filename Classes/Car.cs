using System;
using System.Xml.Linq;

public class Car : Device
{
    public Car(string name) : base(name)
    {
    }

    public override void Sound()
    {
        Console.WriteLine($"The {Name} makes engine sound.");
    }
}
