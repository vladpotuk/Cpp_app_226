using System;
using System.Xml.Linq;

public class Microwave : Device
{
    public Microwave(string name) : base(name)
    {
    }

    public override void Sound()
    {
        Console.WriteLine($"The {Name} makes beeping sound.");
    }
}
