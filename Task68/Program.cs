//Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.

Console.WriteLine (Akkerman (2,3));

int Akkerman (int m, int n)
{
    if (m==0)
    {
        return n+1;
    }
    else
    {
       if(m!=0 && n==0)  return Akkerman (m-1, 1);
       else return Akkerman (m-1, Akkerman (m, n-1));    
    }
}
