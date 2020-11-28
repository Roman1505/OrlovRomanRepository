using System;
using System.Collections.Generic;
using System.Linq;

namespace MyCollection

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

    
    
    // Создание собственного класса исключений.
    public class TruckException : Exception

    {
        public TruckException(string message)
            : base(message)
        {

        }

    }

    // Домашнее задание выполняется на основе следующего класса.
    public class Truck : Vehicle

    {
        public const int border = 10;
        public int load;
        public int Load
        {
            get
            {
                return load;
            }
            set
            {
                if (value < border)
                    // Генерация исключения.
                    throw new TruckException($"Некорректное значение грузоподъемности : {value}");
                else
                    load = value;
            }

        }
        public Truck(int power, int load)
            : base(power)
        {
            Load = load;
        }


        public override void Move()
        {
            Console.WriteLine("Truck is move");
        }
        public override int GetHashCode()
        {
            return Load.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            if (obj.GetHashCode() != this.GetHashCode())
                return false;
            Truck truck = (Truck)obj;
            return (this.Load == truck.Load);

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
        public override string ToString()
        {
            return $"{Power};{Color};{Length}";
        }
    }

    public class RouteBus<T> : Bus
    {
        public T Route { get; set; }
        public RouteBus(int power, int places, T route)
            : base(power, places)
        {

            Route = route;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[] ld = new int[4];
                int i;
                for (i = 0; i < 4; i++)
                {
                    Console.WriteLine("Введите грузоподъемность :");
                   
                    ld[i] = Int32.Parse(Console.ReadLine());
                   
                }

                // Создание объектов класса Truck. 

                var truck = new Truck(500, ld[0]);
                var truck_1 = new Truck(400, ld[1]);
                var truck_2 = new Truck(500, ld[2]);
                var truck_3 = new Truck(500, ld[3]);


                // Создание списков объектов класса Truck.

                List<Truck> x = new List<Truck>();

                x.Add(truck);
                x.Add(truck_1);
                x.Add(truck_2);
                x.Add(truck_3);

                Console.WriteLine("\n");

                // Вывод коллекции.
                Console.WriteLine("Вывод коллекции :");

                foreach (var m in x)
                    Console.WriteLine("Мощность двигателя :{0}, Грузоподъемность :{1}", m.Power, m.Load);

                // Сортировка по грузоподъемности (лямбда-выражение).
                Console.WriteLine("\n");
                Console.WriteLine("Сортировка по грузоподъемности (лямбда-выражение) :");



                var sort_load = x.OrderBy(y => y.Load).ToList();

                foreach (var n in sort_load)
                    Console.WriteLine("Мощность двигателя :{0}, Грузоподъемность :{1}", n.Power, n.Load);

                // Сортировка по грузоподъемности (LINQ).
                Console.WriteLine("\n");
                Console.WriteLine("Сортировка по грузоподъемности (LINQ) :");

                var load_sort = from y in x orderby y.Load select y;

                foreach (var p in load_sort)
                    Console.WriteLine("Мощность двигателя :{0}, Грузоподъемность :{1}", p.Power, p.Load);

            }

            // Блок catch для типа TruckException.
            catch (TruckException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Ошибка: {ex.Message}");
                Console.ResetColor();
            }

            // Блок catch для базового типа Exception.
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Исключение : {ex.Message}");
                Console.ResetColor();
            }
        }
    }
}




