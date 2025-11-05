using System.Dynamic;

interface NondestructiveSet<T>
{
    public NdestructiveSet<T> Intersection(NdestructiveSet<T> set);
    public NdestructiveSet<T> Union(NdestructiveSet<T> set);
    public NdestructiveSet<T> Difference(NdestructiveSet<T> set);
}

class NdestructiveSet<T> : HashSet<T>, NondestructiveSet<T>
{
    
    public NdestructiveSet<T> Intersection(NdestructiveSet<T> set)
    {
        NdestructiveSet<T> newSet = new NdestructiveSet<T>();
        foreach (T item in set.ToArray())
        {
            if (this.Contains(item))
            {
                newSet.Add(item);
            }
        }
        return newSet;
    }
    public NdestructiveSet<T> Union(NdestructiveSet<T> set){
        NdestructiveSet<T> newSet = new NdestructiveSet<T>();
        foreach(T item in this)
        {
            newSet.Add(item);
        }
        foreach (T item in set.ToArray())
        {
            if (!this.Contains(item))
            {
                newSet.Add(item);
            }
        }
        return newSet;
    }
    public NondestructiveSet<T> Difference(NdestructiveSet<T> set){
        NdestructiveSet<T> newSet = new NdestructiveSet<T>();
        foreach(T item in this)
        {
            newSet.Add(item);
        }
        foreach (T item in set.ToArray())
        {
            if (this.Contains(item))
            {
                newSet.Remove(item);
            }
        }
        return newSet;
    }
}