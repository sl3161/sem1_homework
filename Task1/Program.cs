int num1 = new Random().Next (-20, 20);
int num2 = new Random().Next (-20, 20);
if (num1 < num2)
{
    Console.Write ("Меньшее число = ");
    Console.WriteLine (num1);
    Console.Write ("Большее число =");
    Console.WriteLine (num2);
}
else
{
    Console.Write ("Меньшее число = ");
    Console.WriteLine (num2);
    Console.Write ("Большее число =");
    Console.WriteLine (num1);
}