using System;
// Escreva um programa semelhante ao do exercício 1, mas agora o número de notas e pesos pode variar.
// O usuário deve digitar quantas notas ele desejar e, para parar, a nota -1 deve ser digitada.
// Neste momento a média das notas e pesos digitados anteriormente deve ser calculada e o resultado impresso na tela.
Console.Write("Digite a quantidade de notas que deseja inserir: ");
int quantidade = int.Parse(Console.ReadLine());

double[] notas = new double[quantidade];

int qtdNotas = 0;

for ( int i = 0; i < quantidade; i++ )
{
  Console.Write("Digite a " + (i + 1) + "ª nota: ");
  double teste = double.Parse(Console.ReadLine());
  
  if (teste != -1)
  {
    notas[i] = teste;
    qtdNotas++;
  }
  else
  {
    break;
  }
}

double media = 0;
double soma = 0;

for (int i = 0; i < qtdNotas; i++)
{
  soma += notas[i];
}

media = soma / qtdNotas;

Console.WriteLine("Total de notas obtidas: " + qtdNotas);
Console.WriteLine("A média do aluno é: " + media);