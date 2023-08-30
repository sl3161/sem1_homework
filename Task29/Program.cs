// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

PrintArray (8, 2, 15 );

void PrintArray (int a, int min, int max)
{
    int [] resultarr = new int[a];

    for (int i = 0; i < a; i++)
    {
        resultarr[i] = new Random().Next ( min, max);
        System.Console.Write ($"{resultarr[i]}  " );
    }
    
}
