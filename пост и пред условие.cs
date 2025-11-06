//Средний уровень вариант 2 (страница 45)
//пост и пред условие
try
{
    Console.WriteLine("Четные числа кратные 5");

    // предусловие
    int i = 10;
    while (i <= 100)
    {
        Console.Write(i + " ");
        i += 10;
    }

    Console.WriteLine();

    //постусловие
    int j = 10;
    do
    {
        Console.Write(j + " ");
        j += 10;
    }
    while (j <= 100);
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}
