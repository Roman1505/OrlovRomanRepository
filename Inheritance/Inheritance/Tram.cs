using System;

public class Tram : Vehicle
{
    public int Places { get; set; }
    public Tram(int power, int places)
        : base(power)
    {
        Places = places;
    }
    public override void Move()
    {
        Console.WriteLine("Tram is move");
    }
}