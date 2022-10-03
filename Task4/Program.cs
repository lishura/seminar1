int a = 48888;
int b = 5699999;
int c = 643;

int max = a;


if (b > a)
{
    max = b;

    if (c > b)
    {
        max = c;
    }

}

Console.Write("Максимальное число ");
Console.WriteLine(max);