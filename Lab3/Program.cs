internal class Program
{
    private static void Main(string[] args)
    {
       // Знайти корені квадратного рівняння - x^2 + x + 72 = 0. Результати вивести на консоль.

        double d = 1 * 1 - 4 * (-1) * 72;
        double x1 = ((-1 - Math.Sqrt(d)) / (2 * 1));
        double x2 = ((-1 + Math.Sqrt(d)) / (2 * 1));
        Console.WriteLine($"Перший корiнь = {x1}, другий корiнь = {x2}");
    }
}