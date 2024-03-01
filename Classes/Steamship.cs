using System;
using System.Xml.Linq;

public class Steamship : Device
{
    public Steamship(string name) : base(name)
    {
    }

    public override void Sound()
    {
        Console.WriteLine($"The {Name} makes steam whistle sound.");
    }
}
