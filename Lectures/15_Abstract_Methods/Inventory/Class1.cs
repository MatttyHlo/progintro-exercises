﻿using System.Runtime.CompilerServices;

abstract class Item : IExpireable
{
    private string name;
    private double price;
    public Item(string nameValue, double priceValue)
    {
        name = nameValue;
        price = priceValue;
    }

    public string GetName()
    {
        return name;
    }
    public double GetPrice()
    {
        return price;
    }

    public abstract bool IsExpired();
}

interface IExpireable
{
    public bool IsExpired();
}

class FoodItem : Item
{
    private DateTime expiresAt;


    public FoodItem(string name, double price, DateTime expiresAtValue)
    : base(name, price)
    {
        expiresAt = expiresAtValue;
    }
    public DateTime GetExpiresAt()
    {
        return expiresAt;
    }
    public override string ToString()
    {
        return "FoodItem name='" + GetName() + "'"
        + " price='" + GetPrice() + "'"
        + " expiresAt='" + GetExpiresAt() + "'";
    }

    public override bool IsExpired()
    {
        if (expiresAt < DateTime.Now) return true;
        else return false;
    }
}
class NonFoodItem : Item
{
    public string[] materials;
    public NonFoodItem(string name, double price, string[] materialsValue)
    : base(name, price)
    {
        materials = materialsValue;
    }
    public string[] GetMaterials()
    {
        return materials;
    }
    public override string ToString()
    {
        string m = "[";
        for (int i = 0; i < materials.Length; i++)
        {
            m += (i == 0 ? "" : ",") + materials[i];
        }
        m += "]";
        return "NonFoodItem name='" + GetName()
        + "' price='" + GetPrice()
        + "' materials='" + m + "'";
    }

    public override bool IsExpired()
    {
        return false;
    }

}

class Inventory
{
    private Item?[] Items = new Item[1000];

    public void AddItem(Item item)
    {
        for (int i = 0; i < Items.Length; i++)
        {
            if (Items[i] == null){
                Items[i] = item;
                break;
            } 
        }
    }

    public void RemoveItem(Item item)
    {
        for (int i = 0; i < Items.Length; i++)
        {
            if (Items[i] == item) Items[i] = null;
        }
    }

    public double GetInventoryValue()
    {
        double sum = 0;
        foreach (Item? i in Items)
        {
            if (i != null) sum += i.GetPrice();
        }
        return sum;
    }

    public void PrintInventory()
    {
        foreach (Item? i in Items)
        {
            if (i != null) Console.WriteLine(i.ToString());
        }
    }
}

class Test
{
    public static void Main (string[] args)
    {
        Inventory inventory = new Inventory();
        for (int i = 0; i < 10; i += 2)
        {
            inventory.AddItem(new NonFoodItem("Item " + i, 12.3 * i,new string[] { "butter", "cream" }));
            // use string interpolation and a valid DateTime call (AddDays for variety)
            inventory.AddItem(new FoodItem($"chocolate{i + 1}", 36.5 * i, DateTime.Now));
        }
        
        inventory.GetInventoryValue();
        inventory.PrintInventory();
    }
}

