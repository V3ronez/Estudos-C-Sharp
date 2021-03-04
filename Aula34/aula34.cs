using System;

class veiculo{  //Classe base;
    public int velmax;
    public int wheels;
    private bool on;

    public void start(){
        on = true;
    }
    public void off(){
        on = false;
    }

    public string getOn(){
        if(on){
            return "on";
        } else {
            return "off";
        }
    }
}

class car:veiculo{

    public string name;
    public string color;
    public car(string name, string color){
        off();
        wheels = 4;
        velmax = 120;
        this.name = name;
        this.color = color;
    }
}

class Aula34 {
    static void Main() {
    car c1 = new car("Marquinhos", "red");

    Console.WriteLine("Name: {0}",c1.name);
    Console.WriteLine("Color: {0}",c1.color);
    Console.WriteLine("Wheels: {0}",c1.wheels);
    Console.WriteLine("Vel max: {0}",c1.velmax);
    Console.WriteLine("Start: {0}",c1.getOn());
    }
}