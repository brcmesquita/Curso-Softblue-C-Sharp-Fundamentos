// Neste exercício, você deve completar 4 tarefas:

// 1. Imprima todos os números de 10 a 25.
for (int i = 10; i < 26; i++)
{
  System.Console.WriteLine("Task 1: " + i);
}


// 2. Imprima a soma dos números de 1 a 100, pulando de dois em dois (1, 3, 5, 7, etc.).
int soma = 0;

for (int i = 0; i <= 100; i++)
{
  if (i % 2 != 0)
  {
    soma += i;
    System.Console.WriteLine("Task 2: " + soma);
  }
}


// 3. Começando em 0, imprima os números seguintes, enquanto a soma dos números já impressos for menor que 100.
int soma2 = 0;
for (int i = 0; i <= 100; i++)
{
  soma2 += i;
  if (soma2 <= 100)
  {
    System.Console.WriteLine("task 3: " + soma2);
  }
}


// 4. Imprima a tabuada do 9 (até o décimo valor).
int tabuada = 0;
for (int i = 0; i <= 10; i++)
{
  tabuada = 9 * i;
  System.Console.WriteLine("Task 4: " + tabuada);
}