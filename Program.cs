using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caRetangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Retangulo r1 = new Retangulo(); // criando um objeto r1 da classe Retangulo
            Retangulo r2 = new Retangulo(); // criando um objeto r2 da classe Retangulo


            r1.imprimeDados();
            r2.imprimeDados();

            r1.setComprimento(10.5);
            r1.setAltura(8.8);

            r1.imprimeDados();
            r2.imprimeDados();

            Console.WriteLine("perimentro = " + r1.Perimetro());
            Console.WriteLine("Area = " + r2.Area());

            Retangulo r3 = new Retangulo(5.8, 12.5);

            Console.WriteLine("perimentro do r3 = " + r3.Perimetro());
            Console.WriteLine("Area do r3 = " + r3.Area());


            Console.ReadLine();
        }
    }
}
