Console.Write("Digite um número inteiro: ");
int numero = int.Parse(Console.ReadLine());
int soma = 0;

while (numero != 0)
{
    Console.Write("Digite outro número, ou 0 para sair e somar: ");
    soma += numero;
    numero = int.Parse(Console.ReadLine());
    
}
Console.WriteLine($"A soma dos números digitados é: {soma}");