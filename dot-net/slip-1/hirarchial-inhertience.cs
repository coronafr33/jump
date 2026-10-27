using System;

// Hierarchical Inheritance
class Animal
{
    public void Eat()
    {
        Console.WriteLine("Animal is eating.");
    }
}

class Dog : Animal
{
    public void Bark()
    {
        Console.WriteLine("Dog is barking.");
    }
}

class Cat : Animal
{
    public void Meow()
    {
        Console.WriteLine("Cat is meowing.");
    }
}

// Multiple Inheritance using Interfaces
interface ICamera
{
    void TakePhoto();
}

interface IMusicPlayer
{
    void PlayMusic();
}

class SmartPhone : ICamera, IMusicPlayer
{
    public void TakePhoto()
    {
        Console.WriteLine("Taking a photo.");
    }

    public void PlayMusic()
    {
        Console.WriteLine("Playing music.");
    }
}

class Program
{
    static void Main()
    {
        Dog d = new Dog();
        d.Eat();
        d.Bark();

        Cat c = new Cat();
        c.Eat();
        c.Meow();

        SmartPhone s = new SmartPhone();
        s.TakePhoto();
        s.PlayMusic();
    }
}