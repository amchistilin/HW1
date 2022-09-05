Console.WriteLine("Введите число N больше 0");
int firstDigit = Convert.ToInt32(Console.ReadLine());
int x = 2; 
try
    {
while (x <= firstDigit)
                {
                if (x%2==0)
                    {
                        Console.WriteLine(x);
                        x = x+2;
                    }
            
    }
catch
{
    Console.WriteLine("Надо было вводить именно целые числа число");
}
