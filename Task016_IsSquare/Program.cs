Console.Write("Введите число a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число b: ");
int b = Convert.ToInt32(Console.ReadLine());
if (a * a == b)
{
    Console.WriteLine("b - квадрат a");
    return;
}
if (b * b == a)
{
    Console.WriteLine("a квадрат b");
}
else
{
    Console.WriteLine("не является");
}



