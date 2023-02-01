internal class Program
{
    private static void Main(string[] args)
    {
       /* Обчислити значення функції в точці x за формулою.
          Значення x ввести з консолі.
          Результат вивести на консоль.*/

        Console.WriteLine("Введіть значення х: ");
        double x = Convert.ToDouble(Console.ReadLine());
        double y = Math.Round((1 + 2 * x) / (1 + Math.Sqrt(2 + 3 + x * x)), 3);
        Console.WriteLine($"Результат: y = {y}");
    }
}