string[] sanat = ["moi", "kissa", "koulu", "ohjelmointi", "joulukuu"];

// 1.1
foreach (string sana in sanat)
{
    Console.WriteLine(sana);
}

// 1.2
for (int i = 0; i < sanat.Length; i++)
{
    Console.WriteLine(sanat[i]);
}

// 1.3
int index = 0;
while (index < sanat.Length)
{
    Console.WriteLine(sanat[index]);
    index++;
}