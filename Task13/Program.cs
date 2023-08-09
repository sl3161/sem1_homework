Console.WriteLine("Введите число :");
int number = int.Parse (Console.ReadLine());
int digit = 0;
while (number>1000)
{
    number = number/10;
    digit = (number%10);
    System.Console.WriteLine(number);
    System.Console.WriteLine(digit);
}

System.Console.WriteLine($"3-я цифравведенного числа = {digit}");