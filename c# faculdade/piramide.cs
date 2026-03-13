
Console.WriteLine("Piramide!");

Console.WriteLine("Altura da ponte: ");
int altura = int.Parse(Console.ReadLine());

for(int i = 1;i <= altura; i++)
{
    for(int j = 1; j <=i; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}