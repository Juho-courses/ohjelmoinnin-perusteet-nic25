int TulostaNimiJaPalautaPituus(string sana)
{
    Console.WriteLine("Tulostetaan: " + sana);
    int pituus = sana.Length;
    return pituus;
}

int pituus = TulostaNimiJaPalautaPituus("moro");
Console.WriteLine(pituus);

// int TeePlusLasku(int a, int b)
// {
//     return a + b;
//     Console.WriteLine("tätä ei nähdä ikinä");
// }

// int summa = TeePlusLasku(1, 2);
// Console.WriteLine(summa);