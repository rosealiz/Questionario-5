using System;

public class relogio
{
    //Módulo para incrementar segundos
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
//se segundos < 60, segundos = o retorno do primeiro método(que incrementa segundos)
        if(segundos<60){
            segundos = Segundos(segundos);
        }
//se segundos == 60, não vai incrementar segundos, portanto deve incrementar minutos, sendo assim, minutos = o retorno do método Minutos(minutos)
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
