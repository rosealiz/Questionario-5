//ta incompleto :)
using System;

public class relogio
{
    static bool confirmacao(int numero)
    {
        for(d = 2; d <= numero/2; d++)
        {
            if(numero % d == 0){
                return false;
            }
        return true;
        }
    }
static void Main(){
    int d, n, numero, divisores;
    bool confirmacao;
    
    Console.WriteLine("digite numero");
    numero = int.Parse(Console.ReadLine());
    
    confirmacao = confirmacao(numero);
    Console.WriteLine(" ");
    if(confirmacao == true)
        {
        Console.WriteLine("Data valida");
        }
    else{
        Console.WriteLine("Data invalida");
        }
}
}
