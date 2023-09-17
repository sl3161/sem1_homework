// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
//Выполнить с помощью рекурсии
Console.Write(PrintNum(8));

string PrintNum (int n)
{
    if (n==1)
    {
        return 1.ToString();

    }

    return n + " " + PrintNum(n-1);
}
