float n1 = 0, n2 = 0, n3 = 0, n4 = 0, resultado;
int opcao;

Console.WriteLine("Informe o primeiro valor:");
n1 = float.Parse(Console.ReadLine());

while (n2 == 0)
{
    Console.WriteLine("Informe o segundo valor:");
    n2 = float.Parse(Console.ReadLine());
}

do
{
    Console.WriteLine("Informe o terceiro valor:");
    n3 = float.Parse(Console.ReadLine());
} while (n3 == 0);


for (n4 = 0; n4 == 0;)
{
    Console.WriteLine("Informe o quarto valor:");
    n4 = float.Parse(Console.ReadLine());
}

Console.WriteLine("Informe a operação desejada:");
Console.WriteLine("1 - Adição");
Console.WriteLine("2 - Subtração");
Console.WriteLine("3 - Multiplicação");
Console.WriteLine("4 - Divisão");

opcao = int.Parse(Console.ReadLine());

if  (opcao == 1)
{
    resultado = n1 + n2 + n3 + n4;
    Console.WriteLine("o resultado é " + resultado);
}
else
{
    if (opcao == 2)
    {
        resultado = n1 - n2 - n3 - n4;
        Console.WriteLine($"o resultado é {resultado}");
    }
    else
    {
        if (opcao == 3)
        {
            resultado = n1 * n2 * n3 * n4;
            Console.WriteLine("o resultado é " + resultado);
        }
        else
        {
                resultado = n1 / n2 / n3 / n4;
                Console.WriteLine("o resultado é " + resultado);
        }
    }
}