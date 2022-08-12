int[] array = new int[8]; 
int len = array.Length;
int index = 0;
while(index < len)
{
    array[index] = new Random().Next(0,2);
    index++;
}
for (int i=0; i<len; i++)
{
Console.Write(array[i]);
}
