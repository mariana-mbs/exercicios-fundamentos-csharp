int somaPares = 0;

for (int i = 1; i <= 100; i++)
{
    if (i % 2 == 0)
    {
        somaPares += i;
    }
}
Console.WriteLine(somaPares);