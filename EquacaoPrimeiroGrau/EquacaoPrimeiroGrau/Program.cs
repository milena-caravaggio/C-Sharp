using System;

namespace EquacaoPrimeiroGrau
{
    public class Program
    {
        
        public static void Main(string[] args)
        {
            double a, b, c;
            Console.WriteLine("Programa para resolver equação de primeiro grau como no exemplo: Ax + B = C ");

            Console.WriteLine("Digite o valor de 'A':");
            a = GetValue();

            Console.WriteLine("Agora digite o valor de 'B': ");
            b = GetValue();

            Console.WriteLine("Digite o valor do resultado 'C':");
            c = GetValue();
            Console.WriteLine($"Sua equação ficou assim {GetSignal(a)} {a} x {GetSignal(b)} {b} = {c}");

            double result = c - b;
            result /= a;
            Console.WriteLine("O resultado de X é: " + Math.Round(result, 4));

        }

        private static double GetValue()
        {
            return Convert.ToDouble(Console.ReadLine().Replace(".", ","));
        }

        private static string GetSignal(double b)
        {
            return (b.ToString().StartsWith("-") ? string.Empty : "+");
        }
    }
}
