using System;

namespace quantas_palavras
{
    class Program
    {
        static void Main(string[] args)
        {
            QuantPalavras();
        }
        static void QuantPalavras()
        {
            Console.Write("Digite a frase: ");
            string frase = Console.ReadLine();
            int numPalav = frase.Split(' ').Length;
            Console.WriteLine("Existem " + numPalav + " palavras nessa frase!");
        }

    }
}
