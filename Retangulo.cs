using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caRetangulo
{
    internal class Retangulo
    {
        //Atributos
        private double comprimento;
        private double altura;

        //métodos

        public Retangulo()
        {
            comprimento= 5.0;
            altura= 5.0; 
        }

        public Retangulo(double comp, double alt)
        {
            comprimento = comp;
            altura = alt;
        }
        public void imprimeDados()
        {
            Console.WriteLine("Comprimento = " + comprimento);
            Console.WriteLine("Altura = " + altura);

        }

        public void setComprimento( double comp)
        {
            comprimento = comp;

        }
        public void setAltura(double alt)
        {
            altura = alt;

        }
        public double getComprimento()
        {
            return comprimento;
        }
        public double getAltura()
        {
            return altura;
        }

        public double Area()
        {
            return (comprimento * altura);
        }

        public double Perimetro()
        {
            return ((comprimento + altura)*2);
        }
    }// fim da classe Retangulo
}
