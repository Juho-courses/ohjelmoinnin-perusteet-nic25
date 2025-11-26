Console.Write("sana: ");
string eka_sana = Console.ReadLine();

Console.Write("sana: ");
string toka_sana = Console.ReadLine();

if ((eka_sana == "koulu" && toka_sana == "ohjelmointi") || (eka_sana == "ohjelmointi" && toka_sana == "koulu"))
{
    Console.WriteLine("Hienot sanat!");
}
else
{
    Console.WriteLine("Ei huonot sanat.");
}
