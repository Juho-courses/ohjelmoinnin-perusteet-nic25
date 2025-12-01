string[] strings = ["moi", "ei", "hieno"];

foreach (string sana in strings)
{
    if (sana.Length < 3)
    {
        continue;
    }
    Console.WriteLine(sana);
}
