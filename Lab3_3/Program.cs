internal class Program
{
    private static void Main(string[] args)
    {
        /* Знайти значення поліному p = 23,5*x^4 + 30*x^3 + 20*x -5.
           Значення x ввести з консолі.
           Результат вивести на консоль.*/

        Console.WriteLine("Введіть значення x: ");
        double x = Convert.ToDouble(Console.ReadLine());
        double p = 23.5 * Math.Pow(x,4) + 30 * Math.Pow(x,3) + 20 * x - 5;
        Console.WriteLine($"Значення поліному p = {p}");
    }
}