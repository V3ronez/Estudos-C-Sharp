using System;
class Jogador
{
    private int energy;

    private string name;

    public Jogador(string name)
    {
        this.name = name;
        energy = 100;
    }

    public int getEnergy()
    {
        return energy;
    }

    public string getName()
    {
        return name;
    }

    public void setEnergy(int e)
    {
        if (e < 0){
            if (energy + e < 0){
                energy = 0;
            }
            else{
                energy += e;
            }
        }
        else if (e > 0){
            if (energy + e > 100){
                energy = 100;
            }
            else{
                energy += e;
            }
        }
    }
}

class Aula33
{
    static void Main()
    {
        Jogador v3 = new Jogador("Carlos");

        v3.setEnergy(-150);

        Console.WriteLine("nome: {0}", v3.getName());
        Console.WriteLine("energia: {0}", v3.getEnergy());
    }
}