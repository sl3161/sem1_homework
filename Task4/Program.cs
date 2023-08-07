int num1 = new Random().Next (-20, 20);
int num2 = new Random().Next (-20, 20);
int num3 = new Random().Next (-20, 20);
int max = 0;
if (num1 > max)
{
    max=num1;
}
if (num2 > max)
{
    max=num2;
}
if (num3 > max)
{
    max=num3;
}
Console.Write ("Самое большое число = ");
Console.WriteLine (max);
