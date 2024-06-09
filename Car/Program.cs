using System;

class Program
{
    static void Main(string[] args)
    {
        Car car = new Car();
        car.Start();
        car.Stop();
        car.GetDetails();
        Bus bus = new Bus(); 
        bus.Start();
        bus.Stop();
        bus.GetDetails();
        Motorcycle motorcycle = new Motorcycle();
        motorcycle.Start();
        motorcycle.Stop();
        motorcycle.GetDetails();
    }
    public class Car : IVehicle
    {
        public void Start()
        {
            Console.WriteLine("Car gets started");
        }
        public void Stop()
        {
            Console.WriteLine("Car stopped");
        }

        public string GetDetails()
        {
            return "This is a car";
        }

    }
    public class Bus : IVehicle
    {
        public void Start()
        {
            Console.WriteLine("Bus gets started");
        }
        public void Stop()
        {
            Console.WriteLine("BUs stopped");
        }

        public string GetDetails()
        {
            return "This is a bus";
        }

    }
    public class Motorcycle : IVehicle
    {
        public void Start()
        {
            Console.WriteLine("Motorcycle gets started");
        }
        public void Stop()
        {
            Console.WriteLine("Motorcycle stopped");
        }

        public string GetDetails()
        {
            return "This is a Motorcycle";
        }

    }

}

