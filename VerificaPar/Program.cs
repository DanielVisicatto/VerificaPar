Console.Write("Informe o número a ser verificado: ");

if (!int.TryParse(Console.ReadLine(), out var num))
{
    Console.WriteLine("Precisa ser número inteiro!");
}
else
{
    if (num % 2 == 0)
    {
        Console.WriteLine("É Par!");
    }
    else
    {
        Console.WriteLine("É impar!");
    }
}