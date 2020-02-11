using System;

namespace exercicioPrimos
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int ateNumero;
            int numeroPrimo=0;

            Console.WriteLine("Informe o numero maximo para os numeros primos");
            ateNumero = Convert.ToInt32(Console.ReadLine());
            bool ehPrimo = false;

            do
            {
                numeroPrimo++;

                ehPrimo = EhPrimo(numeroPrimo);
                if(ehPrimo)
                {
                      Console.WriteLine(numeroPrimo);
                }
            }
            while (numeroPrimo < ateNumero || !ehPrimo);
        }

        public static bool EhPrimo(int numeroPrimo)
        {
            int metade = numeroPrimo / 2;

            for (int i = metade; i > 1; i--)
            {
                if (numeroPrimo % i == 0)
                {
                    return false;
                }
            }

          
            return true;
        }
    }
}
