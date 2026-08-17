Console.Write("Digite a base: ");
double baseRetangulo = double.Parse(Console.ReadLine());

Console.Write("Digite a altura: ");
double alturaRetangulo = double.Parse(Console.ReadLine());

double area = baseRetangulo * alturaRetangulo;
double perimetro = 2 * (baseRetangulo + alturaRetangulo);

Console.WriteLine($"Área do retângulo: {area}");
Console.WriteLine($"Perímetro do retângulo: {perimetro}");

