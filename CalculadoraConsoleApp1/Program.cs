using System;


namespace Calculadora.ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] historicoOperacoes = new string[100];

            int contadorHistorico = 0;
            decimal resultado = 0;

            string opcao = "0";
            decimal numero1 = 0, numero2 = 0;

            while (true)

            {
                Console.Clear();
                Console.WriteLine("Calculadora Tabaja 2025 \n");

                Console.WriteLine("1 - Somar\n2 - Subtrair\n3 -  Multiplicar\n4 - Dividir\n5 - Tabuada\n6 - Historico Operações\n7- Sair");
                opcao = Console.ReadLine();

                for (int contador = 0; contador < historicoOperacoes.Length; contador++)
                {
                    string operacaoRealizada = historicoOperacoes[contador];
                    Console.WriteLine(operacaoRealizada);

                    string Valoratual = historicoOperacoes[contador];

                    if (Valoratual != null)
                    {
                        Console.WriteLine(Valoratual);
                    }
                }

                if (opcao == "5")
                {
                    Console.WriteLine("Tabuada");

                    Console.WriteLine("Digite o numero que deseja ver a tabuada \n");
                    string tabuadaString = Console.ReadLine();
                    int tabuada = Convert.ToInt32(tabuadaString);

                    for (int contador = 0; contador <= 10; contador++)
                    {
                        int linhaTabuada = tabuada * contador;
                        Console.WriteLine($"{tabuada} x {contador} = {linhaTabuada}");
                    }
                }

                if (opcao != "5")
                {
                    Console.WriteLine("Qual o primeiro numero ");
                    numero1 = decimal.Parse(Console.ReadLine());

                    Console.WriteLine("Qual o segundo numero ");
                    numero2 = decimal.Parse(Console.ReadLine());

                }

                if (opcao == "1")
                {
                    resultado = numero1 + numero2;
                    historicoOperacoes[contadorHistorico] = $"{numero1} +{numero2} = {resultado}";
                }


                if (opcao == "2")
                {
                    resultado = numero1 - numero2;
                    historicoOperacoes[contadorHistorico] = $"{numero1}  - {numero2} = {resultado}";
                }


                if (opcao == "3")
                {
                    resultado = numero1 * numero2;
                    historicoOperacoes[contadorHistorico] = $"{numero1}  X {numero2} = {resultado}";
                }

                if (opcao == "4")
                {
                    if (numero2 == 0)
                    {
                        Console.WriteLine("Não é possivel dividir um numero por zero");
                        Console.ReadLine();
                        continue;
                    }

                    if (numero2 != 0)
                    {
                        resultado = numero1 / numero2;
                        historicoOperacoes[contadorHistorico] = $"{numero1}  / {numero2} = {resultado}";
                    }
                }

                else if (opcao == "6")
                {
                    Console.WriteLine(historicoOperacoes);

                    for (int contador = 0; contador < historicoOperacoes.Length; contador++)
                    {
                        Console.WriteLine(historicoOperacoes[contador]);
                    }
                }

                else if (opcao == "7")
                {

                    break;
                }





                Console.WriteLine($"Resultado : {resultado.ToString("F2")}");


                Console.WriteLine("Deseja Continuar? S/N \n");
                string DesejaContinuarString = Console.ReadLine().ToUpper();

                if (DesejaContinuarString == "N")

                {
                    break;
                }
            }



















        }
    }

}