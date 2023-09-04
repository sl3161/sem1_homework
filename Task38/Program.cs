/*Задайте массив вещественных чисел.
Найдите разницу между максимальным и минимальным
элементов массива..*/

int [] Array = GetRandomArray (10, -88, 46);
PrintArray (Array);
int delta = DeltaMinMaxNumInArray ( Array);
System.Console.WriteLine( $"Hазница между максимальным и минимальным элементом массива = { delta }");


int DeltaMinMaxNumInArray (int[] arr)
{
    int delta = 0;
    int min = arr[0];
    int max = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < min) min = arr[i];
        if (arr[i] > max) max = arr[i];
    }
    delta = max - min;
    return delta;
}

int [] GetRandomArray (int len, int min, int max)
{
    
    int [] res = new int [len];
    for (int i = 0; i < len; i++)
    {
        res[i] = new Random().Next (min, max);
    }
    return res;

}

void PrintArray (int [] res)
{

    for (int i = 0; i < res.Length; i++)
    {
        System.Console.Write ($"{res[i]}  " );
    }
 System.Console.WriteLine("");
}

