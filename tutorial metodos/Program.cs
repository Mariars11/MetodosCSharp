using System;

namespace tutorial_metodos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("###- Para conhecer diferentes aliens pressione QUALQUER TECLA -###");
            
            MeetAlien();
            Console.ReadKey();
           
            Console.WriteLine("============================");
            
            MeetAlien();
            Console.ReadKey();
            
            Console.WriteLine("============================");
            
            MeetAlien(); 

            Multiplicacao(3, 8);
            Multiplicacao(7, 13);
            Multiplicacao(11, 5); 

            ParImpar();

            int valorTotal = ParImpar(3,3);
            Console.WriteLine("O resultado é " + valorTotal);

            if(valorTotal % 2 == 0){
                Console.WriteLine(valorTotal + " é um número par!");
            }
            else{
                Console.WriteLine(valorTotal + " é um número ímpar!");
            }
        }
         static void MeetAlien() // criação do método que aleatoriza o nome do alien
        { 
            Random numGen = new Random(); //numero aleatorio

            string nome = "X- " + numGen.Next(10, 9999);
            int idade = numGen.Next(15, 500);

            Console.WriteLine("Olá, me chamo " + nome + " e tenho " + idade + " anos");
            Console.WriteLine("Sim, eu sou um alien!");
        } 
        static void Multiplicacao (int num1, int num2)
        {
            int resultado = num1 * num2;
            Console.WriteLine("O resultado de " + num1 + " x " + num2 + " = " + resultado);
        } 
        static void ParImpar() //sem usar parametros
        {
            Console.Write("Informe o número 1: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Informe o número 2: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int valorTotal = num1 * num2;
            if(valorTotal % 2 == 0){
                Console.WriteLine(valorTotal + " é um número par!");
            }
            else{
                Console.WriteLine(valorTotal + " é um múmero ímpar!");
            }
        } 
        static int ParImpar(int num1, int num2) //usando parametros
        {
            int valorTotal = num1 * num2;
            return valorTotal; 
        }
    }
}
