int redin(string tex)
{
    Console.WriteLine(tex);
    string number = Console.ReadLine();
    int number1 = Convert.ToInt32(number);
    int number2 = Convert.ToInt32(number);
    return number2;
    return number1;
}
int number1 = redin($"Введите число A");
int number2 = redin($"Введите число B");

int Degree(int sum)
{

        int num = 1;
    for (int count = 1; count <= number2; count++)
    {
        num = number1 * num;
    }
    return num;
}
int sum = Degree(number1);
Console.WriteLine(sum);
