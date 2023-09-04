/*Задайте одномерный массив, заполненный
случайными числами. Найдите сумму элементов, стоящих
на нечётных позициях.*/
int min = Promt ( "Введите начальное значение массива");
int len = Promt ( "Введите длину массива");
int max = Promt ("Введите конечный элемент массива");
int [] Array = GetRandomArray (len, min, max);
PrintArray (Array);
int sum = SumOfNumbersOnOddPosition ( Array);
System.Console.WriteLine( $"Cумма элементов, стоящих на нечётных позициях = { sum }");

int Promt ( string massage)
{
    Console.WriteLine ( massage);
    int result = int.Parse ( System.Console.ReadLine());
    return result;
}

int SumOfNumbersOnOddPosition (int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i=i+2)
    {
        sum += arr [i];
    }
    return sum;
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

