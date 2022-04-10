// Imprima os 15 primeiros números da série de Fibonacci.
// A série de Fibonacci possui a seguinte sequência numérica: 0, 1, 1, 2, 3, 5, 8, 13, 21, etc.
// Para calculá-la, o primeiro e segundo elementos valem 1, daí por diante,
// o n-ésimo elemento vale o (n-1)-ésimo elemento somado ao (n-2)-ésimo elemento (ex: 8 = 5 + 3).
// Para mais informações, consulte: http://pt.wikipedia.org/wiki/Número_de_Fibonacci.

int quantidade = 15;
int f1 = 0;
int f2 = 1;
int resultado = 0;

for ( int i = 0; i < quantidade; i++)
{
  resultado = f1 + f2;
  f1 = f2;
  f2 = resultado;
  System.Console.WriteLine("Sequência Fibonacci: " + ( i + 1 ) + ") " + f1 + " + " + f2 + " = " + resultado);
}
