Console.WriteLine("Введите целое число");
int number = int.Parse (Console.ReadLine ());
Console.WriteLine (number%2 != 0 ? "Число нечетое" : "Число четное");