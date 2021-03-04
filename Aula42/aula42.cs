using System;

class Carro
{
    private int[] velMax = new int[5] {80,120,240,160,300};

    public int this[int i]
    {
        get
        {
            return velMax[i];
        }
        set
        {
            if (value < 0)
            {
                velMax[i] = 0;
            }
            else if (value > 300)
            {
                velMax[i] = 300;
            }
            else
            {
                velMax[i] = value;
            }
        }
    }
    public Carro(){
    }

}

class Aula42
{
    static void Main()
    {

        Carro car1 = new Carro();

        car1[4] = 200;
        Console.WriteLine("Velocidade: {0}", car1[4]);
    }
}