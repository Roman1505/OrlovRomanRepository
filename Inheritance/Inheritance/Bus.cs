using System;

public class Bus : Vehicle
{
    public int Places { get; set; }
    public Bus(int power, int places)
        : base(power)
    {
        Places = places;
    }
    public override void Move()
    {
        Console.WriteLine("Bus is move");
    }
}
