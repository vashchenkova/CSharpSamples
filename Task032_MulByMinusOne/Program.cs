int[] array = { 1, 2, 3, 4, 5 };
int len = array.Length;
int index = 0;

while (index < len)
{
    array[index] = new Random().Next(-10, 10);
    index++;
}

for (int i = 0; i < array.Length; i++)
{
    array[i] = array[i] * -1;
    Console.Write(array[i]); 
    Console.Write(" ");
}
