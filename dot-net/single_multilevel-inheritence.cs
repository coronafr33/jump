using System;

class Person
{
    public void DisplayPerson()
    {
        Console.WriteLine("I am a person.");
    }
}

class Student : Person
{
    public void DisplayStudent()
    {
        Console.WriteLine("I am a student.");
    }
}

class GraduateStudent : Student
{
    public void DisplayGraduate()
    {
        Console.WriteLine("I am a graduate student.");
    }
}

class Program
{
    static void Main()
    {
        // Single Inheritance
        Student s = new Student();

        s.DisplayPerson();
        s.DisplayStudent();

        Console.WriteLine();

        // Multilevel Inheritance
        GraduateStudent g = new GraduateStudent();

        g.DisplayPerson();
        g.DisplayStudent();
        g.DisplayGraduate();
    }
}