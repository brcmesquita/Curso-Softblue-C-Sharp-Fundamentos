using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exec_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Escreva um programa que solicita que sejam digitadas três notas de um aluno
            // e um peso para cada nota.
            // Calcule e imprima a média do aluno.

            // Dica: Para ler as notas via console e convertê-las para double, você pode utilizar:
            // double nota1 = double.Parse(Console.ReadLine());

            Console.Write("Digite a primeira nota: ");
            double nota1 = double.Parse(Console.ReadLine());

            Console.Write("Digite a segunda nota: ");
            double nota2 = double.Parse(Console.ReadLine());

            Console.Write("Digite a terceira nota: ");
            double nota3 = double.Parse(Console.ReadLine());

            double media = (nota1 + nota2 + nota3) / 3;
            Console.WriteLine("A média do alunoe é: " + media);
        }
    }
}
