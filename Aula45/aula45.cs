using System;

struct Carro{
    public string modelo;
    public string cor;


    public void info(){
        Console.WriteLine("modelo: {0}",this.modelo);
        Console.WriteLine("cor: {0}",this.cor);
        Console.WriteLine("--------------------");
    }

}

class Aula44{
    static void Main(){
        

        Carro[] cars = new Carro[4];
        
        cars[0].modelo = "HRV";
        cars[0].cor = "Prata";
        
        cars[1].modelo = "GOlf";
        cars[1].modelo = "Azul";
        
        cars[2].modelo = "clio";
        cars[2].modelo = "preto";
        
        cars[3].modelo = "GOlf";
        cars[3].modelo = "vermelho";

        for(int i = 0; i < cars.Length; i++){
            cars[i].info();
        }

        // cars[0].info();
        // cars[1].info();
        // cars[2].info();
        // cars[3].info();

    }
}