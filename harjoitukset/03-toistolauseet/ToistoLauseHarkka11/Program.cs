Console.Write("montako sanaa syötät? (kokonaislukuna): ");
int desired_count = int.Parse(Console.ReadLine());

int counter = 0;
int sum = 0;
int len;

while (counter < desired_count)
{
    Console.Write("sana: ");
    len = Console.ReadLine().Length;
    if (len > 0)
    {
        sum += len;
        counter++;
    }
}

Console.WriteLine("yhteenlaskettu pituus: " + sum);
