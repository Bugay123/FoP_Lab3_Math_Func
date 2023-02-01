internal class Program
{
    private static void Main(string[] args)
    {
        // Обчислити макс.і мін. трьох чисел.
        int a = 1, b = 2, c = 3;
        double min = Math.Min(Math.Min(a,b), c);
        double max = Math.Max(Math.Max(a, b), c);
        Console.WriteLine($"Мiнімальне - {min}\nМаксимальне - {max}");
    }
}