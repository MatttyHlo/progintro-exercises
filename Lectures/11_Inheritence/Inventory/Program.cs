Item it = new Item("apple", 30);
Console.WriteLine(it.GetName());
Console.WriteLine(it.GetPrice());
Console.WriteLine(it.ToString());

FoodItem[] fridge = new FoodItem[10];
for (int i = 0; i < 10; i++)
{
    DateTime time = new DateTime(2025, 10, 5);
    fridge[i] = new FoodItem("apple" + (i +1), 30, time);
}

foreach (FoodItem apple in fridge)
{
    Console.WriteLine(apple.ToString());
}

NonFoodItem[] shed = new NonFoodItem[10];
for (int i = 0; i < 10; i++)
{
    string[] materials = { "silver", "wood" };
    shed[i] = new NonFoodItem("hammer" + (i +1), 300, materials);
}

foreach (NonFoodItem tool in shed)
{
    Console.WriteLine(tool.ToString());
}

class Item
{
    protected string name;
    protected double price;

    public Item(string name, double price)
    {
        this.name = name;
        this.price = price;
    }

    public string GetName()
    {
        return name;
    }

    public double GetPrice()
    {
        return price;
    }

    public override string ToString()
    {
        return "name: " + name + " price: " + price;
    }
}

class FoodItem : Item
{
    private DateTime expiresAt;

    public FoodItem(string name, double price, DateTime expiresAt)  : base(name, price)
    {
        this.expiresAt = expiresAt;
    }

    public DateTime GetExpiresAt()
    {
        return expiresAt;
    }

    public override string ToString()
    {
        return base.ToString() + " expiresAt:  " + expiresAt;
    }
}

class NonFoodItem : Item
{
    private string[] materials;
    public NonFoodItem(string name, double price, string[] materials) : base(name, price)
    {
        this.materials = materials;
    }

    public string[] GetEMaterials()
    {
        return materials;
    }

    public override string ToString()
    {
        string listOfMaterial = "";
        foreach(string s in materials){
            listOfMaterial = listOfMaterial + s +", " ;
        }
        return base.ToString() + " materials: " + listOfMaterial;
    }
}

