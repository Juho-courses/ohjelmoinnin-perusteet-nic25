int[] LuoArray(int n)
{
    // luo array koko n+1
    int[] ints = new int[n + 1];

    // populoidaan array vaadituilla arvoilla
    // n = 5, [0,1,2,3,4,5]
    for (int i = 0; i <= n; i++)
    {
        ints[i] = i;
    }

    // palautetaan array
    return ints;
}

void TulostaArray(int[] tmp)
{
    foreach (int luku in tmp)
    {
        Console.Write(luku + ", ");
    }
    Console.WriteLine();
}

int[] tmp = LuoArray(5);
TulostaArray(tmp);

TulostaArray(LuoArray(12));
TulostaArray(LuoArray(1));
TulostaArray(LuoArray(0));
