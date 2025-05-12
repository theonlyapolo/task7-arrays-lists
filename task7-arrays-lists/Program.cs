int[] numeros = { 5, 10, 20, 30, 12 };
int soma = 0;

foreach (int numero in numeros)
{
    soma += numero;
}

double media = soma / numeros.Length;

Console.WriteLine("Média: " + media);

Console.WriteLine("\r\nNomes com A");
List<string> nomes = new List<string> { "Amanda", "Fernanda", "Marcos", "Apolo", "Carlos", "Eduarda" };
foreach (string nome in nomes)
{
    if (nome.StartsWith("A"))
    {
        Console.WriteLine(nome);
    }
}

