using System;

namespace Estagio
{
    public class Program
    {
        static void Main(string[] args)
        {
            int numeroAnterior = 0;
            int numeroAtual = 1;
            int ateNumero;
            int fibonacci;


            Console.WriteLine("Informe o numero maximo para o Fibonacci");
            ateNumero = Convert.ToInt32(Console.ReadLine());

            do
            {
                fibonacci = numeroAnterior + numeroAtual;
                Console.WriteLine(fibonacci);
                numeroAnterior = numeroAtual;
                numeroAtual = fibonacci;
            }

            while (fibonacci <= ateNumero);

        }
    }
}
