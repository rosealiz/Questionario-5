/*Questao 03*/
using System;

public class Datavalida
{
    public static bool Data (int mes, int dia)
    {
    if((mes == 2) && (dia <= 29)){
        return true;
        }
    else if ((mes == 2) && (dia > 29)){
        return false;
        }
    else if ((mes <= 12) && (dia <= 31)){
        return true;
        }
    else{
        return false;
        }
    }
    static void Main(){
        int mes , dia , ano;
        bool validacao;
        
    Console.WriteLine("digite dia");
    dia = int.Parse(Console.ReadLine());
    
    Console.WriteLine("digite mes");
    mes = int.Parse(Console.ReadLine());
    
    Console.WriteLine("digite ano");
    ano = int.Parse(Console.ReadLine());
    
    validacao = Data(mes, dia);
    
    if(validacao == true)
        {
        Console.WriteLine("Data valida");
        }
    else{
        Console.WriteLine("Data invalida");
        }
    }
}  
