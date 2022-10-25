/*Questão 05*/
using System;

public class expoente
{
  static double potenciacao(double Base, double Expoente){
      double calculo;
      calculo = Math.Pow(Base, Expoente);
      return calculo;
  }
  static void Main(){
      double i, j;
      double resultado = 0;
      i = 2;
      while (i <= 20){
         j = 1;
         while (j <= 10){
             j++;
             resultado = potenciacao(i, j);
              Console.WriteLine($"{i} elevado a {j} e igual a {resultado}"); 
         }
         i++;
      }
  }
}
