using System;


namespace Calculadora.ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] historicoOperacoes = new string[100];

            int contadorHistorico = 0;
          

            string opcao = "0";
            decimal numero1 = 0, numero2 = 0;
            bool tabuada = false;


            while (true)

            {
                Console.Clear();
                Console.WriteLine("Calculadora Tabaja 2025 \n");

                Console.WriteLine("1 - Somar\n2 - Subtrair\n3 -  Multiplicar\n4 - Dividir\n5 - Tabuada\n6 - Historico Operações\n7- Sair");
                opcao = Console.ReadLine().ToUpper();



                if (opcao == "S")
                {
                    break;
                }

                else if (opcao == "5")
                {
                    tabuada = true;
                    Console.WriteLine("--------------------------------");
                    Console.WriteLine("Tabuada");
                    Console.WriteLine("--------------------------------");

                    Console.Write("Digite o número: ");
                    int numeroTabuada = Convert.ToInt32(Console.ReadLine());

                    for (int contador = 1; contador <= 10; contador++)
                    {
                        int resultadoTabuada = numeroTabuada * contador;

                        Console.WriteLine($"{numeroTabuada} x {contador} = {resultadoTabuada}");
                    }
                    
                }




                else if (opcao == "6")
                {
                    Console.WriteLine("--------------------------------");
                    Console.WriteLine("Histórico de Operações");
                    Console.WriteLine("--------------------------------");

                    for (int contador = 0; contador < historicoOperacoes.Length; contador++)
                    {
                        string valorAtual = historicoOperacoes[contador];

                        if (valorAtual != null)
                            Console.WriteLine(valorAtual);
                    }

                    Console.WriteLine("Aperte ENTER para continuar");
                    Console.ReadLine();
                    continue;
                }

                decimal resultado = 0;

                 if (tabuada == false)
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


                contadorHistorico += 1;

                
               
                if (opcao == "7")
                {
                    break;
                }




                if (tabuada == false)
                {
                    Console.WriteLine($"Resultado : {resultado.ToString("F2")}");

                }
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