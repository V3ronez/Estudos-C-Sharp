using System;

class veiculo{ //base
    public int velAtual;
    private int velMax;
    protected bool on;

    public veiculo(int velMax){
        velAtual = 0;
        this.velMax = velMax;
        on = false; 
    }

    public bool getOn(){
        return on;
    }

    public int getVelMax(){
        return velMax;
    }
}


class Carro:veiculo{ //derivada de Veiculo
    public string nome;
    public Carro (string nome, int vM):base(vM){
        this.nome = nome; 
        on = true;
    }
}

class Aula36{
    static void Main(){

        Carro carro = new Carro("flex", 200);
    
        Console.WriteLine("Nome: {0}", carro.nome);
        Console.WriteLine("VelMax: {0}", carro.getVelMax());
        Console.WriteLine("Ligado: {0}", carro.getOn());
    }
}