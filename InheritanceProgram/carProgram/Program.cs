using System;

// Base class
class Car
{
    public void Drive()
    {
        Console.WriteLine("The car is being driven.");
    }
}

// Derived class 1
class SportsCar : Car
{
    public void Accelerate()
    {
        Console.WriteLine("The sports car is accelerating.");
    }
}

// Derived class 2
class SUV : Car
{
    public void OffRoad()
    {
        Console.WriteLine("The SUV is going off-road.");
    }
}

class Program
{
    static void Main(string[] args)
    {
       
        SportsCar sportsCar = new SportsCar();
        SUV suv = new SUV();

        
        sportsCar.Drive(); 
        suv.Drive();       

        
        sportsCar.Accelerate();
        suv.OffRoad();
    }
}
