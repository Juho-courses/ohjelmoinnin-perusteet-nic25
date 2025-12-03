string[] juomat = ["maito", "vesi", "kahvi", "tee", "limsa"];

Console.WriteLine("Vaihtoehdot:");

for (int i = 0; i < juomat.Length; i++)
{
    Console.WriteLine("    " + i + ": " + juomat[i]);
}

Console.WriteLine();

Console.Write("Valintasi [0-" + (juomat.Length - 1) + "]: ");

int valinta = int.Parse(Console.ReadLine());

if (valinta >= 0 && valinta < juomat.Length)
{
    Console.WriteLine(juomat[valinta] + "! Hyvä valinta.");
}
else
{
    Console.WriteLine("viallinen vaihtoehto!");
}