using System.Data.Common;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
class Program {
    static void Main()
    {
        Customer aCustomer;
        aCustomer = new Customer("Bob", 69, 420);
        aCustomer.Deposit(1000);
        aCustomer.Withdraw(250);
        Console.WriteLine(aCustomer.GetBalance());

        CustomerDatabase database = new CustomerDatabase();

        database.AddCustomer(aCustomer);

        Customer jack = new Customer("Jack", 70, 421);
        database.AddCustomer(jack);

        database.PrintCustomers();
        database.RemoveCustomer(70);
        Console.WriteLine("--------------------------------");
        database.PrintCustomers();
    }
}

class Customer
{
    public string Name;
    public int Id;
    private double Balance;

    public Customer(string name, int id)
    {
        Name = name;
        Id = id;
        Balance = 0;
    }
    public Customer(string name, int id, double balance)
    {
        Name = name;
        Id = id;
        Balance = balance;
    }

    public void Deposit(double amount)
    {
        Balance += amount;
    }

    public void Withdraw(double amount)
    {
        if (amount < Balance) Balance -= amount;
    }

    public double GetBalance()
    {
        return Balance;
    }
}

class CustomerDatabase
{
    private Customer[] Customers;

    public CustomerDatabase()
    {
        Customers = new Customer[10];
    }

    public void AddCustomer(Customer customer)
    {
        for (int i = 0; i < 10; i++)
        {
            if (Customers[i] == null)
            {
                Customers[i] = customer;
                break;
            }
        }
    }

    public void RemoveCustomer(int id)
    {
        for (int i = 0; i < 10; i++)
        {
            if (Customers[i] != null && Customers[i].Id == id)
            {
                Customers[i] = null;
                break;
            }
        }
    }

    public Customer[] GetCustomers()
    {
        return Customers;
    }

    public void PrintCustomers()
    {
        foreach (Customer i in Customers)
        {
            if (i != null)
            {
                Console.WriteLine($"name: {i.Name}, id: {i.Id}, balance: {i.GetBalance()}");
            }
        }
    }
}
