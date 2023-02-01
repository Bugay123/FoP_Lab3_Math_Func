internal class Program
{
    private static void Main(string[] args)
    {
        /* Трикутник заданий координатами своїх вершин А(x 1 ,y 1 ), B(x 2 ,y 2 ), C(x 3 ,y 3 ). Обчислити:
                - площу трикутника;
                - радіус кола, вписаного у трикутник;
                - площу вписаного кола.
            Результати вивести на консоль.
            Координати точок трикутника: A(1,1); B(1,2), C(1,3)

            Завдання с коорденатами A(1,1); B(1,2), C(1,3) не корректне, бо це пряма лiнiя.
            Завдання виконав з координатами A(1,1); B(1,2), C(3,1) */

        double x1 = 1, x2 = 1, x3 = 3;
        double y1 = 1, y2 = 2, y3 = 1;
        double a = Math.Sqrt(Math.Pow(x3 - x2, 2) + Math.Pow(y3 - y2, 2));
        double b = Math.Sqrt(Math.Pow(x3 - x1, 2) + Math.Pow(y3 - y1, 2));
        double c = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        double p = (a + b + c) / 2;
        double S = Math.Round(Math.Sqrt(p * (p - a) * (p - b) * (p - c)));
        double r = Math.Round((S / p), 2);
        double Sk = Math.Round(Math.PI * Math.Pow(r, 2),2);
        Console.WriteLine($"Площа трикутника = \t{S}\nРідіус кола = \t\t{r}\nПлоща вписаного кола = \t{Sk}");
    }
}