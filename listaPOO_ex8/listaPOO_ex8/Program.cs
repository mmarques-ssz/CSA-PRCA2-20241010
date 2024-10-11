using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listaPOO_ex8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MaiorDeDois mdd;
            //mdd = new MaiorDeDois()
            mdd = new MaiorDeDois(4, 5);

            /*
            Console.Write("Informe o 1º número: ");
            mdd.setN1(int.Parse(Console.ReadLine()));
            Console.Write("Informe o 2º número: ");
            mdd.setN2(int.Parse(Console.ReadLine()));
            */

            mdd.descobrirMaior();

            Console.WriteLine("O maior valor é o {0} que vale {1}",
                mdd.getMaiorExtenso(), mdd.getMaior());
            
        }
    }
}
