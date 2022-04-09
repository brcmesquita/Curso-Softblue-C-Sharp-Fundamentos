using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace variaveis_e_constantes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variáveis
            
            //int numero;
            //double nota;

            int numero = 5;
            double nota = 9.5;

            numero = numero + 10;
            double nota2 = 9.5 / 2;

            Console.WriteLine(numero);
            Console.WriteLine(nota);

            // Constantes
            double pi = 3.1416; // pode alterar o valor

            pi = 3.14;

            const double pi2 = 3.1416;

            //pi2 = 3.14; // dá erro e não permite a alteração de uma constante





        }
    }
}
