int[] array = {6, 7, 6, 3};
int len = array.Length;
int index = 0;

Console.Write("Массив = ");
while (index < len)
{
//    array[index] = new Random().Next(-10, 10);
    Console.Write(array[index]); 
    Console.Write(" ");
    index++;
}
Console.WriteLine();
index = 0;
if (len % 2 == 0) {
    while (index < len / 2){
        Console.Write(array[index] * array[len - index - 1] + " ");
        index += 1;
    }
}
else {
    while (index < len / 2){
        Console.Write(array[index] * array[len - index - 1] + " ");
        index += 1;
    }
    Console.Write(array[index]);
}
