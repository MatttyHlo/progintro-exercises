using System.Data;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

IDynArray<int> a = new DynArray<int>();
Console.WriteLine("Add elements:");
Console.WriteLine(a);
for (int i=0 ; i<20 ; i++) {
a.Append(i);
Console.WriteLine(a);
}
Console.WriteLine("");
Random random = new Random();
Console.WriteLine("Remove elements:");
Console.WriteLine(a.GetFill());
Console.WriteLine(a);
for (int i = 18; i >= 0; i--)
{
    int index = random.Next(a.GetFill());
    a.Remove(index);
}
Console.WriteLine(a);

interface IDynArray<T>
{
    void Append(T element);
    void Insert(int i, T element);
    void Remove(int i);
    void Set(int i, T element);
    T Get(int i);
    int GetFill();
}

class DynArray<T> : IDynArray<T>
{
    public T?[] data = new T?[1];
    private int fill;

    private int capacity = 1;

    public void Append(T element)
    {
        if (fill == capacity)
        {
            //create larger
            capacity *= 2;
            T?[] newData = new T?[capacity];
            for (int j = 0; j < data.Length; j++)
            {
                newData[j] = data[j];
            }
            data = newData;
            data[capacity / 2] = element;
        }
        else
        {
            data[fill] = element;
        }
        fill++;
        
    }

    public void Remove(int index)
    {
        for (int i = index; i < fill -1; i++)
        {
            data[i] = data[i + 1];
        }
        fill--;
        if (fill <= capacity / 2)
        {
            capacity /= 2;
            T?[] newData = new T?[capacity];
            for (int i = 0; i < capacity; i++)
            {
                newData[i] = data[i];
            }
            data = newData;
        }
    }

    public void Insert(int index, T element)
    {
        if (fill == capacity)
        {
            //create larger
            capacity *= 2;
            T?[] newData = new T?[capacity];
            for (int j = 0; j < data.Length; j++)
            {
                newData[j] = data[j];
            }
        }
        for (int i = fill; i > index; i--)
        {
            data[i] = data[i - 1];
        }
        data[index] = element;
        fill++;
    }

    public void Set(int index, T element)
    {
        data[index] = element;
    }

    public T Get(int i)
    {
        return data[i];
    }

    public int GetFill()
    {
        return fill;
    }
    public override string ToString()
    {
        string output = "";
        foreach(T? i in data)
        {
            if(i != null) output += i.ToString() + " ";
        }
        return output;
    }
}

    
