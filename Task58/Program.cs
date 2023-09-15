//Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
int row = Promt ("Введите размерности матриц");
int col = row;
int [,] matrix1 = GenerateRandomArray (row,col);
int [,] matrix2 = GenerateRandomArray (row,col);
PrintArray (matrix1);
System.Console.WriteLine("");
PrintArray(matrix2);
System.Console.WriteLine("");
int[,] multmatrix = GetMultipleMatrix (matrix1, matrix2);
PrintArray (multmatrix);

int [,] GenerateRandomArray (int rows, int cols)
{
    
    int [,] array = new int [rows, cols];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            array [i,j] = new Random().Next (1, 3);
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

int [,] GetMultipleMatrix ( int [,] matrix1, int [,] matrix2)
{
    int [,] resmatrix = new int [matrix1.GetLength(0), matrix1.GetLength(1)];
    
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix1.GetLength (1); j++)
        {
            for (int k = 0; k < matrix1.GetLength(1); k++)
            {
                resmatrix[i,j] += matrix1[i,k] * matrix2[k,j];
            }
        }
       
    }
    return resmatrix;
}

int Promt (string massage)
{
    Console.WriteLine(massage);
    int result = int.Parse (System.Console.ReadLine() );
    return result;
}