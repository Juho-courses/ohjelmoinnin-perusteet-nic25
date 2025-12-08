// Luo funktio, jolla on kaksi argumenttia: k (int) ja the_list (int[]). Funktio
// palauttaa kokonaisluvun, joka kertoo moniko the_list-arrayn jäsen on
// arvoltaan suurempi tai yhtä suuri kuin k.
// • FilterNumbers(3, [1,2,3,4,5]) palauttaa kokonaisluvun 3
// • FilterNumbers(6, [1,2,3,4,5]) palauttaa kokonaisluvun 0

int FilterNumbers(int k, int[] the_list)
{
    int count = 0;

    foreach(var luku in the_list)
    {
        if (luku >= k)
        {
            count++;
        }
    }

    return count; 
}

Console.WriteLine(FilterNumbers(3, new int[] {1,2,3,4,5}));
Console.WriteLine(FilterNumbers(6, new int[] {1,2,3,4,5}));
