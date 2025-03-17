
using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;

namespace Calculadora.ConsoleApp
{
    // Classe é um contexto de código
    // Uma classe static é uma classe sem varias instancias

    public static class Calculadora
    {
        // Atributos de Classe
        static string[] historicoOperacoes = new string[100];
        static int contadorHistorico = 0;

        public static decimal Somar(decimal primeiroNumero, decimal segundoNumero)
        {


            decimal resultado = primeiroNumero + segundoNumero;
            historicoOperacoes[contadorHistorico] = $"{primeiroNumero} + {segundoNumero} = {resultado}";


            return resultado;

        }

        public static decimal Subtrair(decimal primeiroNumero, decimal segundoNumero)
        {


            decimal resultado = primeiroNumero - segundoNumero;
            historicoOperacoes[contadorHistorico] = $"{primeiroNumero} - {segundoNumero} = {resultado}";


            return resultado;

        }

        public static decimal Multiplicar(decimal primeiroNumero, decimal segundoNumero)
        {


            decimal resultado = primeiroNumero * segundoNumero;
            historicoOperacoes[contadorHistorico] = $"{primeiroNumero} * {segundoNumero} = {resultado}";


            return resultado;

        }


        public static decimal Dividir(decimal primeiroNumero, decimal segundoNumero)
        {


            decimal resultado = primeiroNumero / segundoNumero;
            historicoOperacoes[contadorHistorico] = $"{primeiroNumero} / {segundoNumero} = {resultado}";



            return resultado;

        }

        public static string[] GerarTabuada(int numeroTabuada)
        {
            string[] linhastabuada = new string[10];


            for(int contador = 0; contador < 10; contador++)
            {
                int resultadoTabuada =  numeroTabuada * (contador + 1);
                linhastabuada[contador - 1] = ($"{numeroTabuada} * {contador} = {resultadoTabuada}");




            }
            return linhastabuada;


        }

        public static  string[] obterhistoricodeoperacoes()
        {
            return historicoOperacoes;

        }

        public static  void incrementandoocontadorhistorico()

        {
            contadorHistorico++;
        }

    }
}
