using System.ComponentModel;
using System.Globalization;
using System.Numerics;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace HelloWorld;

class Program
{

    static void Main()
    {


        //Exercício 1
        //Crie um programa em que o usuário precisa digitar um nome e uma mensagem de boas vindas personalizada com o nome dele é exibida:  Olá, Welisson! Seja muito bem - vindo!

        string nome;

        string mensagemDeBoasVindas = "Seja muito bem vindo(a)!";

        Console.WriteLine("Olá, usuário, digite o seu nome: ");
        nome = Console.ReadLine();

        Console.WriteLine($"Olá, {nome}!, {mensagemDeBoasVindas}");

        //Exercicio  2
        //Crie um programa que concatene um nome e um sobrenome inseridos pelo usuário e ao final exiba o nome completo.

        Console.WriteLine("Agora digite seu sobrenome: ");
        string sobreNome = Console.ReadLine();

        Console.WriteLine($"Seu nome completo e: {nome} {sobreNome}");


        //Exercicio 3
        // Crie um programa com 2 valores do tipo * *`double`**já declarados**** que retorne:
        // A soma entre esses dois números;
        // A subtração entre os dois números;
        // A multiplicação entre os dois números;
        // A divisão entre os dois números(vale uma verificação se o segundo número é 0!);
        // A média entre os dois números.

        Console.WriteLine("Digite um valor");
        double valorUm = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite outro valor");
        double valorDois = double.Parse(Console.ReadLine());

        double SomarValores(double valorUm, double valorDois)
        {

            Console.WriteLine("A soma dos dois valores e: ");
            return valorUm + valorDois;
        }

        Console.WriteLine(SomarValores(valorUm, valorDois));

        double SubtrairValores(double valorUm, double ValorDois)
        {
            Console.WriteLine("A subtração dos dois valores e: ");
            return valorUm - ValorDois;
        }

        Console.WriteLine(SubtrairValores(valorUm, valorDois));

        double? DividirValores(double valorUm, double valorDois)
        {

            if (valorDois <= 0)
            {
                Console.WriteLine("Não é permitido divisões por número menores ou iguas a 0!");
                return null;
            }

            Console.WriteLine("A divisão dos dois valores resultou em: ");
            return valorUm / valorDois;
        }

        Console.WriteLine(DividirValores(valorUm, valorDois));

        double CalcularMediaDosDoisValores(double valorUm, double valorDois)
        {
            Console.WriteLine("A media dos dois valores e: ");
            return (valorUm + valorDois) / 2;
        }

        Console.WriteLine(CalcularMediaDosDoisValores(valorUm, valorDois));

        //Exercicio 4
        //Crie um programa em que o usuário digita uma ou mais palavras e é exibido a quantidade de caracteres que a palavra inserida tem.

        Console.WriteLine("Digite uma ou mais palavra(s)");

        string texto = Console.ReadLine().Trim();

        Console.WriteLine($"O texto digitado tem: {texto.Length} caracteres.");

        //Exercicio 5
        // 1.Crie um programa em que o usuário precisa digitar a placa de um veículo e o programa verifica se a placa é válida, seguindo o padrão brasileiro válido até 2018:
        // A placa deve ter 7 caracteres alfanuméricos;
        // Os três primeiros caracteres são letras(maiúsculas ou minúsculas);
        // Os quatro últimos caracteres são números;

        // Ao final, o programa deve exibir * **Verdadeiro * **se a placa for válida e ***Falso * **caso contrário.

        Console.WriteLine("Digite a placa de um veículo: ");

        string placaVeiculuar = Console.ReadLine().Trim();

        bool VerificaValidadePlacaVeicular(string placaVeicular)
        {
            if (placaVeicular.Length != 7)
            {
                return false;
            }

            if (!char.IsLetter(placaVeicular[0]) || !char.IsLetter(placaVeicular[1]) || !char.IsLetter(placaVeicular[2]))
            {
                return false;
            }

            if (!char.IsDigit(placaVeicular[3]) || 
                !char.IsDigit(placaVeicular[4]) || 
                !char.IsDigit(placaVeicular[5]) ||
                !char.IsDigit(placaVeicular[6]))
            {
                return false;
            }

            return true;
        }

        Console.WriteLine(VerificaValidadePlacaVeicular(placaVeiculuar));

        //Exercicio 6
        // 1.Crie um programa que solicita ao usuário a exibição da data atual em diferentes formatos:
        // Formato completo(dia da semana, dia do mês, mês, ano, hora, minutos, segundos).
        // Apenas a data no formato "01/03/2024".
        // Apenas a hora no formato de 24 horas.
        // A data com o mês por extenso.

        DateTime dataAtual = new DateTime(2026, 09, 16, 13, 16, 00);

        string dataNoFormatoCompleto = dataAtual.ToString("F");
        string apenasData = dataAtual.ToString("dd/MM/yyyy");
        string dataComMesPorExtenso = dataAtual.ToString("d MMMM yyyy");
        string apenasHora = dataAtual.ToString("T");
        
        
        Console.WriteLine($"Data no formato completo: {dataNoFormatoCompleto}");
        Console.WriteLine($"Data apenas no formato xx/xx/xxxx: {apenasData}");
        Console.WriteLine($"Apenas a hora no fromato de 24horas: {apenasHora}");
        Console.WriteLine($"Data com mês pro extenso: {dataComMesPorExtenso}");
    }
}