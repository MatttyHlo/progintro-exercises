using System.ComponentModel;
using System.Formats.Asn1;
using System.Security.Cryptography;

List<Person> people = new List<Person>()
{
    new Person("John", 33, "060606-1234"),
    new Person("Jack", 69, "010101-0101"),
    new Person("Jamal", 38, "070503-5234"),
    new Person("JJ", 13, "120695-1212"),
    new Person("Jesus", 23, "060606-4444"),
};

foreach (Person i in people)
{
    if (i.GetCpr() == "010101-0101")
    {
        Console.WriteLine(i.ToString());
    }
}

Dictionary<string, Person> registry = new Dictionary<string, Person>();

foreach(Person i in people)
{
    registry.Add(i.GetCpr(), i);
}


Console.WriteLine(registry["010101-0101"].ToString());
class Person
{
    private string name;
    private int age;
    private string cpr;

    public Person(string name, int age, string cpr)
    {
        this.name = name;
        this.age = age;
        this.cpr = cpr;
    }

    public string GetName()
    {
        return name;
    }

    public int GetAge()
    {
        return age;
    }

    public string GetCpr()
    {
        return cpr;
    }

    public override string ToString()
    {
        return $"NAme: {name}, Age: {age}, CPR: {cpr}";
    }
}
