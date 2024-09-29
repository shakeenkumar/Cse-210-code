using System;

abstract class Vehicle  // Base class
{
    public int Speed { get; set; }

    public Vehicle(int speed)
    {
        Speed = speed;
    }

    public string Start()
    {
        return "Vehicle started";
    }
}

class Car : Vehicle  // Subclass
{
    public int NumDoors { get; set; }

    public Car(int speed, int numDoors) : base(speed) // Initialize the base class
    {
        NumDoors = numDoors;
    }

    public string Honk()
    {
        return "Car horn sound";
    }
}

// Example of using the classes
class Program
{
    static void Main(string[] args)
    {
        Car myCar = new Car(120, 4);
        Console.WriteLine(myCar.Start());  // Output: Vehicle started
        Console.WriteLine(myCar.Honk());    // Output: Car horn sound
    }
}
