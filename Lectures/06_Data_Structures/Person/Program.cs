using System.Reflection.Metadata;

class Person
{
    public int age;
    public string name;
};

class Program
{
    public static void Main()
    {
        Person person1 = new Person();
        person1.age = 3;
        person1.name = "Bob";
        Console.WriteLine($"{person1.name} is {person1.age} years old");
    }   
}