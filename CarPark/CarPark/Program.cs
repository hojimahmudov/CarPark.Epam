using System;

// Engine class
public class Engine
{
    public int Power { get; set; }
    public double Volume { get; set; }
    public string Type { get; set; }
    public int SerialNumber { get; set; }
}

// Chassis class
public class Chassis
{
    public int WheelsNumber { get; set; }
    public int Number { get; set; }
    public int PermissibleLoad { get; set; }
}

// Transmission class
public class Transmission
{
    public string Type { get; set; }
    public int NumberOfGears { get; set; }
    public string Manufacturer { get; set; }
}

// Passenger car class
public class PassengerCar
{
    public string Model { get; set; }
    public int Year { get; set; }
    public Engine Engine { get; set; }
    public Chassis Chassis { get; set; }
    public Transmission Transmission { get; set; }
    public int SeatsNumber { get; set; }
}

// Truck class
public class Truck
{
    public string Model { get; set; }
    public int Year { get; set; }
    public Engine Engine { get; set; }
    public Chassis Chassis { get; set; }
    public Transmission Transmission { get; set; }
    public int MaxPayload { get; set; }
}

// Bus class
public class Bus
{
    public string Model { get; set; }
    public int Year { get; set; }
    public Engine Engine { get; set; }
    public Chassis Chassis { get; set; }
    public Transmission Transmission { get; set; }
    public int SeatsNumber { get; set; }
    public int StandingPlacesNumber { get; set; }
}

// Scooter class
public class Scooter
{
    public string Model { get; set; }
    public int Year { get; set; }
    public Engine Engine { get; set; }
    public Chassis Chassis { get; set; }
    public Transmission Transmission { get; set; }
    public int MaxSpeed { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        // create a passenger car object
        PassengerCar car = new PassengerCar
        {
            Model = "BMW",
            Year = 2022,
            Engine = new Engine
            {
                Power = 300,
                Volume = 2,
                Type = "gasoline",
                SerialNumber = 123456
            },
            Chassis = new Chassis
            {
                WheelsNumber = 4,
                Number = 123,
                PermissibleLoad = 1000
            },
            Transmission = new Transmission
            {
                Type = "automatic",
                NumberOfGears = 8,
                Manufacturer = "BMW"
            },
            SeatsNumber = 5
        };

        // create a truck object
        Truck truck = new Truck
        {
            Model = "Volvo",
            Year = 2021,
            Engine = new Engine
            {
                Power = 400,
                Volume = 3,
                Type = "diesel",
                SerialNumber = 789012
            },
            Chassis = new Chassis
            {
                WheelsNumber = 6,
                Number = 456,
                PermissibleLoad = 20000
            },
            Transmission = new Transmission
            {
                Type = "manual",
                NumberOfGears = 10,
                Manufacturer = "Volvo"
            },
            MaxPayload = 10000
        };
        // create a bus object
        Bus bus = new Bus
        {
            Model = "Mercedes-Benz",
            Year = 2023,
            Engine = new Engine
            {
                Power = 250,
                Volume = 2.2,
                Type = "diesel",
                SerialNumber = 345678
            },
            Chassis = new Chassis
            {
                WheelsNumber = 8,
                Number = 789,
                PermissibleLoad = 15000
            },
            Transmission = new Transmission
            {
                Type = "automatic",
                NumberOfGears = 6,
                Manufacturer = "Mercedes-Benz"
            },
            SeatsNumber = 40,
            StandingPlacesNumber = 10
        };

        // create a scooter object
        Scooter scooter = new Scooter
        {
            Model = "Honda",
            Year = 2022,
            Engine = new Engine
            {
                Power = 10,
                Volume = 0.1,
                Type = "gasoline",
                SerialNumber = 901234
            },
            Chassis = new Chassis
            {
                WheelsNumber = 2,
                Number = 1011,
                PermissibleLoad = 200
            },
            Transmission = new Transmission
            {
                Type = "automatic",
                NumberOfGears = 1,
                Manufacturer = "Honda"
            },
            MaxSpeed = 50
        };

        // output information about the objects
        Console.WriteLine("Passenger car:");
        Console.WriteLine($"Model: {car.Model}");
        Console.WriteLine($"Year: {car.Year}");
        Console.WriteLine($"Engine: power={car.Engine.Power} volume={car.Engine.Volume} type={car.Engine.Type} serial number={car.Engine.SerialNumber}");
        Console.WriteLine($"Chassis: wheels number={car.Chassis.WheelsNumber} number={car.Chassis.Number} permissible load={car.Chassis.PermissibleLoad}");
        Console.WriteLine($"Transmission: type={car.Transmission.Type} number of gears={car.Transmission.NumberOfGears} manufacturer={car.Transmission.Manufacturer}");
        Console.WriteLine($"Seats number: {car.SeatsNumber}");

        Console.WriteLine();

        Console.WriteLine("Truck:");
        Console.WriteLine($"Model: {truck.Model}");
        Console.WriteLine($"Year: {truck.Year}");
        Console.WriteLine($"Engine: power={truck.Engine.Power} volume={truck.Engine.Volume} type={truck.Engine.Type} serial number={truck.Engine.SerialNumber}");
        Console.WriteLine($"Chassis: wheels number={truck.Chassis.WheelsNumber} number={truck.Chassis.Number} permissible load={truck.Chassis.PermissibleLoad}");
        Console.WriteLine($"Transmission: type={truck.Transmission.Type} number of gears={truck.Transmission.NumberOfGears} manufacturer={truck.Transmission.Manufacturer}");
        Console.WriteLine($"Max payload: {truck.MaxPayload}");

        Console.WriteLine();

        Console.WriteLine("Bus:");
        Console.WriteLine($"Model: {bus.Model}");
        Console.WriteLine($"Year: {bus.Year}");
        Console.WriteLine($"Engine: power={bus.Engine.Power} volume={bus.Engine.Volume} type={bus.Engine.Type} serial number={bus.Engine.SerialNumber}");
        Console.WriteLine($"Chassis: wheels number={bus.Chassis.WheelsNumber} number={bus.Chassis.Number} permissible load={bus.Chassis.PermissibleLoad}");
        Console.WriteLine($"Transmission: type={bus.Transmission.Type} number of gears={bus.Transmission.NumberOfGears} manufacturer={bus.Transmission.Manufacturer}");
        Console.WriteLine($"Seats number: {bus.SeatsNumber}");
        Console.WriteLine($"Standing places number: {bus.StandingPlacesNumber}");

        Console.WriteLine();

        Console.WriteLine("Scooter:");
        Console.WriteLine($"Model: {scooter.Model}");
        Console.WriteLine($"Year: {scooter.Year}");
        Console.WriteLine($"Engine: power={scooter.Engine.Power} volume={scooter.Engine.Volume} type={scooter.Engine.Type} serial number={scooter.Engine.SerialNumber}");
        Console.WriteLine($"Chassis: wheels number={scooter.Chassis.WheelsNumber} number={scooter.Chassis.Number} permissible load={scooter.Chassis.PermissibleLoad}");
        Console.WriteLine($"Transmission: type={scooter.Transmission.Type} number of gears={scooter.Transmission.NumberOfGears} manufacturer={scooter.Transmission.Manufacturer}");
        Console.WriteLine($"Max speed: {scooter.MaxSpeed}");
    }
}