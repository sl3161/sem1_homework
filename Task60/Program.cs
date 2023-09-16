//Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.Массив размером 2 x 2 x 2

int [,,] array = GenerateRandomArray (2,2,2);
PrintArray(array);

int [,,] GenerateRandomArray (int rows, int cols, int cols1)
{
    int [,,] array = new int [rows, cols, cols1];
    int n = 0;
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            for (int k = 0; k < cols1; k++)
            {
                array[i,j,k] = GenerateRowDifferentNumder(rows*cols*cols1)[n]; //заполнение массива из ряда 
                n++;                                                           //разных случайных чисел
            }
        }
    }
    return array;
}

int [] GenerateRowDifferentNumder (int length)  //получение ряда случайных разных чисел 
{                                               //длина ряда = кол ву необходимых чисел для заполнения массива
    int [ ] row = new int [length];
    for (int j = 0; j < length; j++)
    {
        row[j]= new Random().Next(10,99);
        int i = 0;
        while (i<=j)
        {
            if (row[j]!=row[i] || i==j) i++;       //проверка сгенерированного случайного числа на 
            else                                   //наличие таких же чисел в массиве
            { 
                row[j]= new Random().Next(10, 99); //при наличии генерирование нового числа и повторная проверка           
                i=0;
            }
        }   
    }
       return row;    
}

void PrintArray (int [,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                System.Console.Write( $" {array[i,j,k]}-{i}{j}{k}  ");
            }
        }
        System.Console.WriteLine("");
    }
}