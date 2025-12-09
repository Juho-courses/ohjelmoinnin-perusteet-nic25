// Kirjoita funktio joka palauttaa sille argumenttina annettavan
// kokonaislukuarrayn suurimman jäsenen
// • [1,3,4,5] palauttaa 5
// • [16,32,4,5] palauttaa 32

int PalautaSuurin(int[] arr)
{
    int suurin = arr[0];

    foreach (int luku in arr)
    {
        if (luku > suurin)
        {
            suurin = luku;
        }
    }

    return suurin;

}

Console.WriteLine(PalautaSuurin(new int[] { 1, 3, 4, 5 }));
Console.WriteLine(PalautaSuurin(new int[] { 16, 32, 4, 5 }));

// Koko PalautaSuurin on turha, koska taulukosta
// saa kysyttyä sen suurimman arvon Max()-funktiolla
int[] arr = new int[] { 16, 32, 4, 5 };
Console.WriteLine(arr.Max());