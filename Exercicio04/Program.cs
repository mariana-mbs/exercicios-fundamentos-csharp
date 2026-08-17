Console.Write("Digite um valor em real: R$ ");
double valorReal = double.Parse(Console.ReadLine());

Console.Write("Digite a cotação do dólar: R$ ");
double cotacaoDolar = double.Parse(Console.ReadLine());

double valorDolar = valorReal / cotacaoDolar;
Console.WriteLine($"Valor em dólares: U$ {valorDolar:F2}");
