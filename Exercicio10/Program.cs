Console.Write("Digite o usuário: ");
string usuario = Console.ReadLine();

Console.Write("Digite sua senha: ");
string senha = Console.ReadLine();

while (senha != "abcde")
{
    Console.Write("Senha incorreta, digite novamente: ");
    senha = Console.ReadLine();
}

Console.WriteLine($"Bem-vindo, {usuario}!");
