using System;

public class Jogador{

    public int energia;        //int e bool sao propriedades || variaveis;
    bool vivo;

    public string nome;

    public Jogador(){ 
        energia = 100;
        vivo = true;
        nome = "Jogador";
    }

   public Jogador(string n){ //Construtor
        energia = 100;
        vivo = true;
        nome = n;
    }

    public Jogador(string n, int e){ //Construtor
        energia = e;
        vivo = true;
        nome = n;
    }

    public Jogador(string n, int e, bool v){ //Construtor
        energia = e;
        vivo = v;
        nome = n;
    }

    public void info() {
        Console.WriteLine("Nome jogador: {0}", nome);
        Console.WriteLine("Energia jogador: {0}", energia);
        Console.WriteLine("Estado jogador: {0}\n", vivo);
    }

}

class Aula30
{
    static void Main()
    {

        Jogador j1 = new Jogador(); //novo objeto da class jogador 
        Jogador j2 = new Jogador("Henrique");  
        Jogador j3 = new Jogador("Henrique", 80);  
        Jogador j4 = new Jogador("v3", 0, false);  
        Jogador j5 = new Jogador("veronez", 10, true);  
       
      

    j1.info();
    j2.info();
    j3.info();
    j4.info();
    j5.info();

    }

}