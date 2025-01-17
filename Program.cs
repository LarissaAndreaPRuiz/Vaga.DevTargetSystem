using System;
using System.Collections.Generic;
using System.Linq;

class Desafios
{
    static void Main()
    {
        Console.WriteLine("Escolha o número do desafio para executar (1-5):");
        Console.WriteLine("1. Soma com índice");
        Console.WriteLine("2. Verificar número na sequência de Fibonacci");
        Console.WriteLine("3. Análise de faturamento diário");
        Console.WriteLine("4. Percentual de faturamento por estado");
        Console.WriteLine("5. Inverter string");
        int opcao = int.Parse(Console.ReadLine());

        switch (opcao)
        {
            case 1:
                Soma();
                break;
            case 2:
                VerificaFibonacci();
                break;
            case 3:
                FaturamentoDiario();
                break;
            case 4:
                PercentualFaturamento();
                break;
            case 5:
                Inverter();
                break;
            default:
                Console.WriteLine("Opção inválida.");
                break;
        }
    }

    static void Soma()
    {
        int INDICE = 13, SOMA = 0, K = 0;

        while (K < INDICE)
        {
            K = K + 1;
            SOMA = SOMA + K;
        }

        Console.WriteLine($"O valor de SOMA é: {SOMA}");
    }

    static void VerificaFibonacci()
    {
        Console.Write("Informe um número: ");
        int numero = int.Parse(Console.ReadLine());

        if (IsFibonacci(numero))
        {
            Console.WriteLine($"O número {numero} pertence à sequência de Fibonacci.");
        }
        else
        {
            Console.WriteLine($"O número {numero} não pertence à sequência de Fibonacci.");
        }
    }

    static bool IsFibonacci(int num)
    {
        int a = 0, b = 1;

        while (b < num)
        {
            int temp = a + b;
            a = b;
            b = temp;
        }

        return b == num || num == 0;
    }

    static void FaturamentoDiario()
    {
        var dados = new List<decimal> { 100, 200, 0, 300, 0, 400 };

        var diasComFaturamento = dados.Where(x => x > 0).ToList();

        decimal menorValor = diasComFaturamento.Min();
        decimal maiorValor = diasComFaturamento.Max();
        decimal mediaMensal = diasComFaturamento.Average();
        int diasAcimaMedia = diasComFaturamento.Count(x => x > mediaMensal);

        Console.WriteLine($"Menor valor de faturamento: R${menorValor}");
        Console.WriteLine($"Maior valor de faturamento: R${maiorValor}");
        Console.WriteLine($"Dias com faturamento acima da média: {diasAcimaMedia}");
    }

    static void PercentualFaturamento()
    {
        var faturamento = new Dictionary<string, decimal>
        {
            { "SP", 67836.43M },
            { "RJ", 36678.66M },
            { "MG", 29229.88M },
            { "ES", 27165.48M },
            { "Outros", 19849.53M }
        };

        decimal total = faturamento.Values.Sum();

        foreach (var estado in faturamento)
        {
            decimal percentual = (estado.Value / total) * 100;
            Console.WriteLine($"{estado.Key}: {percentual:F2}%");
        }
    }

    static void Inverter()
    {
        Console.Write("Informe uma string: ");
        string texto = Console.ReadLine();
        string textoInvertido = InverterString(texto);
        Console.WriteLine($"String invertida: {textoInvertido}");
    }

    static string InverterString(string str)
    {
        char[] caracteres = str.ToCharArray();
        string invertida = "";

        for (int i = caracteres.Length - 1; i >= 0; i--)
        {
            invertida += caracteres[i];
        }

        return invertida;
    }
}
