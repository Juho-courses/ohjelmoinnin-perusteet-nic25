string sana;
int maara = 0;
string pisin = "";
string lyhyin = "ei tiedetä";
string eka_sana = "";
string vika_sana = "";

while (true)
{
    Console.Write("Anna sana: ");
    sana = Console.ReadLine();

    if (sana == "lopeta")
    {
        break;
    }

    vika_sana = sana;

    if (eka_sana == "")
    {
        eka_sana = sana;
    }

    if (lyhyin == "ei tiedetä" || sana.Length < lyhyin.Length)
    {
        lyhyin = sana;
    }

    if (sana.Length > pisin.Length)
    {
        pisin = sana;
    }

    maara++;

    if (maara == 10) break;
}

Console.WriteLine("Syötit " + maara + " sanaa");
if (maara > 0)
{
    Console.WriteLine("pisin: " + pisin);
    Console.WriteLine("lyhin: " + lyhyin);
    Console.WriteLine("eka sana: " + eka_sana);
    Console.WriteLine("vika sana: " + vika_sana);
}
