using System;

abstract class Veiculo
{  //classe base abstrata;
    protected int velMax;
    protected int velAtual;
    protected bool ligado;

    public Veiculo()
    {
        ligado = false;
        velAtual = 0;
    }
    public void setLigado(bool ligado)
    {
        this.ligado = ligado;
    }
    public int getVelAtual(){
        return velAtual;
    }

    abstract public void aceleracao(int mult);
}

class Carro : Veiculo
{
    public Carro()
    {
        velMax = 120;
    }
    override public void aceleracao(int mult)
    {
        velAtual += 10 * mult;
    }
}


class Aula39
{
    static void Main()
    {
        // Veiculo v1 = new Veiculo(); //nao pode instanciar. so pode ser herdada;
       
        Carro car1 = new Carro();
        car1.aceleracao(3);
        car1.aceleracao(-1);
        Console.WriteLine(car1.getVelAtual());
    }
}