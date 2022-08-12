Console.WriteLine("введите число");

int A = int.Parse(Console.ReadLine());
int sum = 0;
for (int i = 1; i <=A; i++)
{
    sum = sum + i;
}
Console.WriteLine($"{sum}");