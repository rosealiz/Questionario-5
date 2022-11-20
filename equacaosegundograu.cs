using System;

public class equacaosegundograu
{
    static double[] raizes(double a, double b, double c){
        //esse módulo vai retornar um vetor por isso ele tem [] :)
    double delta = 0;
    double x1 = 0, x2 = 0, status = 0;
    delta = (b * b) - (4 * a * c);
    if(delta > 0){
        x1 = (-b + Math.Sqrt(delta))/(2*a);
        x2 = (-b - Math.Sqrt(delta))/(2*a);
        status= 2;
    double[] retorno = new double[3]{x1,x2,status};
        //criei o vetor que vai ser retornado
    return retorno;
    }
    else if(delta == 0){
        x1 = (-b + Math.Sqrt(delta))/(2*a);
        status= 1;
    double[] retorno = new double[3]{x1,0,status};
    return retorno;
    }
    else{
        status= 0;
    double[] retorno = new double[3]{0,0,status};
    return retorno;
    }
    }
static void Main()
{
   double  x1, x2, delta, a, b, c;
   double[] saida = new double[3];

Console.WriteLine("digite o valor de a, b e c");
   a = double.Parse(Console.ReadLine());
   b = double.Parse(Console.ReadLine());
   c = double.Parse(Console.ReadLine());
   
   if(a==0){
       Console.WriteLine("o coeficiente a deve ser diferente de 0, digite outro valor");
       a = double.Parse(Console.ReadLine());
   }
   saida = raizes(a,b,c);
    //aqui eu "puxo" o módulo (acho que aqui torna o vetor saida igual ao vetor retorno que eu fiz la em cima)
   Console.WriteLine($"status e {saida[2]}, x1 e igual a {saida[0]}, x2 e igual a {saida[1]}");
}
}
