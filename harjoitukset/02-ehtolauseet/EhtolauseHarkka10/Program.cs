Console.Write("kokonaisluku: ");
// ReadLine() antaa aina stringin
string eka_syote = Console.ReadLine();
// muutetaan merkkijono kokonaisluvuksi
int eka_luku = int.Parse(eka_syote);


Console.Write("kokonaisluku: ");
// annetaan readlinen palautta merkkijono
// int.Parselle kulkematta muuttujan kautta
int toka_luku = int.Parse(Console.ReadLine());

// (ensin lasketaan muuttujien summa)
Console.WriteLine("summa: " + (eka_luku + toka_luku));
