using System;

class Carro{
    private int velMax;
 
    public int vm{
        get{
            return velMax;
        }
        set{
            if(value < 0) {
                velMax = 0;
            }else if( velMax > 300) {
                velMax = 300;
            } else {
                velMax = value;
            }
        }
    }
    public Carro(){
        vm = 120;
    }

}

class Aula41{
    static void Main(){
        
        Carro car1 = new Carro();

        car1.vm = 200;
        Console.WriteLine("Velocidade: {0}",car1.vm);
    }
}