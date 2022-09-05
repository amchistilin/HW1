Console.WriteLine("Введите первое число ");
 int firstDigit = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число ");
 int secondDigit = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число ");
 int thirdDigit = Convert.ToInt32(Console.ReadLine());
int max = 0;
try
    {
        if (firstDigit > secondDigit)
        {
            max = firstDigit;
        }
        else
        {
            max = secondDigit;
        }
            if (max < thirdDigit)
            {
                max = thirdDigit;
            }
            
       Console.WriteLine("Максимальное число " + max);
        }
catch
{
    Console.WriteLine("Надо было вводить именно целые числа число");
}
