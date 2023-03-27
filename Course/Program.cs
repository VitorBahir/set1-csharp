using System.Collections.Generic;

internal class Program
{
    private static void Main(string[] args)
    {
        HashSet<string> set = new HashSet<string>();

        set.Add("TV");
        set.Add("Notebook");
        set.Add("Tablet");

        // To know if contains in set (true or false)
        // Console.WriteLine(set.Contains("Notebook"));

        foreach (string p in set)
        {
            Console.WriteLine(p);
        }

        SortedSet<int> a = new SortedSet<int>() { 0, 2, 4, 5, 6, 8, 10 };
        SortedSet<int> b = new SortedSet<int>() { 5, 6, 7, 8, 9, 10 };
        
        //union
        SortedSet<int> c = new SortedSet<int>(a);
        c.UnionWith(b);
        PrintCollection(c);

        //intersection
        SortedSet<int> d = new SortedSet<int>(a);
        d.IntersectWith(b);
        PrintCollection(d);

        //difference
        SortedSet<int> e = new SortedSet<int>(a);
        e.ExceptWith(b);
        PrintCollection(e);
    }

    static void PrintCollection<T>(IEnumerable<T> collection)
    {
        foreach (T item in collection) 
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}