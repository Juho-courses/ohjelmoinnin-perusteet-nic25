string[] sanat = new string[3];

for (int i = 0; i < 3; i++)
{
    Console.Write("kirjoita sana: ");
    string sana = Console.ReadLine();
    sanat[i] = sana;
}

for (int i = 2; i >= 0; i--)
{
    Console.WriteLine(sanat[i]);
}