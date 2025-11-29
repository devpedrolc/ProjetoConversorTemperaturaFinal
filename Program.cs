using System;
using System.Globalization;


namespace ProgramaConversorTemperatura {


    class Program  {
        static void Main()
        {
            double temperatura = 0;
            bool entradaValida = false;

            while (!entradaValida)
            {
                //
                
                try
                {
                    Console.WriteLine("Digite o valor para conversão de temperatura:");
                    string input = Console.ReadLine();

                    // Verifica se o usuário digitou '*' para sair
                    if (input == "*")
                    {
                        Console.WriteLine("Programa encerrado pelo usuário.");
                        return;
                    }

                    // Tenta converter a entrada
                    temperatura = double.Parse(input);

                    // Verifica se a temperatura está dentro do limite físico
                    if (temperatura < -273.15)
                    {
                        Console.WriteLine("Valor inválido! Temperatura abaixo do zero absoluto (-273.15°C).");
                        continue;
                    }

                    entradaValida = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Erro: Formato inválido. Digite apenas números.");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Erro: Valor muito grande ou muito pequeno.");
                }
                
            }

            // Continua com a conversão da temperatura
            Console.WriteLine($"Temperatura digitada: {temperatura.ToString(CultureInfo.InvariantCulture):F2}Cº",CultureInfo.InvariantCulture);

            // Exemplo de conversão para Fahrenheit
            double fahrenheit = (temperatura * 9 / 5) + 32;
            Console.WriteLine($"Temperatura em Fahrenheit: {fahrenheit.ToString(CultureInfo.InvariantCulture):F2}F°");

            // Exemplo de conversão para Kelvin
            double kelvin = temperatura + 273.15;
            Console.WriteLine($"Temperatura em Kelvin: {kelvin.ToString(CultureInfo.InvariantCulture):F2}Kº",CultureInfo.InvariantCulture);
        }
    }
}