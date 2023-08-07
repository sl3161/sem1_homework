int number = new Random ().Next (1, 30);
int count = 1;
while (count<number)
{
    if (count%2 == 0)
    {
        Console.WriteLine (count);
    }
    count = count +1 ;
}

