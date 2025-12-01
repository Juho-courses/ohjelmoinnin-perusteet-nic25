for (int i = 0; i< 101;i++)
{
    if (i % 16 == 0)
    {
        Console.WriteLine(i);
    }
}

Console.WriteLine("----");

for (int i = 0; i < 101; i+= 16)
{
    Console.WriteLine(i);
}