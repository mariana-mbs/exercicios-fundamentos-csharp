Console.WriteLine("Digite uma senha: ");
string senha = Console.ReadLine();

while (senha.Length < 8)
{
    Console.WriteLine("Senha inválida! A senha deve ter pelo menos 8 caracteres.");
    Console.WriteLine("Digite uma senha: ");
    senha = Console.ReadLine();
}
Console.WriteLine("Senha válida!");