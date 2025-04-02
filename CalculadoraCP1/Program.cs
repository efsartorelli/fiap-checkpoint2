using System;

namespace CalculadoraSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continuar = true;
            while (continuar)
            {
                ExibirMenu();
                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        OperacaoAdicao();
                        break;
                    case "2":
                        OperacaoSubtracao();
                        break;
                    case "3":
                        OperacaoMultiplicacao();
                        break;
                    case "4":
                        OperacaoDivisao();
                        break;
                    case "0":
                        continuar = false;
                        Console.WriteLine("Encerrando a calculadora...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida! Tente novamente.");
                        break;
                }
                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
                Console.Clear(); // Limpa a tela após finalizar a operação
            }
        }

        static void ExibirMenu()
        {
            Console.WriteLine("=====================================");
            Console.WriteLine("             CALCULADORA             ");
            Console.WriteLine("=====================================");
            Console.WriteLine("1 - Adição");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("0 - Sair");
            Console.WriteLine("=====================================");
            Console.Write("Escolha uma opção: ");
        }

        static void OperacaoAdicao()
        {
            Console.WriteLine("\n--- Adição ---");
            double num1 = LerNumero("Digite o primeiro número: ");
            double num2 = LerNumero("Digite o segundo número: ");
            double resultado = num1 + num2;
            Console.WriteLine($"Resultado: {num1} + {num2} = {resultado}\n");
        }

        static void OperacaoSubtracao()
        {
            Console.WriteLine("\n--- Subtração ---");
            double num1 = LerNumero("Digite o primeiro número: ");
            double num2 = LerNumero("Digite o segundo número: ");
            double resultado = num1 - num2;
            Console.WriteLine($"Resultado: {num1} - {num2} = {resultado}\n");
        }

        static void OperacaoMultiplicacao()
        {
            Console.WriteLine("\n--- Multiplicação ---");
            double num1 = LerNumero("Digite o primeiro número: ");
            double num2 = LerNumero("Digite o segundo número: ");
            double resultado = num1 * num2;
            Console.WriteLine($"Resultado: {num1} * {num2} = {resultado}\n");
        }

        static void OperacaoDivisao()
        {
            Console.WriteLine("\n--- Divisão ---");
            double num1 = LerNumero("Digite o primeiro número: ");
            double num2 = LerNumero("Digite o segundo número: ");
            if (num2 == 0)
            {
                Console.WriteLine("Erro: Divisão por zero não é permitida.\n");
                return;
            }
            double resultado = num1 / num2;
            Console.WriteLine($"Resultado: {num1} / {num2} = {resultado}\n");
        }

        static double LerNumero(string mensagem)
        {
            double numero;
            Console.Write(mensagem);
            while (!double.TryParse(Console.ReadLine(), out numero))
            {
                Console.Write("Valor inválido! " + mensagem);
            }
            return numero;
        }
    }
}
