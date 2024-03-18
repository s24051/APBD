public class Program
{
    static double average(int[] ints)
    {
        double vLocal = 0;
        foreach (int i in ints)
        {
            vLocal += (double)i / ints.Length;
        }
        return vLocal;
    }
    static void Main()
    {
        Console.WriteLine("Zadanie pierwsze z APBD!");
        Console.WriteLine("Pierwsza aplikacja dotnet!");
        Console.WriteLine("Średnia z 5 4 2 8 7: " + average([5, 4, 2, 8, 7]));
    }
}

