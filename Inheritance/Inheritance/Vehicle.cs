using System;

public abstract class Vehicle
{
    public abstract void Move();
    public int Power { get; set; }

    public Vehicle(int power)
    {
        Power = power;
    }
    public void Display()
    {
        Console.WriteLine(Power);
    }
}