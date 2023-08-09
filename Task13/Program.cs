//Чуть усложнил - поиск любой цифры ( номер позиции искомой цифры вводится) в любом числе 
Console.WriteLine("Введите число :");
int number = int.Parse (Console.ReadLine());
System.Console.WriteLine("Введите порядковый номер цифры, которую необходимо найти , в числе ");
int digit_position = int.Parse (Console.ReadLine());
int digit = 0;

if (number >= Math.Pow (10, (digit_position-1)))
{
    while (number > Math.Pow (10, digit_position))
    {
    number = number/10;
    digit = (number%10);
    
    }
    
    
}
else
{
        System.Console.WriteLine($"У введенного числа нет {digit_position} цифры");
        
}


System.Console.WriteLine($" {digit_position} цифра введенного числа = {digit}");