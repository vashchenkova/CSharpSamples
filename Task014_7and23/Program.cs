Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());

bool ismultiplicity(int a)
{
    return (a % 7 == 0 & a % 23 ==0);
}
if (ismultiplicity(n)) {
    Console.WriteLine("Делится!");
}

else {
    Console.WriteLine("Не делится!");
}
