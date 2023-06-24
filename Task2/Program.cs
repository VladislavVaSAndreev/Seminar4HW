int Prompt(string message)
{
    System.Console.Write($"{message} > ");
    string inputedStr = Console.ReadLine();
    int value;
    if (int.TryParse(inputedStr, out value))
    {
        return value;
    }
    System.Console.WriteLine("Извините, но вы ввели не число");
    Environment.Exit(0);
    return 0;
}
int number = Prompt("Введите число");

int sum =0;
int count = 0;
while (0<number)
{
   count=number%10;
   number=number/10;
   sum+=count;
}
System.Console.WriteLine(sum);
