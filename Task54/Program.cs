// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой 
// строки двумерного массива


int [,] array = GenerateRandomArray (4,7);
PrintArray (array);
System.Console.WriteLine("");
ArrangeRows (array);
System.Console.WriteLine("");
PrintArray(array);

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

void ArrangeRows ( int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int finisharrange = array.GetLength(1);
        for (int j = 0; j < finisharrange; j++)
        {
            int min = array [i, 0];
            int k=0;
            while (k<finisharrange-1)
            
            {
                if (array [i, k+1] > array [i,k] )
                {
                    min = array [i,k+1];
                    array [i, k+1]= array [i,k];
                    array [i,k] = min;   
                }
                k++;
                
            }
            finisharrange--;
        }
    }
}
