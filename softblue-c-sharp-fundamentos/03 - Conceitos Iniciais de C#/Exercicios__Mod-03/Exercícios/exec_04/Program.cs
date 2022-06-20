// Escreva um programa que calcule o fatorial de 10.

int factorial = 0;
int soma = 0;

for (int i = 10; i >= 1; i--)
{
  factorial += i * (i - 1);
  soma += factorial;
  System.Console.WriteLine("Factorial de " + i + " e " + (i - 1) + " é " + factorial);
}

System.Console.WriteLine("Factorial de 10 é: " + soma);
