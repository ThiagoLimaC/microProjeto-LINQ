

using LINQMotivacao1;

Console.WriteLine("## LINQ - Filtrar dados ##\n");

// numeros = 1, 2, 4, 8, 32, 64, 128, 256, 512
var numeros = FonteDados.GetNumeros();

var resultado1 = numeros.Where(n => n < 10);

var resultado2 = numeros.Where(n => n > 1 && n != 4 && n < 20);

Console.WriteLine(string.Join(" ", resultado2));

Console.ReadKey();