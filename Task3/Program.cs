int[] GenerateArray(int len, int min, int max)
{
int[] list1 = new int[len];
Random rnd = new Random();
for (int i = 0; i < list1.Length; i++)
{
list1[i] = rnd.Next(min, max + 1);
}
return list1;
}
void PrintArrey(int[] Arrey)
{
for (int i = 0; i < Arrey.Length; i++)
{
System.Console.Write(Arrey[i] + " ");
}
}
int redin(string tex)
{
    Console.WriteLine(tex);
    string number = Console.ReadLine();
    int L = Convert.ToInt32(number);
    int mi = Convert.ToInt32(number);
    int ma = Convert.ToInt32(number);
    return L;
    return mi;
    return ma;
}
int L = redin($"Введите длинну массива");
int mi = redin($"Введите минимальное число массива");
int ma = redin($"Введите максимальное число массива");
int[] number = GenerateArray(L, mi, ma);
PrintArrey(number);