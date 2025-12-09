// Kirjoita funktio, joka laskee argumenttina saatavan kokonaislukutaulukon
// jäsenten summan ja tulostaa lasketun summan
// • LaskeSumma([1,2,3]) tulostaa 6

void KerroSumma(int[] arr)
{
    // Vaihtoehto 1, lasketaan käsin
    int summa = 0;
    foreach (var item in arr)
    {
        summa += item;
    }
    Console.WriteLine(summa);

    // Vaihtoehto 2, ei lasketa käsin
    // Console.WriteLine(arr.Sum());
}

int[] taulukko = new int[] { 1, 2, 3 };
KerroSumma(taulukko);
