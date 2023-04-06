using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Vetores__While_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tamanhoVetor = 10;
            int[] numerosPares = new int[10];
            int[] numerosImpares = new int[10];

            int numero = 0;
            int contador1 = 0;
            while (contador1 < tamanhoVetor)
            {
                Console.WriteLine("Digite um Número:");
                numero = int.Parse(Console.ReadLine());
                
                if (numero % 2 == 0) 
                {
                    numerosPares[contador1] = numero;
                }
                else 
                {
                    numerosImpares[contador1] = numero;
                }
                contador1++;
                Console.Clear();
            }

            int contador2 = 0;
            while (contador2 < tamanhoVetor) 
            {
                Console.WriteLine("Números Pares:");
                Console.WriteLine(numerosPares[contador2]);
                contador2++;
            }
           
            int contador3 = 0;
            while(contador3 < tamanhoVetor) 
            {
                Console.WriteLine("/n Números Ímpares:");
                Console.WriteLine(numerosImpares[contador3]);
                contador3++;
            }
            Console.ReadKey();
        }
    }
}
