using System;
namespace Calculadora
{
    public class Operacoes
    {
        public float Adicao(float n1, float n2){
            return n1 + n2;
        }

        public float Subtracao(float n1, float n2){
            return n1 - n2;
        }

        public float Divisao(float n1, float n2){
            return n1 / n2;
        }

        public float Multiplicacao(float n1, float n2){
            return n1 * n2;
        }

        public double Potencia(float n1, float n2){
            return Math.Pow(n1,n2);
        }

        public double RaizQuadrada(double n1){
            return Math.Sqrt(n1);
        }

        public double Raiz(float n1, float n2){
            return Math.Pow(n1, -n2);
        }
    }
}