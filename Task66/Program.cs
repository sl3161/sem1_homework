//Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в 
//промежутке от M до N.
Console.Write(SumNum(9,13));

int SumNum (int m, int n)
{
    if (m==n-1)
    {
        return 0;

    }

    return m + 1 + SumNum(m+1, n);
}
