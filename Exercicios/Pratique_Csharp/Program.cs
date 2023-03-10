/* 1- Crie um programa que peça ao usuário para digitar um número inteiro e verifique
se o número é par ou ímpar. Em seguida, imprima na tela uma mensagem informando o resultado. */

/* 2- Crie um programa que calcule a média de três notas informadas pelo usuário.
 Em seguida, imprima na tela a média calculada */

/* 3- Crie um programa que peça ao usuário para digitar um número inteiro positivo
 e, em seguida, imprima todos os números pares entre 1 e o número informado. */

Console.WriteLine("Qual atividade você quer ver? (1~3)");
int opcao = int.Parse(Console.ReadLine());
switch (opcao)
{
    case 1:
        Console.WriteLine("Digite um número inteiro: ");
        int num = int.Parse(Console.ReadLine());

        if (num % 2 == 0)
        {
            Console.WriteLine("O número é par!");
        }
        else
        {
            Console.WriteLine("O número é ímpar!");
        }
        break;
    case 2:
        double soma = 0.0;

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("Digite um número:");
            double nmr = double.Parse(Console.ReadLine());
            soma += nmr;
        }

        double media = Math.Round((soma / 3), 2);
        Console.WriteLine("A média é: " + media);
        break;
    case 3:
        Console.WriteLine("Digite um número inteiro positivo: ");
        int numPositivo = int.Parse(Console.ReadLine());

        for (int j = 1; j <= numPositivo; j++) {
            if (j % 2 == 0) {
                Console.Write(j);
                Console.Write("-");
            }
        }
        break;
    default:
        Console.WriteLine("Opção inválida");
        break;
}







