using System;

public class relogio
{
    static int Segundos(int segundos){
        segundos++;
        return segundos;
    }
    
    static int Minutos(int minutos){
        minutos++;
        return minutos;
    }
    
    static int Horas(int horas){
        horas++;
        return horas;
    }
static void Main(){
    int segundos = 0;
    int minutos = 0;
    int horas = 0;
    
    do{
        if(segundos<60){
            segundos = Segundos(segundos);
        }
        if(segundos==60){
            segundos = 0;
            minutos = Minutos(minutos);
        }
        if(minutos==60){
            segundos = 0;
            minutos = 0;
            horas = Horas(horas);
        }
        Console.WriteLine($"{horas}:{minutos}:{segundos}");
    }
    while(horas != 24);
}
}
