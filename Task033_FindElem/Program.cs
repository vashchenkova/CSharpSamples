int[] array = new int[12];
int len = array.Length;
int index = 0;

while (index < len)
{
    array[index] = new Random().Next(-10, 10);
    index++;
}

Console.Write("Массив = ");


for (int j = 0; j < array.Length; j++)
{
    Console.Write(array[j]); 
    Console.Write(" ");
}
Console.WriteLine();
Console.Write("Введите число: ");
int b = Convert.ToInt32(Console.ReadLine());
bool result = false;


for (int i = 0; i < array.Length; i++)
{
    if (b == array[i])
    {
        result = true;
        break;
    }
}
if (result) {
    Console.WriteLine($"{b} есть в массиве");
}
else {
    Console.WriteLine($"{b} нет в массиве");
}