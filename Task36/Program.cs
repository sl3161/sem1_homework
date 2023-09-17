/*Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.*/
int len = Promt ( "Cколько чисел нужно ввести ?");
int [] Array = InputArray (len);
PrintArray (Array);
int sum = SumOfNumberBiggerZero ( Array);
System.Console.WriteLine( $"Cумма элементов больше 0  = { sum }");

int Promt ( string massage)
{
    Console.WriteLine ( massage);
    int result = int.Parse ( System.Console.ReadLine());
    return result;
}

int SumOfNumberBiggerZero (int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if arr[i] >0 sum += arr [i];
    }
    return sum;
}

int [] InputArray (int len)
{
    
    int [] res = new int [len];
    for (int i = 0; i < len; i++)
    {
        res[i] = Promt ("Введите значение :");
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

