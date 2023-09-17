// Напишите программу, которая заполнит спирально массив 4 на 4

int [,] spiral = new int [4,4];
spiral = SpiralFillingOfTheMatrix(4,4);
PrintArray(spiral);

int [,] SpiralFillingOfTheMatrix (int row, int col)
{
    int [,] matrix = new int [row,col];
    int endX = col-1;
    int endY = row-1;
    int startX = 0;
    int startY = 0;
    int value = 0;

    while (startX<endX &&  startY<endY)   
    {
        for (int i = startX; i <= endX; i++)    //заполнение верхней строки
        {
            matrix [startY, i] = value;
            value++;
        }
        startY++;                              // увеличение начального индекса строки, с которой начинается заполнение

        for (int j = startY; j <= endY; j++)   //Заполение крайнего правого столбца
        {
            matrix [j, endX] = value;
            value++;
        }
        endX--;
        for (int i = endX; i >= startX; i--)   //Заполнение нижней строки
        {
            matrix [endY, i] = value;
            value++;
        }
        endY --;
        for (int i = endY; i >= startY; i--)
        {
            matrix [i, startX] = value;       //заполнение левого столбца
            value++;
        }
        startX++;
    }
    return matrix;

}

void PrintArray (int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i,j]<10) System.Console.Write( $"{0}{array[i,j]}  ");

            else System.Console.Write( $"{array[i,j]}  ");
            
        }
        System.Console.WriteLine("");
    }
}
