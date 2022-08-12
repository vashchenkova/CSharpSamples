Console.Write("Введите номер четверти: ");
int q = Convert.ToInt32(Console.ReadLine());

switch (q)
{
    case 1:
    {
        Console.WriteLine("x > 0, y > 0");
        break;
    }
    case 2:
    {
        Console.WriteLine("x < 0, y > 0");
        break;
    }
    case 3:
    {
        Console.WriteLine("x < 0, y < 0");
        break;
    }
    case 4:
    {
        Console.WriteLine("x > 0, y < 0");
        break;
    }
    
    default:
    {
        Console.WriteLine("Введена неправильная четверть");
        break;
    }
}

