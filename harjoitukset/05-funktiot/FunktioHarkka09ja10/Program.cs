/*
Harjoitus 9

Kirjoita ohjelma joka tulostaa kertotaulut luvuille 1, 2 ja 3. Jokainen
operaatio tulostetaan omalle rivilleen.
• Yksi rivi outputissa: "2 * 3 = 6”

-- kirjoita funktio kertotaulun tulostamiseen

*/


void TulostaKertotauluLuvulle(int luku)
{
    for (int i = 1; i < 11; i++)
    {
        Console.WriteLine($"{i} * {luku} = {i * luku}");
    }
}

// TulostaKertotauluLuvulle(1);
// TulostaKertotauluLuvulle(2);
// TulostaKertotauluLuvulle(3);
// for (int i = 1; i < 4; i++)
// {
//     TulostaKertotauluLuvulle(i);
// }

/*
Harjoitus 10

Käyttäen edellistä tehtävää hyödyksi, kirjoita funktio joka ottaa
argumenttina vastaan tiedon isoimmasta tulostettavasta kertotaulusta ja
tulostaa kertotaulut annettuun lukuun asti.
• TeeKertotaulut(8) tulostaa kertotaulut luvuille 1,2,3,4,5,6,7 ja 8

*/

void TeeKertotaulut(int n)
{
    for (int luku = 1; luku <= n; luku++)
    {
        TulostaKertotauluLuvulle(luku);
    }
}

TeeKertotaulut(8);
