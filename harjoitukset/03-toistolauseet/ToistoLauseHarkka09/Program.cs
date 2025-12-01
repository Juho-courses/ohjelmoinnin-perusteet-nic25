int[] ints = new int[10];

for (int i = 0; i < 10; i++)
{
    ints[i] = i * i;
}

// Omille riveilleen 
foreach (var item in ints)
{
    Console.WriteLine(item);
}
Console.WriteLine("----");
// 2 per rivi
for (int i = 0; i < 9; i += 2)
{
    Console.WriteLine(ints[i] + ", " + ints[i+1]);
}