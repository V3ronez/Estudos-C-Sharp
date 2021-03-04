using System;

class Calculos {
        public int value1;
        public int value2;

    public Calculos (int value1, int value2) {
        this.value1 = value1;
        this.value2 = value2;
}

    public int soma() {
        return value1 + value2;
    }
}

class Aula32
{
    static void Main()
    {
        Calculos calculos= new Calculos(10,2);
        Console.WriteLine(calculos.soma());
    }
}