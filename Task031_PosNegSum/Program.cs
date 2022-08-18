int[] array = new int[12];
int len = array.Length;
int index = 0;
int respos = 0;
int resneg = 0;
while (index < len)
{
    array[index] = new Random().Next(-10, 10);
    index++;
}

for (int i = 0; i < len; i++)
{
    if (array[i] < 0)
    {
        resneg += array[i];
    }
    else
    {
        respos += array[i];

    }
    Console.Write(array[i] + " ");
}
Console.Write(" \n");
Console.WriteLine($"сумма положительных = {respos}, сумма отрицательных = {resneg}");