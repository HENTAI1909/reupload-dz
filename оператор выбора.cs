//оператор выбора вариант 2 средний уровень стр 31
try
{
    //среднее знач первого набора
    double a = 3, b = 3.5, c = -2.1;
    double middle;

    if ((a >= b && a <= c) || (a <= b && a >= c))
        middle = a;
    else if ((b >= a && b <= c) || (b <= a && b >= c))
        middle = b;
    else
        middle = c;

    Console.WriteLine($"{middle}");
    //среднее знач второго набора
    a = 2.1; b = -6.55; c = 0.1;

    if ((a >= b && a <= c) || (a <= b && a >= c))
        middle = a;
    else if ((b >= a && b <= c) || (b <= a && b >= c))
        middle = b;
    else
        middle = c;

    Console.WriteLine($"{middle}");
    //среднее знач третьего набора
    a = -9; b = -3.7; c = -0.1;

    if ((a >= b && a <= c) || (a <= b && a >= c))
        middle = a;
    else if ((b >= a && b <= c) || (b <= a && b >= c))
        middle = b;
    else
        middle = c;

    Console.WriteLine($"{middle}");
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}
