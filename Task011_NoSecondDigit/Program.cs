int n = new Random().Next(100, 1000);
Console.WriteLine(n);

int withoutsecond(int n)
{
    int first = n / 100;
    int third = n % 10;
    return first * 10 + third;
}
Console.WriteLine(withoutsecond(n));

