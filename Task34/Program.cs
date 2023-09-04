/*Задайте массив заполненный случайными
положительными трёхзначными числами. Напишите
программу, которая покажет количество чётных чисел в
массиве.*/
int [] Array = GetRandomArray (10);
PrintArray (Array);
int sum_even = NumberOfEvenNumbers ( Array);
System.Console.WriteLine( $"Количество четных элементов массива = { sum_even }");



int NumberOfEvenNumbers (int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i]%2 == 0) count++;
    }
    return count;
}

int [] GetRandomArray (int len)
{
    
    int [] res = new int [len];
    for (int i = 0; i < len; i++)
    {
        res[i] = new Random().Next (100, 999);
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