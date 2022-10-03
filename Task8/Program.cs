Console.WriteLine("Введите число больше 1: ");
string value = Console.ReadLine();
int n = int.Parse(value);

Console.WriteLine();

if (n <= 1)
{
    Console.WriteLine("Неверное число. Вы ввели число меньше 1");
}
else
{
    int count = 2;
    while (count < (n + 1))
    {
        Console.Write(count);
        Console.Write(" ");
        count = count + 2;
    }
}
