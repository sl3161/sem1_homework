// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int res = GetAPowB (3, 3);

System.Console.WriteLine(res);
int GetAPowB (int a, int b)
{
    int result = a;
    for (int count = 1; count < b; count++)
    {
        result *= a;
    }
    return result;
    
}

