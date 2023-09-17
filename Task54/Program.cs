// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой 
// строки двумерного массива


int [,] array = GenerateRandomArray (6,8);
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
    int finisharrange = array.GetLength(1)-1;    //начальное значение индекса последнего элемента неупорядоченной части массива
        for (int j = 0; j < array.GetLength(1)-1; j++)

        {
            int temp = 0;               
            int k=0;
            int min = array[i,0];      //записываем в мин 0 элемент строки
            int indexmin = 0;              //обнуляем значение индека мин элемента
            while (k< finisharrange)   //цикл поиска мин значения от 0 элемента до конца неупорядоченной части массива
            {
                if (array [i, k+1] < min )  //сравнение следующего элемента массива с текущим
                {   
                    indexmin = k+1;         //запись значения меньшего их сравниваемых элементов и его индекса
                    min = array[i,k+1];
                }
                 k++;   
            }
            temp = array [i, finisharrange];
            array[i, finisharrange ] = array [i, indexmin];  //ставим мин элемент на последнее место в неупорядоченной части массива
            array [i, indexmin] = temp;                      //меняем местами элементы
            finisharrange--;                                 //меняем индекс конца неупорядоченной части массива
        }
    }
}
