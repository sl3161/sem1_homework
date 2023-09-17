Console.WriteLine("Ведите 3-х значное число");
int number = int.Parse (Console.ReadLine());
System.Console.WriteLine($"Вторая цифра введенного числа = {((number-number%10)/10)%10}");
