string fname = "Juho";
int fname_len = fname.Length;

Console.WriteLine("Merkkijono " + fname + " on " + fname_len + " merkkiä pitkä.");

// Tai
Console.WriteLine($"Merkkijono {fname} on {fname_len} merkkiä pitkä.");

// Tai ilman pituuden tallentamista muuttujaan
Console.WriteLine($"Merkkijono {fname} on {fname.Length} merkkiä pitkä.");