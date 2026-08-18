Console.Write("Digite o valor do saque: R$ ");
int valor = int.Parse(Console.ReadLine());

int notas100 = valor / 100;
valor %= 100;

int notas50 = valor / 50;
valor %= 50;

int notas20 = valor / 20;
valor %= 20;

int notas10 = valor / 10;
valor %= 10;

int notas5 = valor / 5;
valor %= 5;

int notas2 = valor / 2;
valor %= 2;

Console.WriteLine($"Notas de R$100: {notas100}");
Console.WriteLine($"Notas de R$50: {notas50}");
Console.WriteLine($"Notas de R$20: {notas20}");
Console.WriteLine($"Notas de R$10: {notas10}");
Console.WriteLine($"Notas de R$5: {notas5}");
Console.WriteLine($"Notas de R$2: {notas2}");