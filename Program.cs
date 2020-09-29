using System;

namespace Calculadora
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Calcular();
        }

        static void Calcular(){
            Numero num = new Numero();
            char operacao;
            Operacoes oper = new Operacoes();

            Console.WriteLine("digite o primeiro numero: ");
            num.x = float.Parse(Console.ReadLine());

            Console.WriteLine("digite o segundo numero: ");
            num.y = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite a operação desejada: A,S,D ou M: ");
            operacao = Convert.ToChar(Console.ReadLine());

            switch (operacao)
            {
                case 'A':
                    Console.WriteLine(oper.Adicao(num.x,num.y));
                    break;
                case 'S':
                    Console.WriteLine(oper.Subtracao(num.x,num.y));
                    break;
                case 'D':
                    Console.WriteLine(oper.Divisao(num.x,num.y));
                    break;
                case 'M':
                    Console.WriteLine(oper.Multiplicacao(num.x,num.y));
                    break;
                default:
                    Console.WriteLine("insira uma opção valida");
                    break;
            }
        }
    }
}
