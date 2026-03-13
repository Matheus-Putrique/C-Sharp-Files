
Console.WriteLine("Fibonacci");

Console.WriteLine("Digite até que parte a sequencia deve ir: ");
int contador = int.Parse(Console.ReadLine());

int num1 = 0;
int num2 = 1;
int num3;


for(int i = 1; i <= contador; i++)
{
    Console.WriteLine(num1 + " ");
    num3 = num1 + num2;
    num1 = num2;
    num2 = num3;
}