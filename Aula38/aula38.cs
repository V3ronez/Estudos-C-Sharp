using System;

class Base{
    public Base(){
        Console.WriteLine("Construtor da class Base");
    }
    virtual public void info(){
        Console.WriteLine("Base");
    }
}

class Derivada1:Base{
    public Derivada1(){
        Console.WriteLine("Construtor da class Derivada 1");
    }
    override public void info(){
        Console.WriteLine("Deriv1");
    }
}
class Derivada2:Derivada1{
    public Derivada2(){
        Console.WriteLine("Construtor da class Derivada 2");
    }

    override public void info(){
        Console.WriteLine("Deriv2");
    }
}

class Aula38 {
    static void Main() {
        Base Ref;
        Derivada1 derivada1 = new Derivada1();
        Derivada2 derivada2 = new Derivada2();
        Ref = derivada2;

        Ref.info();
    }
}