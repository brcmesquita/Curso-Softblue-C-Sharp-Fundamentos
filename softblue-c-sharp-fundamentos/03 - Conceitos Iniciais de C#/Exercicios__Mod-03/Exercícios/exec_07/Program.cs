// Verifique a validade de uma data e mostre uma mensagem na tela dizendo se a data é válida ou inválida.
// Devem existir três variáveis para armazenar o dia, o mês e o ano, e o usuário deve fornecer os valores para estas variáveis via console.
// Considerar que fevereiro pode ter somente 28 dias e que anos válidos estão compreendidos entre 1900 e 2999.

 int x = 0, y = 1, z;
	    if(x)
	      z = 0;
	    else
	      z = 1;
	     
	    if(y)
	      z = 2;
	    else
	      z = 3;
	     
	    System.Console.WriteLine(z);

int limite = 0;

System.Console.WriteLine("Insira o ano: ");
int ano = int.Parse(System.Console.ReadLine());

System.Console.WriteLine("Insira o mês: ");
int mes = int.Parse(System.Console.ReadLine());

System.Console.WriteLine("Insira o dia: ");
int dia = int.Parse(System.Console.ReadLine());

switch (mes)
{ 
  case 1:
  limite = 31;
  break;
  case 2:
  limite = 28;
  break;
  case 3:
  limite = 31;
  break;
  case 4:
  limite = 30;
  break;
  case 5:
  limite = 31;
  break;
  case 6:
  limite = 30;
  break;
  case 7:
  limite = 31;
  break;
  case 8:
  limite = 31;
  break;
  case 9:
  limite = 30;
  break;
  case 10:
  limite = 31;
  break;
  case 11:
  limite = 30;
  break;
  case 12:
  limite = 31;
  break;
  default:
  System.Console.WriteLine("Mês inválido");
  break;
}


if (dia <= limite)
{
  if (dia <= 0)
  {
    System.Console.WriteLine("Data inválida");
    return;
  }

  System.Console.WriteLine("A data " + dia + "/" + mes + "/" + ano + ", é válida!");
  return;
}


System.Console.WriteLine("A data " + dia + "/" + mes + "/" + ano + ", é inválida! Fumou?!");

