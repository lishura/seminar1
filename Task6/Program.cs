Console.WriteLine("Введите число: ");
string value = Console.ReadLine();
int x = int.Parse(value);

if(x%2==0)
{
    Console.WriteLine("Число четное");
}
else
{
    Console.WriteLine("Число нечетное");
}