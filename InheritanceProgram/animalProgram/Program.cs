using System;

// Base class
class Animal
{
    public void Eat()
    {
        Console.WriteLine("The animal is eating.");
    }
}

// Derived class 1
class Dog : Animal
{
    public void Bark()
    {
        Console.WriteLine("The dog is barking.");
    }
}

// Derived class 2
class Cat : Animal
{
    public void Meow()
    {
        Console.WriteLine("The cat is meowing.");
    }
}

class Program
{
    static void Main(string[] args)
    {
      
        Dog dog = new Dog();
        Cat cat = new Cat();

       
        dog.Eat(); // Calling method from Dog object
        cat.Eat(); // Calling method from Cat object

        // Calling specific methods of the derived classes
        dog.Bark();
        cat.Meow();
    }
}
