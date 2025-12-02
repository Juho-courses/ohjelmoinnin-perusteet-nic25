string[] sanat = new string[10];

string sana;

int indeksi = 0;
while (true)
{
    Console.Write("Anna sana: ");
    sana = Console.ReadLine();

    if (sana == "lopeta")
    {
        break;
    }

    sanat[indeksi] = sana;
    indeksi++;

    if (indeksi == 10) break;
}

// Console.WriteLine("----");
// foreach (var item in sanat)
// {
//     Console.WriteLine(item);
// }
// Console.WriteLine("indeksi: " + indeksi);
// Console.WriteLine("----");

Console.WriteLine("Syötit " + indeksi + " sanaa");

if (indeksi != 0)
{
    Console.WriteLine("eka sana:" + sanat[0]);
    Console.WriteLine("vika sana:" + sanat[indeksi - 1]);

    string lyhin = sanat[0];
    string pisin = "";
    for (int i = 0; i < indeksi; i++)
    {
        string tmp = sanat[i];

        if (tmp.Length < lyhin.Length)
        {
            lyhin = tmp;
        }

        if (tmp.Length > pisin.Length)
        {
            pisin = tmp;
        }
    }
    Console.WriteLine("pisin: " + pisin);
    Console.WriteLine("lyhin: " + lyhin);
}

