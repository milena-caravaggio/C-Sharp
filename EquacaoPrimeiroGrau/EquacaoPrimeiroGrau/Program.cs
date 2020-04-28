using System;

namespace EquacaoPrimeiroGrau
{
    public class Program
    {
        
        public static void Main(string[] args)
        {
            double a, b, c;
            Console.WriteLine("Programa para resolver equação de primeiro grau como no exemplo: ax + b = c ");

            Console.WriteLine("Digite o valor de 'a':");
            a = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"{GetSignal(a)} ax  b = c");
            Console.WriteLine("Agora digite o valor de 'b': ");
            b = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"{a}x {GetSignal(b)} {b}b = c");
            Console.WriteLine("Digite o valor do resultado 'c':");
            c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Sua equação ficou assim {GetSignal(a)} {a} x {GetSignal(b)} {b} = {c}");
           

            double result;
                  
            
            result = c - b;
            result = result / a;
            Console.WriteLine("O resultado é:" + result);
           
        }

    
        


        private static string GetSignal(double b)
        {
            return (b.ToString().StartsWith("-") ? string.Empty : "+");
        }

        public static double equacaoMenos(double a, double b, double c)
        {
            double result = c + b;
            result = result / a;
            Console.WriteLine(result);
            return result;
        }

        private static double equacaoMais(int a, int b, int c)
        {
            double result = c - b;
            result = result / a;
            Console.WriteLine(result);
            return result;
        }
    }
}
