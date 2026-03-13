
Console.WriteLine("Tabuada!");

Console.WriteLine("Digite a tabuada que deseja saber: ");
int num = int.Parse(Console.ReadLine());

Console.WriteLine("Ate que numero deve ser multiplicado: ");
int multi = int.Parse(Console.ReadLine());

for( int i = 1;i <= multi; i++)
{
    int resultado = num * i;
    Console.WriteLine($"{num} x {i} = {resultado}");
}