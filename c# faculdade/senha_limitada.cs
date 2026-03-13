Console.WriteLine("Validador de senha!");
int senha_correta = 123456;
int senha;
int contador = 0;
int limitador = 5;

do
{
    Console.WriteLine("Digite a senha: ");
     senha = int.Parse(Console.ReadLine());
    if(senha != senha_correta)
    {
        Console.WriteLine("Senha incorreta");
        contador++;
    }
    else
    {
        Console.WriteLine("Seja_bem vindo");
    }
    if(contador > limitador)
    {
        Console.WriteLine("Limite de tentativas");
        break;
    }
}while(senha_correta != senha);