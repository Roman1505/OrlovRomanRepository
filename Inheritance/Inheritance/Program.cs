using System;

namespace Inheritance
{
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
    class Program
    {
        static void Main(string[] args)
        {
           
            Car car = new Car(100, "Black");
            Truck truck = new Truck(500, 30);
            Bus bus = new Bus(300, 80);
            Tram tram = new Tram(250, 40);
            Limousine limousine = new Limousine(200, "Black", 8);

            Console.WriteLine("*********");

            car.Move();
            truck.Move();
            bus.Move();
            tram.Move();
            limousine.Move();

            Console.WriteLine("*********");

            car.Display();
            truck.Display();
            bus.Display();
            tram.Display();
            limousine.Display();


            
            Vehicle car_1 = new Car(120, "White");
            Vehicle truck_1 = new Truck(400, 25);
            Vehicle bus_1 = new Bus(200, 60);
            Vehicle tram_1 = new Tram(250, 40);
            Limousine limousine_1 = new Limousine(200, "White", 8);

            Console.WriteLine("*********");

            car_1.Move();
            truck_1.Move();
            bus_1.Move();
            tram_1.Move();
            limousine_1.Move();
        }
    }
}
