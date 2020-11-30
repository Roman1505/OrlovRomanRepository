using System;

public class Truck : Vehicle
{
    public int Load { get; set; }
    public Truck(int power, int load)
        : base(power)
    {
        Load = load;
    }
    public override void Move()
    {
        Console.WriteLine("Truck is move");
    }
}