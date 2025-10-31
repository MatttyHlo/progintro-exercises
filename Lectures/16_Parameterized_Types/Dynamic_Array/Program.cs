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
Console.WriteLine(a);
for (int i=19 ; i>=0 ; i--) {
a.Remove(random.Next(a.GetFill()));
Console.WriteLine(a);

interface IDynArray<T>
{
    void Append(T element);
    void Insert(int i, T element);
    void Remove(int i);
    void Set(int i, T element);
    T
    Get(int i);
    int GetFill();
}

class DynArray<T> : IDynArray<T>
{
    public T[] data = new T[1]; 
    public void Apeend(T element)
    {
        for (int i = 0; i < data.Length; i++)
        {
            if (data[i] == null)
            {
                data[i] = element;
                break;
            }
            else if (i == data.Length - 1)
            {
                //create larger
                T[] newData = new T[data.Length * 2];
                for (int j = 0; j < data.Length; j++)
                {
                    newData[j] = data[j];
                }
                data = newData;
            }
        }
        
    }
}

    
