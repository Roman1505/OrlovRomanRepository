using System;

public class Car : Vehicle
{

    public string Color { get; set; }
    public Car(int power, string color)
        : base(power)
    {
        Color = color;
    }
    public override void Move()
    {
        Console.WriteLine("Car is move");
    }
}



