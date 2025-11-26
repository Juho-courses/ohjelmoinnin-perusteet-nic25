Console.Write("kirjoita sana: ");
string eka_sana = Console.ReadLine();

Console.Write("kirjoita sana: ");
string toka_sana = Console.ReadLine();

if (eka_sana.Length > toka_sana.Length)
{
    Console.WriteLine(eka_sana);
}
else if (eka_sana.Length < toka_sana.Length)
{
    Console.WriteLine(toka_sana);
}
else
{
    int yht_pituus = eka_sana.Length + toka_sana.Length;
    Console.WriteLine(yht_pituus);
}
