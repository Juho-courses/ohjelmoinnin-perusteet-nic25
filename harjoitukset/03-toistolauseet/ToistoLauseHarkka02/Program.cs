double[] doubles = [3.12, 3.0, 1.1];

double sum = 0.0;

// 2.1
for (int i = 0; i < doubles.Length; i++)
{
    sum += doubles[i];
    // sama kuin sum = sum + doubles[i]
}
Console.WriteLine("summa: " + sum);

Console.WriteLine("----");

// käytetään samaa muuttujaa
sum = 0.0;
int index = 0;
while (true)
{
    sum += doubles[index];
    index++;
    if (index > 2)
    {
        break;
    }
}

Console.WriteLine("summa: " + sum);
Console.WriteLine("----");

// 2.3
sum = 0.0;
foreach (var item in doubles)
{
    sum += item;
}
Console.WriteLine("summa: " + sum);