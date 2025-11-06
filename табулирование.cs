//базовый вариант 2 стр 51
try
{
    double x = 1.0;
    Console.WriteLine("x     |    y");
    while (x <= 3.0)
    {
        double y = x * x - Math.Cos(Math.PI * x) * Math.Cos(Math.PI * x);
        Console.WriteLine($"{x:F1}\t{y:F4}");
        x += 0.2;
    }
}
catch (Exception e)
{
    Console.WriteLine(e.Message);

}
