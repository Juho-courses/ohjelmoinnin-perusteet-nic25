string[] sanat = new string[3];

Console.Write("kirjoita sana: ");
string eka_sana = Console.ReadLine();
sanat[0] = eka_sana;

Console.Write("kirjoita sana: ");
sanat[1] = Console.ReadLine();

Console.Write("kirjoita sana: ");
sanat[2] = Console.ReadLine();

Console.WriteLine(sanat[2]);
Console.WriteLine(sanat[1]);
Console.WriteLine(sanat[0]);