using System;
using System.Xml.Linq;

public class Kettle : Device
{
    public Kettle(string name) : base(name)
    {
    }

    public override void Sound()
    {
        Console.WriteLine($"The {Name} makes boiling sound.");
    }
}
