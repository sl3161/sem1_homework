//Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку 
//с наименьшей суммой элементов
int [,] array = GenerateRandomArray (5,5);
PrintArray ( array);
System.Console.WriteLine("");
System.Console.WriteLine($"Индекс строки с  наименьшей сумммой элементов - {GetNumberOfRowWithMinSumm(array)}");

int [,] GenerateRandomArray (int rows, int cols)
{
    
    int [,] array = new int [rows, cols];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            array [i,j] = new Random().Next (1, 50);
        }
    }
    return array;
}

void PrintArray (int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i,j] + " ");
        }
        System.Console.WriteLine("");
    }
}

int GetNumberOfRowWithMinSumm (int [,] arr)
{
    int indexminsum = 0;
    int sumlastrow = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sum = sum + arr [i,j];
        }
        if (sum<sumlastrow ) 
        {
        indexminsum = i;
        }
        sumlastrow = sum;
    }
    return indexminsum;
}