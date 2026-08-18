Random random = new Random();
int numeroSorteado = random.Next(1, 101);

Console.Write("Digite um número entre 1 e 100: ");
int numero = int.Parse(Console.ReadLine());

while (numero != numeroSorteado)
{
    if (numero > numeroSorteado)
    {
        Console.WriteLine("O número digitado é maior que o número sorteado.");
    }
    else
    {
        Console.WriteLine("O número digitado é menor que o número sorteado.");
    }

    Console.Write("Tente novamente: ");
    numero = int.Parse(Console.ReadLine());
}

Console.WriteLine("Você acertou!");