Console.Write("Digite o 1º número: ");
int maior = int.Parse(Console.ReadLine());
int posicaoMaior = 1;

for (int i = 2; i <= 10; i++)
{
    Console.Write($"Digite o {i}º número: ");
    int numero = int.Parse(Console.ReadLine());

    if (numero > maior)
    {
        maior = numero;
        posicaoMaior = i;
    }
}
Console.WriteLine($"O maior número é {maior} e está na posição {posicaoMaior}.");