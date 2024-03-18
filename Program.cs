public class Program
{
    static double average(int[] intss)
    {
        double vLocal = 0;
        foreach (int i in intss)
        {
            vLocal += (double)i / intss.Length;
        }
        return vLocal;
    }

    static int max(int[] ints) {
        int vLocal = ints.First();
        foreach(int i in ints) {
            if (i > vLocal)
                vLocal = i;
        }
        return vLocal;
    }

    static void Main()
    {
        Console.WriteLine("Zadanie pierwsze z APBD!");
        Console.WriteLine("Pierwsza aplikacja dotnet!");
        Console.WriteLine("Średnia z 5 4 2 8 7: " + average([5, 4, 2, 8, 7]));
        Console.WriteLine("Max z 5 4 2 8 7: " + max([5, 4, 2, 8, 7]));
    }
}

