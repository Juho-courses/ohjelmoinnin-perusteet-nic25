// 0 1 2 3 4
int[] ints = new int[5];

ints[0] = 123;
ints[4] = 321;

// for (int i = 0; i < ints.Length; i++)
// {
//     Console.WriteLine(ints[i]);
// }

string[] sanat = ["moi", "SAMK", "pori", "kolme"];
// sanat[0] = "moi";
// sanat[1] = "SAMK";
// sanat[2] = "Pori";
// sanat[3] = "kolme";
foreach (string sana in sanat)
{
    Console.WriteLine(sana);
}

Console.WriteLine(sanat);
