// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.WriteLine(GetSumDigitInNumber (65));

int GetSumDigitInNumber (int num)
{
    int sum = 0;
    while (num>0)
    {
        sum = sum + num%10;
        num = num/10;
        
    }
    return sum;
}
