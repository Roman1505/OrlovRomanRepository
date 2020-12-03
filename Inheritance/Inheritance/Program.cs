using System;

namespace Inheritance
{
      
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
