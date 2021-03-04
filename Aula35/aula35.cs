using System;

class veiculo{  //Classe base;
    public int velmax;
    public int wheels;
    private bool on;

    public veiculo(int wheels) {
        this.wheels = wheels;
    }
    public void start(){
        on = true;
    }
    public void off(){
        on = false;
    }

    public string getOn(){
       return (on? "on" : "off");
    }

    public int getWheels(){
        return wheels;
    }

    public void setWheels(int wheels) {
        if(wheels < 0){
            this.wheels = 0;
        } else if (wheels > 40) {
            this.wheels = 40;
        } else {
            this.wheels = wheels;
        }
    }
}

class car:veiculo{

    public string name;
    public string color;
    public car(string name, string color):base(4){
        off();
        velmax = 120;
        this.name = name;
        this.color = color;
    }
}

class carroCombate:car{
    public int ammunition;
    public carroCombate():base("Carro Brabo", "Preto"){
        ammunition = 100;
        setWheels(6);
    }
}

class Aula34 {
    static void Main() {
    car c1 = new car("Marquinhos", "red");
    carroCombate xd1 = new carroCombate();

    c1.start();
    Console.WriteLine("Name: {0}",c1.name);
    Console.WriteLine("Color: {0}",c1.color);
    Console.WriteLine("Wheels: {0}",c1.getWheels());
    Console.WriteLine("Vel max: {0}",c1.velmax);
    Console.WriteLine("Start: {0}",c1.getOn());
    
    Console.WriteLine("------------------------------");

    xd1.start();
    Console.WriteLine("Name: {0}",xd1.name);
    Console.WriteLine("Color: {0}",xd1.color);
    Console.WriteLine("Wheels: {0}",xd1.getWheels());
    Console.WriteLine("Vel max: {0}",xd1.velmax);
    Console.WriteLine("Start: {0}",xd1.getOn());
    Console.WriteLine("Ammunition: {0}",xd1.ammunition);
    
    
    }
}