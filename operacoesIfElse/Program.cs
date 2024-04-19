//faça um programa que leia dois números e ofereça ao usuario a opção de fazer cada uma das
//quatro operações básicas 

double num1 = 0;
double num2 = 0;
int opcao = 0;
double soma = 0;
double sub = 0;
double multi = 0;
double div = 0;

Console.WriteLine("Digite um número");
num1 = double.Parse(Console.ReadLine());

Console.WriteLine("Digite um outro número");
num2 = double.Parse(Console.ReadLine());

do
{
    Console.WriteLine("---\nEscolha uma das opções:\n1 - soma; \n2 - subtração \n3 - multiplicação" +
        "\n4 - divisão \n0 - sair\n---");
    opcao = int.Parse(Console.ReadLine());

    if (opcao == 1)
    {
        soma = num1 + num2;
        Console.WriteLine($"soma:{soma};");
    }
    else if (opcao == 2)
    {
        sub = num1 - num2;
        Console.WriteLine($"subtracao:{sub};");
    }
    else if (opcao == 3)
    {
        multi = num1 * num2;
        Console.WriteLine($"multiplicacao:{multi};");
    }
    else if (opcao == 4)
    {
        if (num2 == 0)
        {
            Console.WriteLine($"divisao: Impossivel dividir por 0");
        }
        else
        {
            div = num1 / num2;
            Console.WriteLine($"divisao:{div};");
        }
    }
    else if (opcao == 0)
    {
        Console.WriteLine("Fim");
    }
    else
    {
        Console.WriteLine("Digite uma opção valida!");
    }

} while (opcao != 0);