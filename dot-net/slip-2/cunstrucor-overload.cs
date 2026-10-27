using System;

class Student
{
    string name;
    int age;

    public Student()
    {
        name = "Unknown";
        age = 0;
    }

    public Student(string n)
    {
        name = n;
        age = 0;
    }

    public Student(string n, int a)
    {
        name = n;
        age = a;
    }

    public void Display()
    {
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
        Console.WriteLine();
    }
}

class Program
{
    static void Main()
    {
        Student s1 = new Student();
        Student s2 = new Student("Rahul");
        Student s3 = new Student("Amit", 21);

        s1.Display();
        s2.Display();
        s3.Display();
    }
}