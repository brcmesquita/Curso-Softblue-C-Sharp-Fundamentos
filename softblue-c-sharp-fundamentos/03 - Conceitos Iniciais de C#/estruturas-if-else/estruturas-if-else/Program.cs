using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estruturas_if_else
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // estruturas de controle if, else

            int x = 10;

            if (x > 5)
            {
                Console.WriteLine("Número é maior que 5");
            }
            else 
            {
                Console.WriteLine("O número não é maior que 5");
                Console.WriteLine(x);
            }

            Console.WriteLine("Fim do programa");
        }
    }
}
