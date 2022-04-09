using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conversao_de_tipos_de_dados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // casting de variáveis

            // implicito
            int i = 10;
            double d = i;

            Console.WriteLine(d);

            short s = 5;
            long l = s;

            // explícito
            double d2 = 3.5;
            //int i2 = d2; // não functiona 
            int i2 = (int)d2; // só functiona se fizermos o casting 

            Console.WriteLine(i2);

        }
    }
}
