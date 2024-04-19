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
    Console.WriteLine("\n---\nEscolha uma das opções:\n1 - soma; \n2 - subtração \n3 - multiplicação" +
            "\n4 - divisão \n0 - sair\n---\n");
    opcao = int.Parse(Console.ReadLine());
    switch (opcao)
    {
        case 0:
            break;
        case 1:
            soma = num1 + num2;
            Console.WriteLine($"\nsoma:{soma};");
            break;
        case 2:
            sub = num1 - num2;
            Console.WriteLine($"\nsubtracao:{sub};");
            break;
        case 3:
            multi = num1 * num2;
            Console.WriteLine($"\nmultiplicacao:{multi};");
            break;
        case 4:
            if (num2 == 0)
                Console.WriteLine($"\ndivisao: Impossivel dividir por 0");
            else
            {
                div = num1 / num2;
                Console.WriteLine($"\ndivisao:{div};");
            }
            break;
        default:
            Console.WriteLine("\nDigite uma opção valida!");
            break;
    }
} while (opcao != 0);