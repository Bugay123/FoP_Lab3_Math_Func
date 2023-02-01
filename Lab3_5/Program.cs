internal class Program
{
    private static void Main(string[] args)
    {
        /* Трикутник задається координатами своїх вершин на площині A(1, 3), B(1, 6) , C(6, 3).
           Скласти програму для знаходження площі трикутника за формулою Герона.
           Результат вивести на консоль.*/
        double x1 = 1, x2 = 1, x3 = 6;
        double y1 = 3, y2 = 6, y3 = 3;
        double a = Math.Sqrt(Math.Pow(x3 - x2, 2) + Math.Pow(y3 - y2, 2)); //a
        double b = Math.Sqrt(Math.Pow(x3 - x1, 2) + Math.Pow(y3 - y1, 2)); //b
        double c = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)); //c
        double p = (a + b + c) / 2;
        double S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        Console.WriteLine($"Площа трикутника: {S}");
    }
}