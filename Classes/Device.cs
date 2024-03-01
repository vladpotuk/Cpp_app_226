using System;

public class Device
{
    public string Name { get; set; }

    public Device(string name)
    {
        Name = name;
    }

    public virtual void Sound()
    {
        Console.WriteLine($"The {Name} makes a sound.");
    }

    public void Show()
    {
        Console.WriteLine($"Device: {Name}");
    }

    public virtual void Desc()
    {
        Console.WriteLine($"Description: This is a {Name}.");
    }
}
