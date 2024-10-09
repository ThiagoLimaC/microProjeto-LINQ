Console.WriteLine("## LINQ ##\n");

IList<string> frutas = new List<string>() { "Banana", "Maça", "Pera", "Laranja", "Uva"};

// query syntax

var resultado = from f in frutas
                where f.Contains('r')
                select f;

Console.WriteLine(String.Join(" ", resultado));

Console.ReadKey();
