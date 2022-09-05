Console.WriteLine("Введите первое число ");
int firstDigit = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число ");
int secondDigit = Convert.ToInt32(Console.ReadLine());
try
    {
    if (firstDigit > secondDigit)
    {
        Console.WriteLine ("Первое число больше второго");
    }
    else Console.WriteLine ("Второе число больше первого");
    }
catch
{
    Console.WriteLine("Надо было вводить именно целое число");
}
