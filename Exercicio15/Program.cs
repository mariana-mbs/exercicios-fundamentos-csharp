Console.Write("Digite uma nota: ");
double nota = double.Parse(Console.ReadLine());
double somaNotas = nota;

for (int i = 1; i < 8; i++)
{
    Console.Write($"Digite a {i + 1}ª nota: ");
    nota = double.Parse(Console.ReadLine());
    
    somaNotas += nota;
}

double mediaNotas = somaNotas / 8;
Console.WriteLine("A média das notas é: " + mediaNotas);