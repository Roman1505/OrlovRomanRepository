using System;

public class Limousine : Car
{
    public int Length { get; set; }
    public Limousine(int power, string color, int length)
        : base(power, color)
    {
        Length = length;
    }
    public override void Move()
    {
        Console.WriteLine("Limousine is move");
    }
}