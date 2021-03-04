using System;

struct Carro{
    public string marca;
    public string modelo;
    public string cor;

    public Carro(string marca, string modelo, string cor){ //Construtor
        this.marca = marca;
        this.modelo = modelo;
        this.cor = cor;
    }

    public void info(){
        Console.WriteLine("marca: {0}",this.marca);
        Console.WriteLine("modelo: {0}",this.modelo);
        Console.WriteLine("cor: {0}",this.cor);
    }

}

class Aula44{
    static void Main(){
        Carro car1;
        car1.marca="Renault";
        car1.modelo = "Clio";
        car1.cor = "preto";

        Carro car2 = new Carro("Honda", "HRV", "Prata");

        car1.info();
        Console.WriteLine("--------------------");
        car2.info();
    }
}