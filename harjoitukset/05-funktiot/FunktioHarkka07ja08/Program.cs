/*

Harjoitus 7
Kirjoita funktio, jolla on kaksi argumenttia. Funktio tulostaa kahden
annetun argumentin kertolaskun tuloksen.
• Kertolasku(4, 5) tulostaa 20

*/

void Kertolasku(int a, int b)
{
    Console.WriteLine(a * b);
}

Kertolasku(4, 5);

/*

Harjoitus 8

Kirjoita funktio joka ottaa vastaan kaksi kokonaislukuargumenttia ja
palauttaa niiden kertolaskun tuloksen.
• ET saa käyttää kertolasku-operaatiota (*)
• Ei tarvitse käsitellä negatiivisia lukuja

*/

int Kertolasku2(int a, int b)
{
    int tulo = 0;

    // kertolasku on vain monta plus-laskua
    for (int i = 0; i < a; i++)
    {
        tulo += b;
    }

    return tulo;
}

Console.WriteLine($"Pitäisi olla 20: {Kertolasku2(4, 5)}");
Console.WriteLine($"Pitäisi olla 20: {Kertolasku2(5, 4)}");
Console.WriteLine($"Pitäisi olla 0: {Kertolasku2(5, 0)}");
Console.WriteLine($"Pitäisi olla 0: {Kertolasku2(0, 1000)}");