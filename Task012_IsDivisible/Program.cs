int a = 0;
int b = 0;

Console.WriteLine("Введите делимое" );
a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите делитель" );
b = Convert.ToInt32(Console.ReadLine());

int r = a % b;
if (r == 0)
{
    Console.WriteLine("Делится!" );
}
else
{
    Console.WriteLine("Не делится, остаток = " + r);
}

