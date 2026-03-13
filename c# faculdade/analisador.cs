Console.WriteLine("Analisador de numeros!");

int num ;
int soma = 0;
int media;
int contador = 0;
int maior = 0;

Console.WriteLine("Digite os numeros");
num = int.Parse(Console.ReadLine());

while(num > 0)
{
    contador++;
    soma += num;

    if(num > maior)
    {
        maior = num;
    }
    
    Console.WriteLine("Digite os numeros");
    num = int.Parse(Console.ReadLine());
}
media = soma / contador;

Console.WriteLine($"A soma geral fica = {soma}");
Console.WriteLine($"A media aritmética fica = {media}");
Console.WriteLine($"O maior numero geral e = {maior}");