using System;

class Program
{
    static void Main(string[] args)
    {
        Kettle kettle = new Kettle("Electric Kettle");
        Microwave microwave = new Microwave("Microwave Oven");
        Car car = new Car("SUV");
        Steamship steamship = new Steamship("Steamship");

        kettle.Show();
        kettle.Sound();
        kettle.Desc();

        Console.WriteLine();

        microwave.Show();
        microwave.Sound();
        microwave.Desc();

        Console.WriteLine();

        car.Show();
        car.Sound();
        car.Desc();

        Console.WriteLine();

        steamship.Show();
        steamship.Sound();
        steamship.Desc();
    }
}

