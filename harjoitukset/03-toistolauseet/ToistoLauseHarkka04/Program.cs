string[] sanat = new string[3];

int count = 0;

string sana; 
while (count < 3)
{
    Console.Write("kirjoita sana: ");
    sana = Console.ReadLine();
    sanat[count] = sana;
    count++;
}

int index = sanat.Length - 1;
while (index >= 0)
{
    Console.WriteLine(sanat[index]);
    // vähennetään yhdellä
    index--;
}